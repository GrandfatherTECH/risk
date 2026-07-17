using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using ClosedXML.Excel;

namespace RiskiApp
{
    public partial class Form_Главная : Form
    {
        public Form_Главная()
        {
            InitializeComponent();
            CenterToScreen();
            dataGridView_РискиДействия.CellFormatting += dataGridView_РискиДействия_CellFormatting;
            dataGridView_Риски.CellFormatting += dataGridView_Риски_CellFormatting;

            // По умолчанию DataGridView на невалидную ячейку/строку показывает системный диалог
            // с текстом исключения и не даёт покинуть строку, пока она невалидна. Грид может
            // повторно пытаться провалидировать одну и ту же "плохую" строку при каждой попытке
            // уйти с неё - если на это реагировать модальным MessageBox (как было раньше), диалоги
            // накладываются друг на друга и приложением становится невозможно пользоваться.
            // Поэтому просто гасим исключение: строка сама подсвечивается стандартным для
            // DataGridView красным значком ошибки в начале строки (наведение на него показывает
            // текст ошибки) - без всплывающих окон.
            foreach (var grid in new[]
            {
                dataGridView_РискиДействия, dataGridView_Риски, dataGridView_ТипыРисков,
                dataGridView_Процессы, dataGridView_Периоды, dataGridView_Подразделения,
                dataGridView_Пользователи, dataGridView_Мероприятия
            })
            {
                grid.DataError += dataGridView_DataError;
            }
        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            e.Cancel = true;

            // У ещё не сохранённой (новой) строки нет валидного "предыдущего" значения,
            // поэтому отмены одной ячейки (e.Cancel) недостаточно - грид продолжит требовать
            // корректную строку при каждой попытке уйти с неё. CancelEdit() полностью
            // откатывает такую незавершённую строку/ячейку, чтобы работа с таблицей не блокировалась.
            ((DataGridView)sender).CancelEdit();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Выход_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Главная_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Риски". При необходимости она может быть перемещена или удалена.
            this.рискиTableAdapter1.Fill(this.dataSet1.Риски);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.Мероприятия". При необходимости она может быть перемещена или удалена.
            this.мероприятияTableAdapter.Fill(this.dataSet11.Мероприятия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.dataSet1.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Подразделения". При необходимости она может быть перемещена или удалена.
            this.подразделенияTableAdapter.Fill(this.dataSet1.Подразделения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Периоды". При необходимости она может быть перемещена или удалена.
            this.периодыTableAdapter.Fill(this.dataSet1.Периоды);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Процессы". При необходимости она может быть перемещена или удалена.
            this.процессыTableAdapter.Fill(this.dataSet1.Процессы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ТипыРисков". При необходимости она может быть перемещена или удалена.
            this.типыРисковTableAdapter.Fill(this.dataSet1.ТипыРисков);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.РискиДействия". При необходимости она может быть перемещена или удалена.
            this.рискиДействияTableAdapter.Fill(this.dataSet1.РискиДействия);

            DataGridViewColumn column = dataGridView_РискиДействия.Columns["датаОкончанияDataGridViewTextBoxColumn"];

            if (column != null)
            {
                column.DefaultCellStyle.Format = "yyyy-MM-dd";
            }
            
            dataGridView_ТипыРисков.Columns["iDТипаРискаDataGridViewTextBoxColumn1"].Visible = false;
            dataGridView_Процессы.Columns["iDПроцессаDataGridViewTextBoxColumn1"].Visible = false;
            dataGridView_Периоды.Columns["iDПериодаDataGridViewTextBoxColumn1"].Visible = false;
            dataGridView_Подразделения.Columns["iDПодразделенияDataGridViewTextBoxColumn1"].Visible = false;
            dataGridView_Пользователи.Columns["iDПользователяDataGridViewTextBoxColumn1"].Visible = false;
            dataGridView_Мероприятия.Columns["iDМеропритияDataGridViewTextBoxColumn"].Visible = false;
            dataGridView_Риски.Columns["iDРискаDataGridViewTextBoxColumn2"].Visible = false;
            dataGridView_РискиДействия.Columns["уровеньРискаДоМПDataGridViewTextBoxColumn"].Visible = false;
            dataGridView_РискиДействия.Columns["уровеньРискаПослеМПDataGridViewTextBoxColumn"].Visible = false;
            dataGridView_Риски.Columns["dataGridViewTextBoxColumn7"].Visible = false;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Сохранить_РискиДействия_Click(object sender, EventArgs e)
        {
            // Сначала сохраняем все таблицы, на которые ссылается "РискиДействия" (через FK).
            // Это исключает попытку записать в БД ссылку на несохранённую (существующую только
            // в памяти программы) запись - иначе SQL Server вернёт ошибку внешнего ключа и приложение упадёт.
            if (!SafeUpdate(() => периодыTableAdapter.Update(dataSet1.Периоды), "Периоды")) return;
            if (!SaveПодразделения()) return;
            if (!SaveПользователи()) return;
            if (!SafeUpdate(() => процессыTableAdapter.Update(dataSet1.Процессы), "Процессы")) return;
            if (!SafeUpdate(() => типыРисковTableAdapter.Update(dataSet1.ТипыРисков), "Типы рисков")) return;
            if (!SafeUpdate(() => SaveМероприятияAndRemapIds(), "Мероприятия")) return;
            if (!SaveРиски()) return;

            if (!SafeUpdate(() => рискиДействияTableAdapter.Update(dataSet1.РискиДействия), "Риски и действия")) return;
            SafeUpdate(() => рискиДействияTableAdapter.Fill(dataSet1.РискиДействия), "Риски и действия");
        }

        private void button_Сохранить_Риски_Click(object sender, EventArgs e)
        {
            SaveРиски();
        }

        private bool SaveРиски()
        {
            // "Риски" ссылается на Мероприятия, Пользователи и ТипыРисков - сохраняем их первыми.
            if (!SafeUpdate(() => SaveМероприятияAndRemapIds(), "Мероприятия")) return false;
            if (!SaveПользователи()) return false;
            if (!SafeUpdate(() => типыРисковTableAdapter.Update(dataSet1.ТипыРисков), "Типы рисков")) return false;
            return SafeUpdate(() => рискиTableAdapter1.Update(dataSet1.Риски), "Риски");
        }

        private void button_Сохранить_ТипыРисков_Click(object sender, EventArgs e)
        {
            SafeUpdate(() => типыРисковTableAdapter.Update(dataSet1.ТипыРисков), "Типы рисков");
        }

        private void button_Сохранить_Процессы_Click(object sender, EventArgs e)
        {
            SafeUpdate(() => процессыTableAdapter.Update(dataSet1.Процессы), "Процессы");
        }

        private void button_Сохранить_Периоды_Click(object sender, EventArgs e)
        {
            SafeUpdate(() => периодыTableAdapter.Update(dataSet1.Периоды), "Периоды");
        }

        private void button_Сохранить_Подразделения_Click(object sender, EventArgs e)
        {
            SaveПодразделения();
        }

        private bool SaveПодразделения()
        {
            return SafeUpdate(() => подразделенияTableAdapter.Update(dataSet1.Подразделения), "Подразделения");
        }

        private void button_Сохранить_Пользователи_Click(object sender, EventArgs e)
        {
            SaveПользователи();
        }

        private bool SaveПользователи()
        {
            // "Пользователи" ссылается на "Подразделения" - сохраняем подразделения первыми,
            // иначе временный (ещё не выданный БД) ID подразделения попадёт в БД как внешний ключ.
            if (!SaveПодразделения()) return false;
            return SafeUpdate(() => пользователиTableAdapter.Update(dataSet1.Пользователи), "Пользователи");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button_Сохранить_Мероприятия_Click(object sender, EventArgs e)
        {
            SafeUpdate(() => SaveМероприятияAndRemapIds(), "Мероприятия");
        }

        // Показывает понятное сообщение вместо падения программы при ошибке сохранения
        // (например, если запись ссылается на несохранённые данные в связанной таблице).
        private bool SafeUpdate(Action updateAction, string entityName)
        {
            try
            {
                updateAction();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Не удалось сохранить \"{entityName}\": {ex.Message}\n\n" +
                    "Возможно, запись ссылается на ещё не сохранённые данные в связанной таблице. " +
                    "Сохраните сначала связанные данные и повторите попытку.",
                    "Ошибка сохранения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        // "Мероприятия" хранится в отдельном экземпляре набора данных (dataSet11), поэтому связи
        // с "Риски"/"РискиДействия" (dataSet1) не отслеживаются автоматически. После сохранения
        // новых мероприятий их временные ID заменяются на настоящие ID из БД - переносим эти
        // изменения вручную во все строки, которые на них ссылались.
        private void SaveМероприятияAndRemapIds()
        {
            var addedRows = dataSet11.Мероприятия.Rows
                .Cast<DataSet1.МероприятияRow>()
                .Where(r => r.RowState == DataRowState.Added)
                .Select(r => new { Row = r, OldId = r.ID_Меропрития })
                .ToList();

            мероприятияTableAdapter.Update(dataSet11.Мероприятия);

            foreach (var item in addedRows)
            {
                int newId = item.Row.ID_Меропрития;
                if (newId == item.OldId) continue;

                foreach (DataSet1.РискиRow r in dataSet1.Риски.Rows)
                {
                    if (!r.IsID_МероприятияNull() && r.ID_Мероприятия == item.OldId)
                        r.ID_Мероприятия = newId;
                }
                foreach (DataSet1.РискиДействияRow r in dataSet1.РискиДействия.Rows)
                {
                    if (!r.IsID_МероприятияNull() && r.ID_Мероприятия == item.OldId)
                        r.ID_Мероприятия = newId;
                }
            }
        }

        private void dataGridView_Риски_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_РискиДействия_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Проверяем, что ячейка находится в одном из нужных столбцов
            if (e.ColumnIndex == уровеньРискаДоМПDataGridViewTextBoxColumn.Index ||
                e.ColumnIndex == уровеньРискаПослеМПDataGridViewTextBoxColumn.Index)
            {
                // Проверяем, что значение ячейки является числом
                if (e.Value is int || e.Value is double || e.Value is decimal)
                {
                    double value = Convert.ToDouble(e.Value);

                    if (value > 0 && value < 3)
                    {
                        e.CellStyle.BackColor = Color.Green;
                    }
                    else if (value >= 3 && value < 6)
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                    }
                    else if (value >= 6)
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        // Обработка значений, которые не попадают ни в одну из категорий (например, null или отрицательные)
                        e.CellStyle.BackColor = Color.White; // Или другой цвет по умолчанию
                    }
                }
                else
                {
                    // Обработка нечисловых значений
                    e.CellStyle.BackColor = Color.White; // Или другой цвет по умолчанию
                }
            }

            if (this.dataGridView_РискиДействия.Columns[e.ColumnIndex].Name == "УровеньРискаДоМПВычисл")
            {
                // Получаем значение из соседнего столбца с числом
                var val = dataGridView_РискиДействия.Rows[e.RowIndex].Cells["уровеньРискаДоМПDataGridViewTextBoxColumn"].Value;

                if (val != null && double.TryParse(val.ToString(), out double riskValue))
                {
                    // Добавляем условия
                    if (riskValue >= 1 && riskValue <= 2)
                    {
                        e.Value = "Низкий";
                        e.FormattingApplied = true;
                        e.CellStyle.BackColor = Color.Green;
                    }
                    if (riskValue > 2 && riskValue <= 4)
                    {
                        e.Value = "Средний";
                        e.FormattingApplied = true;
                        e.CellStyle.BackColor = Color.Yellow;
                    }
                    if (riskValue > 4)
                    {
                        e.Value = "Высокий";
                        e.FormattingApplied = true;
                        e.CellStyle.BackColor = Color.Red;
                    }
                }
            }
            if (this.dataGridView_РискиДействия.Columns[e.ColumnIndex].Name == "уровеньРискаПослеМПВычисл")
            {
                // Получаем значение из соседнего столбца с числом
                var val = dataGridView_РискиДействия.Rows[e.RowIndex].Cells["уровеньРискаПослеМПDataGridViewTextBoxColumn"].Value;

                if (val != null && double.TryParse(val.ToString(), out double riskValue))
                {
                    // Добавляем условия
                    if (riskValue >= 1 && riskValue <= 2)
                    {
                        e.Value = "Низкий";
                        e.FormattingApplied = true;
                        e.CellStyle.BackColor = Color.Green;
                    }
                    if (riskValue > 2 && riskValue <= 4)
                    {
                        e.Value = "Средний";
                        e.FormattingApplied = true;
                        e.CellStyle.BackColor = Color.Yellow;
                    }
                    if (riskValue > 4)
                    {
                        e.Value = "Высокий";
                        e.FormattingApplied = true;
                        e.CellStyle.BackColor = Color.Red;
                    }
                }
            }
        }
        private void dataGridView_Риски_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Проверяем, что ячейка находится в нужном столбце
            if (e.ColumnIndex == dataGridViewTextBoxColumn7.Index)
            {
                // Проверяем, что значение ячейки является числом
                if (e.Value is int || e.Value is double || e.Value is decimal)
                {
                    double value = Convert.ToDouble(e.Value);

                    if (value > 0 && value < 3)
                    {
                        e.CellStyle.BackColor = Color.Green;
                    }
                    else if (value >= 3 && value < 7)
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                    }
                    else if (value >= 7)
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        // Обработка значений, которые не попадают ни в одну из категорий (например, null или отрицательные)
                        e.CellStyle.BackColor = Color.White; // Или другой цвет по умолчанию
                    }
                }
                else
                {
                    // Обработка нечисловых значений
                    e.CellStyle.BackColor = Color.White; // Или другой цвет по умолчанию
                }
            }
            if (this.dataGridView_Риски.Columns[e.ColumnIndex].Name == "УровеньРискаВычисл")
            {
                // Получаем значение из соседнего столбца с числом
                var val = dataGridView_Риски.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn7"].Value;

                if (val != null && double.TryParse(val.ToString(), out double riskValue))
                {
                    // Добавляем условия
                    if (riskValue >= 1 && riskValue <= 2)
                    {
                        e.Value = "Низкий";
                        e.FormattingApplied = true;
                        e.CellStyle.BackColor = Color.Green;
                    }
                    if (riskValue > 2 && riskValue <= 4)
                    {
                        e.Value = "Средний";
                        e.FormattingApplied = true;
                        e.CellStyle.BackColor = Color.Yellow;
                    }
                    if (riskValue > 4)
                    {
                        e.Value = "Высокий";
                        e.FormattingApplied = true;
                        e.CellStyle.BackColor = Color.Red;
                    }
                }
            }
        }



        // Вспомогательная функция для получения названия риска по ID
        private string GetRiskName(int riskId)
        {
            foreach (DataGridViewRow row in dataGridView_Риски.Rows)
            {
                if (row.Cells["iDРискаDataGridViewTextBoxColumn2"].Value != null && (int)row.Cells["iDРискаDataGridViewTextBoxColumn2"].Value == riskId)
                {
                    return row.Cells["dataGridViewTextBoxColumn1"].Value?.ToString() ?? "Неизвестный риск";
                }
            }
            return "Неизвестный риск"; // Если риск не найден
        }
        // Вспомогательная функция для получения названия мероприятия по ID
        private string GetMeroName(int MeroId)
        {
            foreach (DataGridViewRow row in dataGridView_Мероприятия.Rows)
            {
                if (row.Cells["iDМеропритияDataGridViewTextBoxColumn"].Value != null && (int)row.Cells["iDМеропритияDataGridViewTextBoxColumn"].Value == MeroId)
                {
                    return row.Cells["наименованиеМероприятияDataGridViewTextBoxColumn"].Value?.ToString() ?? "Неизвестное мероприятие";
                }
            }
            return "Неизвестное мероприятие"; // Если мероприятие не найдено
        }
        private void button_Проверка_Click(object sender, EventArgs e)
        {
            // Получаем текущую дату
            DateTime currentDate = DateTime.Now;

            // Создаем список для хранения информации о рисках
            List<string> riskInfo = new List<string>();

            // Перебираем строки в dataGridView_РискиДействия
            foreach (DataGridViewRow row in dataGridView_РискиДействия.Rows)
            {
                // Получаем дату окончания из текущей строки
                if (row.Cells["датаОкончанияDataGridViewTextBoxColumn"].Value != null && row.Cells["датаОкончанияDataGridViewTextBoxColumn"].Value is DateTime)
                {
                    DateTime endDate = (DateTime)row.Cells["датаОкончанияDataGridViewTextBoxColumn"].Value;

                    // Вычисляем разницу между текущей датой и датой окончания
                    TimeSpan difference = endDate - currentDate;

                    // Проверяем, меньше ли разница 14 дней
                    if (difference.Days < 14 && difference.Days >= 0) // Добавляем проверку на неотрицательность
                    {
                        // Получаем ID риска и мероприятия из текущей строки
                        int riskId = (int)row.Cells["iDРискаDataGridViewTextBoxColumn"].Value;
                        int MeroId = (int)row.Cells["idМероприятияDataGridViewTextBoxColumn"].Value;

                        // Находим название риска и мероприятия
                        string riskName = GetRiskName(riskId);
                        string MeroName = GetMeroName(MeroId);

                        // Добавляем информацию о риске и мероприятии в список
                        riskInfo.Add($"Риск: {riskName}, Мероприятие: {MeroName}, Дата реализации: {endDate.ToShortDateString()}");
                        riskInfo.Add(Environment.NewLine);
                    }
                }
            }

            // Отображаем информацию о рисках в RichTextBox в отдельной форме
            if (riskInfo.Count > 0)
            {
                ShowRiskInfo(riskInfo);
            }
            else
            {
                MessageBox.Show("Рисков с датой реализации, близкой к текущей, не найдено.", "Информация");
            }
        }

        // Метод для отображения информации в RichTextBox
        private void ShowRiskInfo(List<string> riskInfo)
        {
            Form riskForm = new Form();
            riskForm.Text = "Риски с близкой датой реализации";
            riskForm.Width = 800;
            riskForm.Height = 600;
            

            RichTextBox riskTextBox = new RichTextBox();
            riskTextBox.Dock = DockStyle.Fill;
            riskTextBox.ReadOnly = true; // Чтобы пользователь не мог редактировать текст

            foreach (string riskText in riskInfo)
            {
                riskTextBox.AppendText(riskText + Environment.NewLine);
            }

            riskForm.Controls.Add(riskTextBox);

            riskForm.ShowDialog();
        }

        private void button_Экспорт_РискиДействия_Click(object sender, EventArgs e)
        {
            ExportDataGridViewToExcel(dataGridView_РискиДействия);
        }
        private void ExportDataGridViewToExcel(DataGridView dgv)
        {
            // Проверка, есть ли данные для экспорта
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Открываем диалоговое окно для сохранения файла
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Сохранить таблицу как Excel файл";
                saveFileDialog.FileName = "Экспорт_Таблицы.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Создаем Excel документ
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            // Добавляем лист
                            var worksheet = workbook.Worksheets.Add("Данные");

                            // Экспортируем заголовки столбцов
                            for (int i = 0; i < dgv.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dgv.Columns[i].HeaderText;

                                // Делаем заголовки жирными
                                worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                            }

                            // Экспортируем сами данные
                            for (int i = 0; i < dgv.Rows.Count; i++)
                            {
                                // Пропускаем пустую строку добавления
                                if (dgv.Rows[i].IsNewRow) continue;

                                for (int j = 0; j < dgv.Columns.Count; j++)
                                {
                                    // Используем FormattedValue,это возьмет именно то, что отображается на экране (текст вместо ID)
                                    var cellValue = dgv.Rows[i].Cells[j].FormattedValue?.ToString() ?? "";

                                    var currentCell = worksheet.Cell(i + 2, j + 1);
                                    currentCell.Value = cellValue;
                                    currentCell.Style.Alignment.WrapText=true;
                                    currentCell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Top;
                                }
                            }

                            // Автоматически подгоняем ширину столбцов под содержимое
                            worksheet.Columns().Width=40;

                            // Сохраняем файл по выбранному пользователем пути
                            workbook.SaveAs(saveFileDialog.FileName);

                            MessageBox.Show("Файл успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Произошла ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button_Экспорт_Риски_Click(object sender, EventArgs e)
        {
            ExportDataGridViewToExcel(dataGridView_Риски);
        }
    }
}
