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
            // с текстом исключения. Гасим исключение: строка сама подсвечивается стандартным для
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

        // Защита от повторного входа: любое действие над гридом внутри обработчика DataError
        // (CancelEdit, изменение значения ячейки, InvalidateRow) само способно вызвать новый
        // DataError. Без флага это даёт бесконечную рекурсию - именно она выглядела как
        // "программа отвечает, но в интерфейсе ничего сделать нельзя".
        private bool _handlingDataError;

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;

            // e.Cancel = true осмысленно только для контекста ввода/фиксации значения: он
            // оставляет ячейку в режиме редактирования, чтобы пользователь исправил ввод.
            // Для ошибок отображения/форматирования отмена ничего не чинит - грид просто
            // пытается отрисовать ту же ячейку снова и снова и генерирует DataError без конца.
            bool isEditContext =
                (e.Context & (DataGridViewDataErrorContexts.Commit |
                              DataGridViewDataErrorContexts.Parsing |
                              DataGridViewDataErrorContexts.LeaveControl)) != 0;
            e.Cancel = isEditContext;

            if (_handlingDataError) return;
            _handlingDataError = true;
            try
            {
                // Значение ячейки здесь НЕ меняем. Раньше "проблемное" значение молча
                // затиралось - ошибка пропадала, но вместе с ней пропадал и введённый
                // пользователем выбор, а сохранение потом тихо уходило в NULL.
                // Вместо этого запоминаем причину и помечаем ячейку штатным для
                // DataGridView значком ошибки. Модальных окон здесь быть не должно:
                // DataError возникает при каждой перерисовке, и MessageBox снова
                // заблокировал бы интерфейс.
                var grid = (DataGridView)sender;
                string columnName = e.ColumnIndex >= 0 && e.ColumnIndex < grid.Columns.Count
                    ? grid.Columns[e.ColumnIndex].HeaderText
                    : "?";

                _lastDataError = $"Таблица \"{grid.Tag ?? grid.Name}\", столбец \"{columnName}\": " +
                                 (e.Exception != null ? e.Exception.Message : "недопустимое значение");

                if (e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count &&
                    e.ColumnIndex >= 0 && e.ColumnIndex < grid.Columns.Count)
                {
                    grid.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = _lastDataError;
                }
            }
            catch
            {
                // Обработчик ошибок не должен сам ронять приложение.
            }
            finally
            {
                _handlingDataError = false;
            }
        }

        // Последняя ошибка привязки данных. Показывается пользователю не сразу (иначе вернётся
        // бесконечный поток окон), а при попытке сохранения - когда объяснение реально нужно.
        private string _lastDataError;

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
            CommitPendingEdits();
            if (!CanSave(dataSet1.РискиДействия)) return;
            _savedRowCount = 0;

            if (!ValidateReferences("Риски и действия", dataSet1.РискиДействия,
                new ReferenceCheck(dataSet1.РискиДействия.ID_ПериодаColumn, dataSet1.Периоды,
                    "НаименованиеПериода", "Период", "Периоды"),
                new ReferenceCheck(dataSet1.РискиДействия.ID_ПодразделенияColumn, dataSet1.Подразделения,
                    "НаименованиеПодразделения", "Подразделение", "Подразделения"),
                new ReferenceCheck(dataSet1.РискиДействия.ID_ПроцессаColumn, dataSet1.Процессы,
                    "НаименованиеПроцесса", "Процесс", "Процессы"),
                new ReferenceCheck(dataSet1.РискиДействия.ID_РискаColumn, dataSet1.Риски,
                    "НаименованиеРиска", "Риск", "Риски"),
                new ReferenceCheck(dataSet1.РискиДействия.ID_МероприятияColumn, dataSet11.Мероприятия,
                    "НаименованиеМероприятия", "Мероприятие", "Мероприятия"),
                new ReferenceCheck(dataSet1.РискиДействия.ID_ПользователяColumn, dataSet1.Пользователи,
                    "Фамилия", "Ответственный", "Пользователи"))) return;

            if (!SafeUpdate(() => рискиДействияTableAdapter.Update(dataSet1.РискиДействия), "Риски и действия")) return;

            // Перечитывание не является сохранением - его строки не должны попасть в счётчик.
            int saved = _savedRowCount;
            SafeUpdate(() => рискиДействияTableAdapter.Fill(dataSet1.РискиДействия), "Риски и действия");
            _savedRowCount = saved;

            ReportSaveResult(true);
        }

        private void button_Сохранить_Риски_Click(object sender, EventArgs e)
        {
            CommitPendingEdits();
            if (!CanSave(dataSet1.Риски)) return;
            _savedRowCount = 0;
            ReportSaveResult(SaveРиски());
        }

        private bool SaveРиски()
        {
            if (!ValidateReferences("Риски", dataSet1.Риски,
                new ReferenceCheck(dataSet1.Риски.ID_ТипаРискаColumn, dataSet1.ТипыРисков,
                    "НаименованиеТипаРиска", "Тип риска", "Типы рисков"),
                new ReferenceCheck(dataSet1.Риски.ID_МероприятияColumn, dataSet11.Мероприятия,
                    "НаименованиеМероприятия", "Мероприятие", "Мероприятия"),
                new ReferenceCheck(dataSet1.Риски.ID_ПользователяColumn, dataSet1.Пользователи,
                    "Фамилия", "Ответственный", "Пользователи"))) return false;

            return SaveLookup(
                "Риски",
                () => рискиTableAdapter1.Update(dataSet1.Риски),
                dataSet1.Риски, "ID_Риска",
                dataSet1.РискиДействия.ID_РискаColumn);
        }

        private void button_Сохранить_ТипыРисков_Click(object sender, EventArgs e)
        {
            CommitPendingEdits();
            if (!CanSave(dataSet1.ТипыРисков)) return;
            _savedRowCount = 0;
            ReportSaveResult(SaveТипыРисков());
        }

        private void button_Сохранить_Процессы_Click(object sender, EventArgs e)
        {
            CommitPendingEdits();
            if (!CanSave(dataSet1.Процессы)) return;
            _savedRowCount = 0;
            ReportSaveResult(SaveПроцессы());
        }

        private void button_Сохранить_Периоды_Click(object sender, EventArgs e)
        {
            CommitPendingEdits();
            if (!CanSave(dataSet1.Периоды)) return;
            _savedRowCount = 0;
            ReportSaveResult(SaveПериоды());
        }

        private void button_Сохранить_Подразделения_Click(object sender, EventArgs e)
        {
            CommitPendingEdits();
            if (!CanSave(dataSet1.Подразделения)) return;
            _savedRowCount = 0;
            ReportSaveResult(SaveПодразделения());
        }

        private bool SaveПодразделения()
        {
            return SaveLookup(
                "Подразделения",
                () => подразделенияTableAdapter.Update(dataSet1.Подразделения),
                dataSet1.Подразделения, "ID_Подразделения",
                dataSet1.Пользователи.ID_ПодразделенияColumn,
                dataSet1.РискиДействия.ID_ПодразделенияColumn);
        }

        private void button_Сохранить_Пользователи_Click(object sender, EventArgs e)
        {
            CommitPendingEdits();
            if (!CanSave(dataSet1.Пользователи)) return;
            _savedRowCount = 0;
            ReportSaveResult(SaveПользователи());
        }

        private bool SaveПользователи()
        {
            if (!ValidateReferences("Пользователи", dataSet1.Пользователи,
                new ReferenceCheck(dataSet1.Пользователи.ID_ПодразделенияColumn, dataSet1.Подразделения,
                    "НаименованиеПодразделения", "Подразделение", "Подразделения"))) return false;

            return SaveLookup(
                "Пользователи",
                () => пользователиTableAdapter.Update(dataSet1.Пользователи),
                dataSet1.Пользователи, "ID_Пользователя",
                dataSet1.Риски.ID_ПользователяColumn,
                dataSet1.РискиДействия.ID_ПользователяColumn);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button_Сохранить_Мероприятия_Click(object sender, EventArgs e)
        {
            CommitPendingEdits();
            if (!CanSave(dataSet11.Мероприятия)) return;
            _savedRowCount = 0;
            ReportSaveResult(SaveМероприятия());
        }

        // Значение ячейки, которую пользователь редактирует прямо сейчас, ещё не перенесено
        // в DataTable. Без принудительной фиксации нажатие "Сохранить" молча теряет последнюю
        // введённую строку.
        private void CommitPendingEdits()
        {
            foreach (var grid in new[]
            {
                dataGridView_РискиДействия, dataGridView_Риски, dataGridView_ТипыРисков,
                dataGridView_Процессы, dataGridView_Периоды, dataGridView_Подразделения,
                dataGridView_Пользователи, dataGridView_Мероприятия
            })
            {
                grid.EndEdit();
                var bindingSource = grid.DataSource as BindingSource;
                if (bindingSource != null) bindingSource.EndEdit();
            }
        }

        // Сколько строк реально ушло в БД за текущее нажатие "Сохранить".
        private int _savedRowCount;

        // Описание внешней ссылки: колонка дочерней таблицы и справочник, на который она указывает.
        private sealed class ReferenceCheck
        {
            public readonly DataColumn Column;      // например, Пользователи.ID_Подразделения
            public readonly DataTable Parent;       // Подразделения
            public readonly string ParentNameColumn;// чем назвать запись в сообщении
            public readonly string FieldTitle;      // как поле называется для пользователя
            public readonly string ParentTabTitle;  // куда пользователю идти сохранять

            public ReferenceCheck(DataColumn column, DataTable parent, string parentNameColumn,
                                  string fieldTitle, string parentTabTitle)
            {
                Column = column;
                Parent = parent;
                ParentNameColumn = parentNameColumn;
                FieldTitle = fieldTitle;
                ParentTabTitle = parentTabTitle;
            }
        }

        // Кнопка "Сохранить" на вкладке записывает ТОЛЬКО свою таблицу. Поэтому строка может
        // ссылаться на запись справочника, которая существует лишь в памяти программы: у такой
        // записи временный отрицательный ID, и в БД её нет. Раньше это приводило либо к падению
        // на внешнем ключе, либо (после автосохранения родителей) к записи чужих вкладок в
        // непредсказуемом порядке. Правильное поведение - отказаться сохранять и объяснить,
        // что именно мешает.
        private bool ValidateReferences(string entityName, DataTable table, params ReferenceCheck[] checks)
        {
            var problems = new List<string>();

            foreach (DataRow row in table.Rows)
            {
                if (row.RowState != DataRowState.Added && row.RowState != DataRowState.Modified)
                    continue;

                foreach (var check in checks)
                {
                    if (row.IsNull(check.Column)) continue;

                    int id = (int)row[check.Column];
                    DataRow parent = check.Parent.Rows.Find(id);

                    if (parent == null)
                    {
                        problems.Add($"• поле \"{check.FieldTitle}\" ссылается на запись, которой больше нет.");
                        continue;
                    }

                    if (parent.RowState == DataRowState.Added)
                    {
                        string name = parent.IsNull(check.ParentNameColumn)
                            ? "(без названия)"
                            : parent[check.ParentNameColumn].ToString();

                        problems.Add(
                            $"• поле \"{check.FieldTitle}\" ссылается на \"{name}\" - " +
                            $"эта запись ещё не сохранена в базе данных.\n" +
                            $"  Откройте вкладку \"{check.ParentTabTitle}\", сохраните её, затем вернитесь сюда.");
                    }
                }
            }

            if (problems.Count == 0) return true;

            MessageBox.Show(
                $"Не удалось сохранить \"{entityName}\": есть ссылки на несохранённые данные.\n\n" +
                string.Join("\n", problems.Distinct()),
                "Сначала сохраните связанные данные",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        // Вызывается перед сохранением. Отвечает на вопрос "почему ничего не произошло":
        // либо в гриде есть строка, которую не удалось зафиксировать, либо менять просто нечего.
        private bool CanSave(DataTable table)
        {
            var problems = new List<string>();
            foreach (DataRow row in table.GetErrors())
            {
                string columns = string.Join(", ",
                    row.GetColumnsInError().Select(c => c.ColumnName));
                string text = string.IsNullOrEmpty(row.RowError) ? "недопустимое значение" : row.RowError;
                problems.Add($"• {table.TableName}" +
                             (columns.Length > 0 ? $" (поля: {columns})" : "") + $": {text}");
            }

            if (problems.Count > 0)
            {
                MessageBox.Show(
                    "Сохранение не выполнено: в таблице есть строки с ошибками.\n\n" +
                    string.Join("\n", problems) +
                    "\n\nИсправьте отмеченные красным значком строки и повторите сохранение.",
                    "Нельзя сохранить",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (table.GetChanges() == null)
            {
                // Самый частый случай "нажал - и ничего": строка так и осталась незафиксированной
                // в гриде, поэтому в наборе данных изменений нет вообще.
                string reason = _lastDataError != null
                    ? "\n\nПоследняя ошибка ввода:\n" + _lastDataError
                    : "\n\nЕсли вы только что заполняли строку, убедитесь, что ввод в ячейке " +
                      "завершён (нажмите Enter или перейдите на другую строку).";

                MessageBox.Show(
                    "Нет изменений для сохранения." + reason,
                    "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        // Итоговый отчёт. Пользователь всегда должен узнать, что именно произошло.
        private void ReportSaveResult(bool success)
        {
            if (!success) return; // об ошибке уже сообщил SafeUpdate

            MessageBox.Show(
                _savedRowCount > 0
                    ? $"Сохранено записей: {_savedRowCount}."
                    : "Изменения не потребовались: в базе данных уже актуальные данные.",
                "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Показывает понятное сообщение вместо падения программы при ошибке сохранения
        // (например, если запись ссылается на несохранённые данные в связанной таблице).
        private bool SafeUpdate(Func<int> updateAction, string entityName)
        {
            try
            {
                _savedRowCount += updateAction();
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

        // Новой записи справочника DataSet присваивает временный отрицательный ID
        // (AutoIncrementSeed = -1, шаг -1). Настоящий ID выдаёт СУБД при сохранении, и адаптер
        // подставляет его в родительскую строку через SCOPE_IDENTITY(). Но связи в DataSet
        // созданы без ограничений (createConstraints: false), поэтому каскадного обновления
        // внешних ключей нет: дочерние строки продолжают ссылаться на временный ID.
        //
        // Именно отсюда росли обе жалобы. Ссылка на несуществующий ID либо валит сохранение
        // дочерней таблицы нарушением внешнего ключа, либо делает значение ячейки-справочника
        // недопустимым - и тогда DataGridView генерирует DataError при каждой перерисовке,
        // то есть бесконечно. Поэтому после сохранения справочника переносим новые ID во все
        // ссылающиеся колонки вручную.
        private bool SaveLookup(
            string entityName,
            Func<int> updateAction,
            DataTable parentTable,
            string idColumnName,
            params DataColumn[] childForeignKeys)
        {
            var addedRows = parentTable.Rows
                .Cast<DataRow>()
                .Where(r => r.RowState == DataRowState.Added)
                .Select(r => new { Row = r, OldId = (int)r[idColumnName] })
                .ToList();

            bool saved = SafeUpdate(updateAction, entityName);

            // Перенос ID выполняем и после неудачного сохранения: DataAdapter пишет строки
            // по одной, поэтому часть записей могла успеть получить настоящие ID до ошибки.
            // Если оставить дочерние строки со ссылками на старые временные ID, вернётся
            // та же самая бесконечная ошибка отображения.
            foreach (var item in addedRows)
            {
                if (item.Row.RowState == DataRowState.Detached ||
                    item.Row.RowState == DataRowState.Deleted) continue;

                int newId = (int)item.Row[idColumnName];
                if (newId == item.OldId) continue;

                foreach (var childColumn in childForeignKeys)
                    ReplaceForeignKey(childColumn, item.OldId, newId);
            }
            return saved;
        }

        // Колонки ID в схеме помечены как ReadOnly, поэтому на время замены снимаем флаг.
        private static void ReplaceForeignKey(DataColumn column, int oldId, int newId)
        {
            bool wasReadOnly = column.ReadOnly;
            column.ReadOnly = false;
            try
            {
                foreach (DataRow row in column.Table.Rows)
                {
                    if (row.RowState == DataRowState.Deleted ||
                        row.RowState == DataRowState.Detached) continue;
                    if (row.IsNull(column)) continue;
                    if ((int)row[column] == oldId) row[column] = newId;
                }
            }
            finally
            {
                column.ReadOnly = wasReadOnly;
            }
        }

        // "Мероприятия" загружается в отдельный экземпляр набора данных (dataSet11), поэтому
        // ссылающиеся на него колонки берём явно из dataSet1.
        private bool SaveМероприятия()
        {
            return SaveLookup(
                "Мероприятия",
                () => мероприятияTableAdapter.Update(dataSet11.Мероприятия),
                dataSet11.Мероприятия, "ID_Меропрития",
                dataSet1.Риски.ID_МероприятияColumn,
                dataSet1.РискиДействия.ID_МероприятияColumn);
        }

        private bool SaveПериоды()
        {
            return SaveLookup(
                "Периоды",
                () => периодыTableAdapter.Update(dataSet1.Периоды),
                dataSet1.Периоды, "ID_Периода",
                dataSet1.РискиДействия.ID_ПериодаColumn);
        }

        private bool SaveПроцессы()
        {
            return SaveLookup(
                "Процессы",
                () => процессыTableAdapter.Update(dataSet1.Процессы),
                dataSet1.Процессы, "ID_Процесса",
                dataSet1.РискиДействия.ID_ПроцессаColumn);
        }

        private bool SaveТипыРисков()
        {
            return SaveLookup(
                "Типы рисков",
                () => типыРисковTableAdapter.Update(dataSet1.ТипыРисков),
                dataSet1.ТипыРисков, "ID_ТипаРиска",
                dataSet1.Риски.ID_ТипаРискаColumn);
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
                if (row.Cells["iDРискаDataGridViewTextBoxColumn2"].Value is int && (int)row.Cells["iDРискаDataGridViewTextBoxColumn2"].Value == riskId)
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
                if (row.Cells["iDМеропритияDataGridViewTextBoxColumn"].Value is int && (int)row.Cells["iDМеропритияDataGridViewTextBoxColumn"].Value == MeroId)
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
                        // В незаполненной или частично заполненной строке ссылки на риск и
                        // мероприятие могут отсутствовать - прямое приведение к int уронило бы
                        // программу, поэтому такие строки просто пропускаем.
                        var riskCell = row.Cells["iDРискаDataGridViewTextBoxColumn"].Value;
                        var meroCell = row.Cells["idМероприятияDataGridViewTextBoxColumn"].Value;
                        if (!(riskCell is int) || !(meroCell is int)) continue;

                        int riskId = (int)riskCell;
                        int MeroId = (int)meroCell;

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
