namespace RiskiApp
{
    partial class Form_Главная
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer_Главная = new System.Windows.Forms.SplitContainer();
            this.tabControl_Главный = new System.Windows.Forms.TabControl();
            this.tabPage_РискиДействия = new System.Windows.Forms.TabPage();
            this.splitContainer_РискиДействия = new System.Windows.Forms.SplitContainer();
            this.dataGridView_РискиДействия = new System.Windows.Forms.DataGridView();
            this.подразделенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new RiskiApp.DataSet1();
            this.мероприятияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new RiskiApp.DataSet1();
            this.процессыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типыРисковBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рискиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.периодыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рискиДействияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Экспорт_РискиДействия = new System.Windows.Forms.Button();
            this.button_Сохранить_РискиДействия = new System.Windows.Forms.Button();
            this.tabPage_Риски = new System.Windows.Forms.TabPage();
            this.splitContainer_Риски = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Риски = new System.Windows.Forms.DataGridView();
            this.button_Экспорт_Риски = new System.Windows.Forms.Button();
            this.button_Сохранить_Риски = new System.Windows.Forms.Button();
            this.tabPage_ТипыРисков = new System.Windows.Forms.TabPage();
            this.splitContainer_ТипыРисков = new System.Windows.Forms.SplitContainer();
            this.dataGridView_ТипыРисков = new System.Windows.Forms.DataGridView();
            this.iDТипаРискаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеТипаРискаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Сохранить_ТипыРисков = new System.Windows.Forms.Button();
            this.tabPage_Процессы = new System.Windows.Forms.TabPage();
            this.splitContainer_Процессы = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Процессы = new System.Windows.Forms.DataGridView();
            this.button_Сохранить_Процессы = new System.Windows.Forms.Button();
            this.tabPage_Периоды = new System.Windows.Forms.TabPage();
            this.splitContainer_Периоды = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Периоды = new System.Windows.Forms.DataGridView();
            this.iDПериодаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеПериодаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Сохранить_Периоды = new System.Windows.Forms.Button();
            this.tabPage_Подразделения = new System.Windows.Forms.TabPage();
            this.splitContainer_Подразделения = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Подразделения = new System.Windows.Forms.DataGridView();
            this.button_Сохранить_Подразделения = new System.Windows.Forms.Button();
            this.tabPage_Пользователи = new System.Windows.Forms.TabPage();
            this.splitContainer_Пользователи = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Пользователи = new System.Windows.Forms.DataGridView();
            this.button_Сохранить_Пользователи = new System.Windows.Forms.Button();
            this.tabPage_Мероприятия = new System.Windows.Forms.TabPage();
            this.splitContainer_Мероприятия = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Мероприятия = new System.Windows.Forms.DataGridView();
            this.button_Сохранить_Мероприятия = new System.Windows.Forms.Button();
            this.button_Проверка = new System.Windows.Forms.Button();
            this.button_Выход = new System.Windows.Forms.Button();
            this.dataSet12 = new RiskiApp.DataSet1();
            this.рискиДействияTableAdapter = new RiskiApp.DataSet1TableAdapters.РискиДействияTableAdapter();
            this.типыРисковTableAdapter = new RiskiApp.DataSet1TableAdapters.ТипыРисковTableAdapter();
            this.процессыTableAdapter = new RiskiApp.DataSet1TableAdapters.ПроцессыTableAdapter();
            this.периодыTableAdapter = new RiskiApp.DataSet1TableAdapters.ПериодыTableAdapter();
            this.подразделенияTableAdapter = new RiskiApp.DataSet1TableAdapters.ПодразделенияTableAdapter();
            this.пользователиTableAdapter = new RiskiApp.DataSet1TableAdapters.ПользователиTableAdapter();
            this.мероприятияTableAdapter = new RiskiApp.DataSet1TableAdapters.МероприятияTableAdapter();
            this.dataSet13 = new RiskiApp.DataSet1();
            this.рискиTableAdapter1 = new RiskiApp.DataSet1TableAdapters.РискиTableAdapter();
            this.iDПроцессаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеПроцессаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПодразделенияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеПодразделенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПользователяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПодразделенияDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.isАдминистраторDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDМеропритияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеМероприятияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПодразделенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idМероприятияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDПроцессаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IDТипаРиска = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDРискаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDПериодаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.датаОкончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вероятностьРискаДоМПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.последствияРискаДоМПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уровеньРискаДоМПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.УровеньРискаДоМПВычисл = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вероятностьРискаПослеМПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.последствияРискаПослеМПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уровеньРискаПослеМПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уровеньРискаПослеМПВычисл = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ЭффективностьМероприятия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПользователяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDРискаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.УровеньРискаВычисл = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDМероприятияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПользователяDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Главная)).BeginInit();
            this.splitContainer_Главная.Panel1.SuspendLayout();
            this.splitContainer_Главная.Panel2.SuspendLayout();
            this.splitContainer_Главная.SuspendLayout();
            this.tabControl_Главный.SuspendLayout();
            this.tabPage_РискиДействия.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_РискиДействия)).BeginInit();
            this.splitContainer_РискиДействия.Panel1.SuspendLayout();
            this.splitContainer_РискиДействия.Panel2.SuspendLayout();
            this.splitContainer_РискиДействия.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_РискиДействия)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подразделенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мероприятияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процессыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типыРисковBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рискиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.периодыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рискиДействияBindingSource)).BeginInit();
            this.tabPage_Риски.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Риски)).BeginInit();
            this.splitContainer_Риски.Panel1.SuspendLayout();
            this.splitContainer_Риски.Panel2.SuspendLayout();
            this.splitContainer_Риски.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Риски)).BeginInit();
            this.tabPage_ТипыРисков.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_ТипыРисков)).BeginInit();
            this.splitContainer_ТипыРисков.Panel1.SuspendLayout();
            this.splitContainer_ТипыРисков.Panel2.SuspendLayout();
            this.splitContainer_ТипыРисков.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ТипыРисков)).BeginInit();
            this.tabPage_Процессы.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Процессы)).BeginInit();
            this.splitContainer_Процессы.Panel1.SuspendLayout();
            this.splitContainer_Процессы.Panel2.SuspendLayout();
            this.splitContainer_Процессы.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Процессы)).BeginInit();
            this.tabPage_Периоды.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Периоды)).BeginInit();
            this.splitContainer_Периоды.Panel1.SuspendLayout();
            this.splitContainer_Периоды.Panel2.SuspendLayout();
            this.splitContainer_Периоды.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Периоды)).BeginInit();
            this.tabPage_Подразделения.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Подразделения)).BeginInit();
            this.splitContainer_Подразделения.Panel1.SuspendLayout();
            this.splitContainer_Подразделения.Panel2.SuspendLayout();
            this.splitContainer_Подразделения.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Подразделения)).BeginInit();
            this.tabPage_Пользователи.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Пользователи)).BeginInit();
            this.splitContainer_Пользователи.Panel1.SuspendLayout();
            this.splitContainer_Пользователи.Panel2.SuspendLayout();
            this.splitContainer_Пользователи.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Пользователи)).BeginInit();
            this.tabPage_Мероприятия.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Мероприятия)).BeginInit();
            this.splitContainer_Мероприятия.Panel1.SuspendLayout();
            this.splitContainer_Мероприятия.Panel2.SuspendLayout();
            this.splitContainer_Мероприятия.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Мероприятия)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer_Главная
            // 
            this.splitContainer_Главная.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Главная.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Главная.Name = "splitContainer_Главная";
            this.splitContainer_Главная.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Главная.Panel1
            // 
            this.splitContainer_Главная.Panel1.Controls.Add(this.tabControl_Главный);
            this.splitContainer_Главная.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer_Главная.Panel2
            // 
            this.splitContainer_Главная.Panel2.Controls.Add(this.button_Проверка);
            this.splitContainer_Главная.Panel2.Controls.Add(this.button_Выход);
            this.splitContainer_Главная.Size = new System.Drawing.Size(800, 450);
            this.splitContainer_Главная.SplitterDistance = 326;
            this.splitContainer_Главная.TabIndex = 0;
            // 
            // tabControl_Главный
            // 
            this.tabControl_Главный.Controls.Add(this.tabPage_РискиДействия);
            this.tabControl_Главный.Controls.Add(this.tabPage_Риски);
            this.tabControl_Главный.Controls.Add(this.tabPage_ТипыРисков);
            this.tabControl_Главный.Controls.Add(this.tabPage_Процессы);
            this.tabControl_Главный.Controls.Add(this.tabPage_Периоды);
            this.tabControl_Главный.Controls.Add(this.tabPage_Подразделения);
            this.tabControl_Главный.Controls.Add(this.tabPage_Пользователи);
            this.tabControl_Главный.Controls.Add(this.tabPage_Мероприятия);
            this.tabControl_Главный.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Главный.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Главный.Name = "tabControl_Главный";
            this.tabControl_Главный.SelectedIndex = 0;
            this.tabControl_Главный.Size = new System.Drawing.Size(800, 326);
            this.tabControl_Главный.TabIndex = 0;
            // 
            // tabPage_РискиДействия
            // 
            this.tabPage_РискиДействия.Controls.Add(this.splitContainer_РискиДействия);
            this.tabPage_РискиДействия.Location = new System.Drawing.Point(4, 25);
            this.tabPage_РискиДействия.Name = "tabPage_РискиДействия";
            this.tabPage_РискиДействия.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_РискиДействия.Size = new System.Drawing.Size(792, 297);
            this.tabPage_РискиДействия.TabIndex = 0;
            this.tabPage_РискиДействия.Text = "Риски Действия";
            this.tabPage_РискиДействия.UseVisualStyleBackColor = true;
            // 
            // splitContainer_РискиДействия
            // 
            this.splitContainer_РискиДействия.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_РискиДействия.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_РискиДействия.Name = "splitContainer_РискиДействия";
            // 
            // splitContainer_РискиДействия.Panel1
            // 
            this.splitContainer_РискиДействия.Panel1.Controls.Add(this.dataGridView_РискиДействия);
            // 
            // splitContainer_РискиДействия.Panel2
            // 
            this.splitContainer_РискиДействия.Panel2.Controls.Add(this.button_Экспорт_РискиДействия);
            this.splitContainer_РискиДействия.Panel2.Controls.Add(this.button_Сохранить_РискиДействия);
            this.splitContainer_РискиДействия.Size = new System.Drawing.Size(786, 291);
            this.splitContainer_РискиДействия.SplitterDistance = 465;
            this.splitContainer_РискиДействия.TabIndex = 0;
            // 
            // dataGridView_РискиДействия
            // 
            this.dataGridView_РискиДействия.AutoGenerateColumns = false;
            this.dataGridView_РискиДействия.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_РискиДействия.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПодразделенияDataGridViewTextBoxColumn,
            this.idМероприятияDataGridViewTextBoxColumn,
            this.iDПроцессаDataGridViewTextBoxColumn,
            this.IDТипаРиска,
            this.iDРискаDataGridViewTextBoxColumn,
            this.iDПериодаDataGridViewTextBoxColumn,
            this.датаОкончанияDataGridViewTextBoxColumn,
            this.вероятностьРискаДоМПDataGridViewTextBoxColumn,
            this.последствияРискаДоМПDataGridViewTextBoxColumn,
            this.уровеньРискаДоМПDataGridViewTextBoxColumn,
            this.УровеньРискаДоМПВычисл,
            this.вероятностьРискаПослеМПDataGridViewTextBoxColumn,
            this.последствияРискаПослеМПDataGridViewTextBoxColumn,
            this.уровеньРискаПослеМПDataGridViewTextBoxColumn,
            this.уровеньРискаПослеМПВычисл,
            this.ЭффективностьМероприятия,
            this.iDПользователяDataGridViewTextBoxColumn});
            this.dataGridView_РискиДействия.DataSource = this.рискиДействияBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_РискиДействия.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_РискиДействия.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_РискиДействия.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_РискиДействия.Name = "dataGridView_РискиДействия";
            this.dataGridView_РискиДействия.RowHeadersWidth = 51;
            this.dataGridView_РискиДействия.RowTemplate.Height = 100;
            this.dataGridView_РискиДействия.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_РискиДействия.Size = new System.Drawing.Size(465, 291);
            this.dataGridView_РискиДействия.TabIndex = 0;
            // 
            // подразделенияBindingSource
            // 
            this.подразделенияBindingSource.DataMember = "Подразделения";
            this.подразделенияBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // мероприятияBindingSource
            // 
            this.мероприятияBindingSource.DataMember = "Мероприятия";
            this.мероприятияBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // процессыBindingSource
            // 
            this.процессыBindingSource.DataMember = "Процессы";
            this.процессыBindingSource.DataSource = this.dataSet1;
            // 
            // типыРисковBindingSource
            // 
            this.типыРисковBindingSource.DataMember = "ТипыРисков";
            this.типыРисковBindingSource.DataSource = this.dataSet1;
            // 
            // рискиBindingSource
            // 
            this.рискиBindingSource.DataMember = "Риски";
            this.рискиBindingSource.DataSource = this.dataSet1;
            // 
            // периодыBindingSource
            // 
            this.периодыBindingSource.DataMember = "Периоды";
            this.периодыBindingSource.DataSource = this.dataSet1;
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "Пользователи";
            this.пользователиBindingSource.DataSource = this.dataSet1;
            // 
            // рискиДействияBindingSource
            // 
            this.рискиДействияBindingSource.DataMember = "РискиДействия";
            this.рискиДействияBindingSource.DataSource = this.dataSet1;
            // 
            // button_Экспорт_РискиДействия
            // 
            this.button_Экспорт_РискиДействия.AutoSize = true;
            this.button_Экспорт_РискиДействия.Location = new System.Drawing.Point(52, 66);
            this.button_Экспорт_РискиДействия.Name = "button_Экспорт_РискиДействия";
            this.button_Экспорт_РискиДействия.Size = new System.Drawing.Size(175, 26);
            this.button_Экспорт_РискиДействия.TabIndex = 1;
            this.button_Экспорт_РискиДействия.Text = "Экспортировать в файл";
            this.button_Экспорт_РискиДействия.UseVisualStyleBackColor = true;
            this.button_Экспорт_РискиДействия.Click += new System.EventHandler(this.button_Экспорт_РискиДействия_Click);
            // 
            // button_Сохранить_РискиДействия
            // 
            this.button_Сохранить_РискиДействия.Location = new System.Drawing.Point(52, 17);
            this.button_Сохранить_РискиДействия.Name = "button_Сохранить_РискиДействия";
            this.button_Сохранить_РискиДействия.Size = new System.Drawing.Size(90, 30);
            this.button_Сохранить_РискиДействия.TabIndex = 0;
            this.button_Сохранить_РискиДействия.Text = "Сохранить";
            this.button_Сохранить_РискиДействия.UseVisualStyleBackColor = true;
            this.button_Сохранить_РискиДействия.Click += new System.EventHandler(this.button_Сохранить_РискиДействия_Click);
            // 
            // tabPage_Риски
            // 
            this.tabPage_Риски.Controls.Add(this.splitContainer_Риски);
            this.tabPage_Риски.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Риски.Name = "tabPage_Риски";
            this.tabPage_Риски.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Риски.Size = new System.Drawing.Size(792, 297);
            this.tabPage_Риски.TabIndex = 1;
            this.tabPage_Риски.Text = "Риски";
            this.tabPage_Риски.UseVisualStyleBackColor = true;
            // 
            // splitContainer_Риски
            // 
            this.splitContainer_Риски.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Риски.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_Риски.Name = "splitContainer_Риски";
            // 
            // splitContainer_Риски.Panel1
            // 
            this.splitContainer_Риски.Panel1.Controls.Add(this.dataGridView_Риски);
            // 
            // splitContainer_Риски.Panel2
            // 
            this.splitContainer_Риски.Panel2.Controls.Add(this.button_Экспорт_Риски);
            this.splitContainer_Риски.Panel2.Controls.Add(this.button_Сохранить_Риски);
            this.splitContainer_Риски.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer_Риски.Size = new System.Drawing.Size(786, 291);
            this.splitContainer_Риски.SplitterDistance = 461;
            this.splitContainer_Риски.TabIndex = 1;
            // 
            // dataGridView_Риски
            // 
            this.dataGridView_Риски.AutoGenerateColumns = false;
            this.dataGridView_Риски.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Риски.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDРискаDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.УровеньРискаВычисл,
            this.dataGridViewTextBoxColumn7,
            this.iDМероприятияDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.iDПользователяDataGridViewTextBoxColumn2});
            this.dataGridView_Риски.DataSource = this.рискиBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Риски.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Риски.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Риски.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Риски.Name = "dataGridView_Риски";
            this.dataGridView_Риски.RowHeadersWidth = 51;
            this.dataGridView_Риски.RowTemplate.Height = 100;
            this.dataGridView_Риски.Size = new System.Drawing.Size(461, 291);
            this.dataGridView_Риски.TabIndex = 0;
            this.dataGridView_Риски.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Риски_CellContentClick);
            // 
            // button_Экспорт_Риски
            // 
            this.button_Экспорт_Риски.AutoSize = true;
            this.button_Экспорт_Риски.Location = new System.Drawing.Point(52, 64);
            this.button_Экспорт_Риски.Name = "button_Экспорт_Риски";
            this.button_Экспорт_Риски.Size = new System.Drawing.Size(175, 26);
            this.button_Экспорт_Риски.TabIndex = 2;
            this.button_Экспорт_Риски.Text = "Экспортировать в файл";
            this.button_Экспорт_Риски.UseVisualStyleBackColor = true;
            this.button_Экспорт_Риски.Click += new System.EventHandler(this.button_Экспорт_Риски_Click);
            // 
            // button_Сохранить_Риски
            // 
            this.button_Сохранить_Риски.Location = new System.Drawing.Point(52, 17);
            this.button_Сохранить_Риски.Name = "button_Сохранить_Риски";
            this.button_Сохранить_Риски.Size = new System.Drawing.Size(90, 30);
            this.button_Сохранить_Риски.TabIndex = 0;
            this.button_Сохранить_Риски.Text = "Сохранить";
            this.button_Сохранить_Риски.UseVisualStyleBackColor = true;
            this.button_Сохранить_Риски.Click += new System.EventHandler(this.button_Сохранить_Риски_Click);
            // 
            // tabPage_ТипыРисков
            // 
            this.tabPage_ТипыРисков.Controls.Add(this.splitContainer_ТипыРисков);
            this.tabPage_ТипыРисков.Location = new System.Drawing.Point(4, 25);
            this.tabPage_ТипыРисков.Name = "tabPage_ТипыРисков";
            this.tabPage_ТипыРисков.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ТипыРисков.Size = new System.Drawing.Size(792, 297);
            this.tabPage_ТипыРисков.TabIndex = 2;
            this.tabPage_ТипыРисков.Text = "Категории рисков";
            this.tabPage_ТипыРисков.UseVisualStyleBackColor = true;
            // 
            // splitContainer_ТипыРисков
            // 
            this.splitContainer_ТипыРисков.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_ТипыРисков.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_ТипыРисков.Name = "splitContainer_ТипыРисков";
            // 
            // splitContainer_ТипыРисков.Panel1
            // 
            this.splitContainer_ТипыРисков.Panel1.Controls.Add(this.dataGridView_ТипыРисков);
            // 
            // splitContainer_ТипыРисков.Panel2
            // 
            this.splitContainer_ТипыРисков.Panel2.Controls.Add(this.button_Сохранить_ТипыРисков);
            this.splitContainer_ТипыРисков.Size = new System.Drawing.Size(786, 291);
            this.splitContainer_ТипыРисков.SplitterDistance = 467;
            this.splitContainer_ТипыРисков.TabIndex = 2;
            // 
            // dataGridView_ТипыРисков
            // 
            this.dataGridView_ТипыРисков.AutoGenerateColumns = false;
            this.dataGridView_ТипыРисков.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ТипыРисков.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDТипаРискаDataGridViewTextBoxColumn1,
            this.наименованиеТипаРискаDataGridViewTextBoxColumn});
            this.dataGridView_ТипыРисков.DataSource = this.типыРисковBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ТипыРисков.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_ТипыРисков.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ТипыРисков.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ТипыРисков.Name = "dataGridView_ТипыРисков";
            this.dataGridView_ТипыРисков.RowHeadersWidth = 51;
            this.dataGridView_ТипыРисков.RowTemplate.Height = 40;
            this.dataGridView_ТипыРисков.Size = new System.Drawing.Size(467, 291);
            this.dataGridView_ТипыРисков.TabIndex = 0;
            // 
            // iDТипаРискаDataGridViewTextBoxColumn1
            // 
            this.iDТипаРискаDataGridViewTextBoxColumn1.DataPropertyName = "ID_ТипаРиска";
            this.iDТипаРискаDataGridViewTextBoxColumn1.HeaderText = "ID_ТипаРиска";
            this.iDТипаРискаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDТипаРискаDataGridViewTextBoxColumn1.Name = "iDТипаРискаDataGridViewTextBoxColumn1";
            this.iDТипаРискаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDТипаРискаDataGridViewTextBoxColumn1.Width = 125;
            // 
            // наименованиеТипаРискаDataGridViewTextBoxColumn
            // 
            this.наименованиеТипаРискаDataGridViewTextBoxColumn.DataPropertyName = "НаименованиеТипаРиска";
            this.наименованиеТипаРискаDataGridViewTextBoxColumn.HeaderText = "Категория риска";
            this.наименованиеТипаРискаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеТипаРискаDataGridViewTextBoxColumn.Name = "наименованиеТипаРискаDataGridViewTextBoxColumn";
            this.наименованиеТипаРискаDataGridViewTextBoxColumn.Width = 125;
            // 
            // button_Сохранить_ТипыРисков
            // 
            this.button_Сохранить_ТипыРисков.Location = new System.Drawing.Point(52, 17);
            this.button_Сохранить_ТипыРисков.Name = "button_Сохранить_ТипыРисков";
            this.button_Сохранить_ТипыРисков.Size = new System.Drawing.Size(90, 30);
            this.button_Сохранить_ТипыРисков.TabIndex = 0;
            this.button_Сохранить_ТипыРисков.Text = "Сохранить";
            this.button_Сохранить_ТипыРисков.UseVisualStyleBackColor = true;
            this.button_Сохранить_ТипыРисков.Click += new System.EventHandler(this.button_Сохранить_ТипыРисков_Click);
            // 
            // tabPage_Процессы
            // 
            this.tabPage_Процессы.Controls.Add(this.splitContainer_Процессы);
            this.tabPage_Процессы.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Процессы.Name = "tabPage_Процессы";
            this.tabPage_Процессы.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Процессы.Size = new System.Drawing.Size(792, 297);
            this.tabPage_Процессы.TabIndex = 3;
            this.tabPage_Процессы.Text = "Процессы";
            this.tabPage_Процессы.UseVisualStyleBackColor = true;
            // 
            // splitContainer_Процессы
            // 
            this.splitContainer_Процессы.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Процессы.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_Процессы.Name = "splitContainer_Процессы";
            // 
            // splitContainer_Процессы.Panel1
            // 
            this.splitContainer_Процессы.Panel1.Controls.Add(this.dataGridView_Процессы);
            // 
            // splitContainer_Процессы.Panel2
            // 
            this.splitContainer_Процессы.Panel2.Controls.Add(this.button_Сохранить_Процессы);
            this.splitContainer_Процессы.Size = new System.Drawing.Size(786, 291);
            this.splitContainer_Процессы.SplitterDistance = 468;
            this.splitContainer_Процессы.TabIndex = 3;
            // 
            // dataGridView_Процессы
            // 
            this.dataGridView_Процессы.AutoGenerateColumns = false;
            this.dataGridView_Процессы.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Процессы.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПроцессаDataGridViewTextBoxColumn1,
            this.наименованиеПроцессаDataGridViewTextBoxColumn});
            this.dataGridView_Процессы.DataSource = this.процессыBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Процессы.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Процессы.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Процессы.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Процессы.Name = "dataGridView_Процессы";
            this.dataGridView_Процессы.RowHeadersWidth = 51;
            this.dataGridView_Процессы.RowTemplate.Height = 40;
            this.dataGridView_Процессы.Size = new System.Drawing.Size(468, 291);
            this.dataGridView_Процессы.TabIndex = 0;
            // 
            // button_Сохранить_Процессы
            // 
            this.button_Сохранить_Процессы.Location = new System.Drawing.Point(52, 17);
            this.button_Сохранить_Процессы.Name = "button_Сохранить_Процессы";
            this.button_Сохранить_Процессы.Size = new System.Drawing.Size(90, 30);
            this.button_Сохранить_Процессы.TabIndex = 0;
            this.button_Сохранить_Процессы.Text = "Сохранить";
            this.button_Сохранить_Процессы.UseVisualStyleBackColor = true;
            this.button_Сохранить_Процессы.Click += new System.EventHandler(this.button_Сохранить_Процессы_Click);
            // 
            // tabPage_Периоды
            // 
            this.tabPage_Периоды.Controls.Add(this.splitContainer_Периоды);
            this.tabPage_Периоды.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Периоды.Name = "tabPage_Периоды";
            this.tabPage_Периоды.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Периоды.Size = new System.Drawing.Size(792, 297);
            this.tabPage_Периоды.TabIndex = 4;
            this.tabPage_Периоды.Text = "Периоды";
            this.tabPage_Периоды.UseVisualStyleBackColor = true;
            // 
            // splitContainer_Периоды
            // 
            this.splitContainer_Периоды.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Периоды.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_Периоды.Name = "splitContainer_Периоды";
            // 
            // splitContainer_Периоды.Panel1
            // 
            this.splitContainer_Периоды.Panel1.Controls.Add(this.dataGridView_Периоды);
            // 
            // splitContainer_Периоды.Panel2
            // 
            this.splitContainer_Периоды.Panel2.Controls.Add(this.button_Сохранить_Периоды);
            this.splitContainer_Периоды.Size = new System.Drawing.Size(786, 291);
            this.splitContainer_Периоды.SplitterDistance = 471;
            this.splitContainer_Периоды.TabIndex = 3;
            // 
            // dataGridView_Периоды
            // 
            this.dataGridView_Периоды.AutoGenerateColumns = false;
            this.dataGridView_Периоды.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Периоды.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПериодаDataGridViewTextBoxColumn1,
            this.наименованиеПериодаDataGridViewTextBoxColumn});
            this.dataGridView_Периоды.DataSource = this.периодыBindingSource;
            this.dataGridView_Периоды.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Периоды.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Периоды.Name = "dataGridView_Периоды";
            this.dataGridView_Периоды.RowHeadersWidth = 51;
            this.dataGridView_Периоды.RowTemplate.Height = 24;
            this.dataGridView_Периоды.Size = new System.Drawing.Size(471, 291);
            this.dataGridView_Периоды.TabIndex = 0;
            // 
            // iDПериодаDataGridViewTextBoxColumn1
            // 
            this.iDПериодаDataGridViewTextBoxColumn1.DataPropertyName = "ID_Периода";
            this.iDПериодаDataGridViewTextBoxColumn1.HeaderText = "ID_Периода";
            this.iDПериодаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDПериодаDataGridViewTextBoxColumn1.Name = "iDПериодаDataGridViewTextBoxColumn1";
            this.iDПериодаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDПериодаDataGridViewTextBoxColumn1.Width = 125;
            // 
            // наименованиеПериодаDataGridViewTextBoxColumn
            // 
            this.наименованиеПериодаDataGridViewTextBoxColumn.DataPropertyName = "НаименованиеПериода";
            this.наименованиеПериодаDataGridViewTextBoxColumn.HeaderText = "Наименование периода";
            this.наименованиеПериодаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеПериодаDataGridViewTextBoxColumn.Name = "наименованиеПериодаDataGridViewTextBoxColumn";
            this.наименованиеПериодаDataGridViewTextBoxColumn.Width = 125;
            // 
            // button_Сохранить_Периоды
            // 
            this.button_Сохранить_Периоды.Location = new System.Drawing.Point(52, 17);
            this.button_Сохранить_Периоды.Name = "button_Сохранить_Периоды";
            this.button_Сохранить_Периоды.Size = new System.Drawing.Size(90, 30);
            this.button_Сохранить_Периоды.TabIndex = 0;
            this.button_Сохранить_Периоды.Text = "Сохранить";
            this.button_Сохранить_Периоды.UseVisualStyleBackColor = true;
            this.button_Сохранить_Периоды.Click += new System.EventHandler(this.button_Сохранить_Периоды_Click);
            // 
            // tabPage_Подразделения
            // 
            this.tabPage_Подразделения.Controls.Add(this.splitContainer_Подразделения);
            this.tabPage_Подразделения.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Подразделения.Name = "tabPage_Подразделения";
            this.tabPage_Подразделения.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Подразделения.Size = new System.Drawing.Size(792, 297);
            this.tabPage_Подразделения.TabIndex = 5;
            this.tabPage_Подразделения.Text = "Подразделения";
            this.tabPage_Подразделения.UseVisualStyleBackColor = true;
            // 
            // splitContainer_Подразделения
            // 
            this.splitContainer_Подразделения.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Подразделения.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_Подразделения.Name = "splitContainer_Подразделения";
            // 
            // splitContainer_Подразделения.Panel1
            // 
            this.splitContainer_Подразделения.Panel1.Controls.Add(this.dataGridView_Подразделения);
            // 
            // splitContainer_Подразделения.Panel2
            // 
            this.splitContainer_Подразделения.Panel2.Controls.Add(this.button_Сохранить_Подразделения);
            this.splitContainer_Подразделения.Size = new System.Drawing.Size(786, 291);
            this.splitContainer_Подразделения.SplitterDistance = 463;
            this.splitContainer_Подразделения.TabIndex = 3;
            // 
            // dataGridView_Подразделения
            // 
            this.dataGridView_Подразделения.AutoGenerateColumns = false;
            this.dataGridView_Подразделения.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Подразделения.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПодразделенияDataGridViewTextBoxColumn1,
            this.наименованиеПодразделенияDataGridViewTextBoxColumn});
            this.dataGridView_Подразделения.DataSource = this.подразделенияBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Подразделения.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Подразделения.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Подразделения.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Подразделения.Name = "dataGridView_Подразделения";
            this.dataGridView_Подразделения.RowHeadersWidth = 51;
            this.dataGridView_Подразделения.RowTemplate.Height = 40;
            this.dataGridView_Подразделения.Size = new System.Drawing.Size(463, 291);
            this.dataGridView_Подразделения.TabIndex = 0;
            // 
            // button_Сохранить_Подразделения
            // 
            this.button_Сохранить_Подразделения.Location = new System.Drawing.Point(52, 17);
            this.button_Сохранить_Подразделения.Name = "button_Сохранить_Подразделения";
            this.button_Сохранить_Подразделения.Size = new System.Drawing.Size(90, 30);
            this.button_Сохранить_Подразделения.TabIndex = 0;
            this.button_Сохранить_Подразделения.Text = "Сохранить";
            this.button_Сохранить_Подразделения.UseVisualStyleBackColor = true;
            this.button_Сохранить_Подразделения.Click += new System.EventHandler(this.button_Сохранить_Подразделения_Click);
            // 
            // tabPage_Пользователи
            // 
            this.tabPage_Пользователи.Controls.Add(this.splitContainer_Пользователи);
            this.tabPage_Пользователи.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Пользователи.Name = "tabPage_Пользователи";
            this.tabPage_Пользователи.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Пользователи.Size = new System.Drawing.Size(792, 297);
            this.tabPage_Пользователи.TabIndex = 6;
            this.tabPage_Пользователи.Text = "Пользователи";
            this.tabPage_Пользователи.UseVisualStyleBackColor = true;
            // 
            // splitContainer_Пользователи
            // 
            this.splitContainer_Пользователи.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Пользователи.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_Пользователи.Name = "splitContainer_Пользователи";
            // 
            // splitContainer_Пользователи.Panel1
            // 
            this.splitContainer_Пользователи.Panel1.Controls.Add(this.dataGridView_Пользователи);
            // 
            // splitContainer_Пользователи.Panel2
            // 
            this.splitContainer_Пользователи.Panel2.Controls.Add(this.button_Сохранить_Пользователи);
            this.splitContainer_Пользователи.Size = new System.Drawing.Size(786, 291);
            this.splitContainer_Пользователи.SplitterDistance = 465;
            this.splitContainer_Пользователи.TabIndex = 3;
            // 
            // dataGridView_Пользователи
            // 
            this.dataGridView_Пользователи.AutoGenerateColumns = false;
            this.dataGridView_Пользователи.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Пользователи.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПользователяDataGridViewTextBoxColumn1,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn,
            this.iDПодразделенияDataGridViewTextBoxColumn2,
            this.isАдминистраторDataGridViewCheckBoxColumn,
            this.должностьDataGridViewTextBoxColumn});
            this.dataGridView_Пользователи.DataSource = this.пользователиBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Пользователи.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_Пользователи.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Пользователи.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Пользователи.Name = "dataGridView_Пользователи";
            this.dataGridView_Пользователи.RowHeadersWidth = 51;
            this.dataGridView_Пользователи.RowTemplate.Height = 48;
            this.dataGridView_Пользователи.Size = new System.Drawing.Size(465, 291);
            this.dataGridView_Пользователи.TabIndex = 0;
            // 
            // button_Сохранить_Пользователи
            // 
            this.button_Сохранить_Пользователи.Location = new System.Drawing.Point(52, 17);
            this.button_Сохранить_Пользователи.Name = "button_Сохранить_Пользователи";
            this.button_Сохранить_Пользователи.Size = new System.Drawing.Size(90, 30);
            this.button_Сохранить_Пользователи.TabIndex = 0;
            this.button_Сохранить_Пользователи.Text = "Сохранить";
            this.button_Сохранить_Пользователи.UseVisualStyleBackColor = true;
            this.button_Сохранить_Пользователи.Click += new System.EventHandler(this.button_Сохранить_Пользователи_Click);
            // 
            // tabPage_Мероприятия
            // 
            this.tabPage_Мероприятия.Controls.Add(this.splitContainer_Мероприятия);
            this.tabPage_Мероприятия.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Мероприятия.Name = "tabPage_Мероприятия";
            this.tabPage_Мероприятия.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Мероприятия.Size = new System.Drawing.Size(792, 297);
            this.tabPage_Мероприятия.TabIndex = 7;
            this.tabPage_Мероприятия.Text = "Мероприятия";
            this.tabPage_Мероприятия.UseVisualStyleBackColor = true;
            this.tabPage_Мероприятия.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // splitContainer_Мероприятия
            // 
            this.splitContainer_Мероприятия.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Мероприятия.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_Мероприятия.Name = "splitContainer_Мероприятия";
            // 
            // splitContainer_Мероприятия.Panel1
            // 
            this.splitContainer_Мероприятия.Panel1.Controls.Add(this.dataGridView_Мероприятия);
            // 
            // splitContainer_Мероприятия.Panel2
            // 
            this.splitContainer_Мероприятия.Panel2.Controls.Add(this.button_Сохранить_Мероприятия);
            this.splitContainer_Мероприятия.Size = new System.Drawing.Size(786, 291);
            this.splitContainer_Мероприятия.SplitterDistance = 464;
            this.splitContainer_Мероприятия.TabIndex = 4;
            // 
            // dataGridView_Мероприятия
            // 
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Мероприятия.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_Мероприятия.AutoGenerateColumns = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_Мероприятия.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_Мероприятия.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Мероприятия.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDМеропритияDataGridViewTextBoxColumn,
            this.наименованиеМероприятияDataGridViewTextBoxColumn});
            this.dataGridView_Мероприятия.DataSource = this.мероприятияBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Мероприятия.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_Мероприятия.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Мероприятия.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Мероприятия.Name = "dataGridView_Мероприятия";
            this.dataGridView_Мероприятия.RowHeadersWidth = 51;
            this.dataGridView_Мероприятия.RowTemplate.Height = 72;
            this.dataGridView_Мероприятия.Size = new System.Drawing.Size(464, 291);
            this.dataGridView_Мероприятия.TabIndex = 0;
            // 
            // button_Сохранить_Мероприятия
            // 
            this.button_Сохранить_Мероприятия.Location = new System.Drawing.Point(52, 17);
            this.button_Сохранить_Мероприятия.Name = "button_Сохранить_Мероприятия";
            this.button_Сохранить_Мероприятия.Size = new System.Drawing.Size(90, 30);
            this.button_Сохранить_Мероприятия.TabIndex = 0;
            this.button_Сохранить_Мероприятия.Text = "Сохранить";
            this.button_Сохранить_Мероприятия.UseVisualStyleBackColor = true;
            this.button_Сохранить_Мероприятия.Click += new System.EventHandler(this.button_Сохранить_Мероприятия_Click);
            // 
            // button_Проверка
            // 
            this.button_Проверка.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Проверка.Location = new System.Drawing.Point(43, 60);
            this.button_Проверка.Name = "button_Проверка";
            this.button_Проверка.Size = new System.Drawing.Size(90, 30);
            this.button_Проверка.TabIndex = 1;
            this.button_Проверка.Text = "Проверка";
            this.button_Проверка.UseVisualStyleBackColor = true;
            this.button_Проверка.Click += new System.EventHandler(this.button_Проверка_Click);
            // 
            // button_Выход
            // 
            this.button_Выход.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Выход.Location = new System.Drawing.Point(678, 60);
            this.button_Выход.Name = "button_Выход";
            this.button_Выход.Size = new System.Drawing.Size(80, 30);
            this.button_Выход.TabIndex = 0;
            this.button_Выход.Text = "Выход";
            this.button_Выход.UseVisualStyleBackColor = true;
            this.button_Выход.Click += new System.EventHandler(this.button_Выход_Click);
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рискиДействияTableAdapter
            // 
            this.рискиДействияTableAdapter.ClearBeforeFill = true;
            // 
            // типыРисковTableAdapter
            // 
            this.типыРисковTableAdapter.ClearBeforeFill = true;
            // 
            // процессыTableAdapter
            // 
            this.процессыTableAdapter.ClearBeforeFill = true;
            // 
            // периодыTableAdapter
            // 
            this.периодыTableAdapter.ClearBeforeFill = true;
            // 
            // подразделенияTableAdapter
            // 
            this.подразделенияTableAdapter.ClearBeforeFill = true;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // мероприятияTableAdapter
            // 
            this.мероприятияTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet13
            // 
            this.dataSet13.DataSetName = "DataSet1";
            this.dataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рискиTableAdapter1
            // 
            this.рискиTableAdapter1.ClearBeforeFill = true;
            // 
            // iDПроцессаDataGridViewTextBoxColumn1
            // 
            this.iDПроцессаDataGridViewTextBoxColumn1.DataPropertyName = "ID_Процесса";
            this.iDПроцессаDataGridViewTextBoxColumn1.HeaderText = "ID_Процесса";
            this.iDПроцессаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDПроцессаDataGridViewTextBoxColumn1.Name = "iDПроцессаDataGridViewTextBoxColumn1";
            this.iDПроцессаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDПроцессаDataGridViewTextBoxColumn1.Width = 125;
            // 
            // наименованиеПроцессаDataGridViewTextBoxColumn
            // 
            this.наименованиеПроцессаDataGridViewTextBoxColumn.DataPropertyName = "НаименованиеПроцесса";
            this.наименованиеПроцессаDataGridViewTextBoxColumn.HeaderText = "Наименование процесса";
            this.наименованиеПроцессаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеПроцессаDataGridViewTextBoxColumn.Name = "наименованиеПроцессаDataGridViewTextBoxColumn";
            this.наименованиеПроцессаDataGridViewTextBoxColumn.Width = 200;
            // 
            // iDПодразделенияDataGridViewTextBoxColumn1
            // 
            this.iDПодразделенияDataGridViewTextBoxColumn1.DataPropertyName = "ID_Подразделения";
            this.iDПодразделенияDataGridViewTextBoxColumn1.HeaderText = "ID_Подразделения";
            this.iDПодразделенияDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDПодразделенияDataGridViewTextBoxColumn1.Name = "iDПодразделенияDataGridViewTextBoxColumn1";
            this.iDПодразделенияDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDПодразделенияDataGridViewTextBoxColumn1.Width = 125;
            // 
            // наименованиеПодразделенияDataGridViewTextBoxColumn
            // 
            this.наименованиеПодразделенияDataGridViewTextBoxColumn.DataPropertyName = "НаименованиеПодразделения";
            this.наименованиеПодразделенияDataGridViewTextBoxColumn.HeaderText = "Наименование подразделения";
            this.наименованиеПодразделенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеПодразделенияDataGridViewTextBoxColumn.Name = "наименованиеПодразделенияDataGridViewTextBoxColumn";
            this.наименованиеПодразделенияDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDПользователяDataGridViewTextBoxColumn1
            // 
            this.iDПользователяDataGridViewTextBoxColumn1.DataPropertyName = "ID_Пользователя";
            this.iDПользователяDataGridViewTextBoxColumn1.HeaderText = "ID_Пользователя";
            this.iDПользователяDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDПользователяDataGridViewTextBoxColumn1.Name = "iDПользователяDataGridViewTextBoxColumn1";
            this.iDПользователяDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDПользователяDataGridViewTextBoxColumn1.Width = 125;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            this.парольDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDПодразделенияDataGridViewTextBoxColumn2
            // 
            this.iDПодразделенияDataGridViewTextBoxColumn2.DataPropertyName = "ID_Подразделения";
            this.iDПодразделенияDataGridViewTextBoxColumn2.DataSource = this.подразделенияBindingSource;
            this.iDПодразделенияDataGridViewTextBoxColumn2.DisplayMember = "НаименованиеПодразделения";
            this.iDПодразделенияDataGridViewTextBoxColumn2.HeaderText = "Подразделение";
            this.iDПодразделенияDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.iDПодразделенияDataGridViewTextBoxColumn2.Name = "iDПодразделенияDataGridViewTextBoxColumn2";
            this.iDПодразделенияDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDПодразделенияDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDПодразделенияDataGridViewTextBoxColumn2.ValueMember = "ID_Подразделения";
            this.iDПодразделенияDataGridViewTextBoxColumn2.Width = 150;
            // 
            // isАдминистраторDataGridViewCheckBoxColumn
            // 
            this.isАдминистраторDataGridViewCheckBoxColumn.DataPropertyName = "IsАдминистратор";
            this.isАдминистраторDataGridViewCheckBoxColumn.HeaderText = "IsАдминистратор";
            this.isАдминистраторDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isАдминистраторDataGridViewCheckBoxColumn.Name = "isАдминистраторDataGridViewCheckBoxColumn";
            this.isАдминистраторDataGridViewCheckBoxColumn.Width = 125;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDМеропритияDataGridViewTextBoxColumn
            // 
            this.iDМеропритияDataGridViewTextBoxColumn.DataPropertyName = "ID_Меропрития";
            this.iDМеропритияDataGridViewTextBoxColumn.HeaderText = "ID_Меропрития";
            this.iDМеропритияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDМеропритияDataGridViewTextBoxColumn.Name = "iDМеропритияDataGridViewTextBoxColumn";
            this.iDМеропритияDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDМеропритияDataGridViewTextBoxColumn.Width = 125;
            // 
            // наименованиеМероприятияDataGridViewTextBoxColumn
            // 
            this.наименованиеМероприятияDataGridViewTextBoxColumn.DataPropertyName = "НаименованиеМероприятия";
            this.наименованиеМероприятияDataGridViewTextBoxColumn.HeaderText = "Мероприятие по снижению риска";
            this.наименованиеМероприятияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеМероприятияDataGridViewTextBoxColumn.Name = "наименованиеМероприятияDataGridViewTextBoxColumn";
            this.наименованиеМероприятияDataGridViewTextBoxColumn.Width = 300;
            // 
            // iDПодразделенияDataGridViewTextBoxColumn
            // 
            this.iDПодразделенияDataGridViewTextBoxColumn.DataPropertyName = "ID_Подразделения";
            this.iDПодразделенияDataGridViewTextBoxColumn.DataSource = this.подразделенияBindingSource;
            this.iDПодразделенияDataGridViewTextBoxColumn.DisplayMember = "НаименованиеПодразделения";
            this.iDПодразделенияDataGridViewTextBoxColumn.DropDownWidth = 200;
            this.iDПодразделенияDataGridViewTextBoxColumn.HeaderText = "Подразделение";
            this.iDПодразделенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDПодразделенияDataGridViewTextBoxColumn.Name = "iDПодразделенияDataGridViewTextBoxColumn";
            this.iDПодразделенияDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDПодразделенияDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDПодразделенияDataGridViewTextBoxColumn.ValueMember = "ID_Подразделения";
            this.iDПодразделенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // idМероприятияDataGridViewTextBoxColumn
            // 
            this.idМероприятияDataGridViewTextBoxColumn.DataPropertyName = "ID_Мероприятия";
            this.idМероприятияDataGridViewTextBoxColumn.DataSource = this.мероприятияBindingSource;
            this.idМероприятияDataGridViewTextBoxColumn.DisplayMember = "НаименованиеМероприятия";
            this.idМероприятияDataGridViewTextBoxColumn.DropDownWidth = 600;
            this.idМероприятияDataGridViewTextBoxColumn.HeaderText = "Мероприятия по снижению риска";
            this.idМероприятияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idМероприятияDataGridViewTextBoxColumn.Name = "idМероприятияDataGridViewTextBoxColumn";
            this.idМероприятияDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idМероприятияDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idМероприятияDataGridViewTextBoxColumn.ValueMember = "ID_Меропрития";
            this.idМероприятияDataGridViewTextBoxColumn.Width = 200;
            // 
            // iDПроцессаDataGridViewTextBoxColumn
            // 
            this.iDПроцессаDataGridViewTextBoxColumn.DataPropertyName = "ID_Процесса";
            this.iDПроцессаDataGridViewTextBoxColumn.DataSource = this.процессыBindingSource;
            this.iDПроцессаDataGridViewTextBoxColumn.DisplayMember = "НаименованиеПроцесса";
            this.iDПроцессаDataGridViewTextBoxColumn.DropDownWidth = 300;
            this.iDПроцессаDataGridViewTextBoxColumn.HeaderText = "Процесс";
            this.iDПроцессаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDПроцессаDataGridViewTextBoxColumn.Name = "iDПроцессаDataGridViewTextBoxColumn";
            this.iDПроцессаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDПроцессаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDПроцессаDataGridViewTextBoxColumn.ValueMember = "ID_Процесса";
            this.iDПроцессаDataGridViewTextBoxColumn.Width = 125;
            // 
            // IDТипаРиска
            // 
            this.IDТипаРиска.DataPropertyName = "ID_ТипаРиска";
            this.IDТипаРиска.DataSource = this.типыРисковBindingSource;
            this.IDТипаРиска.DisplayMember = "НаименованиеТипаРиска";
            this.IDТипаРиска.DropDownWidth = 150;
            this.IDТипаРиска.HeaderText = "Категория Риска";
            this.IDТипаРиска.MinimumWidth = 6;
            this.IDТипаРиска.Name = "IDТипаРиска";
            this.IDТипаРиска.ValueMember = "ID_ТипаРиска";
            this.IDТипаРиска.Width = 125;
            // 
            // iDРискаDataGridViewTextBoxColumn
            // 
            this.iDРискаDataGridViewTextBoxColumn.DataPropertyName = "ID_Риска";
            this.iDРискаDataGridViewTextBoxColumn.DataSource = this.рискиBindingSource;
            this.iDРискаDataGridViewTextBoxColumn.DisplayMember = "НаименованиеРиска";
            this.iDРискаDataGridViewTextBoxColumn.DropDownWidth = 400;
            this.iDРискаDataGridViewTextBoxColumn.HeaderText = "Описание риск";
            this.iDРискаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDРискаDataGridViewTextBoxColumn.Name = "iDРискаDataGridViewTextBoxColumn";
            this.iDРискаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDРискаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDРискаDataGridViewTextBoxColumn.ValueMember = "ID_Риска";
            this.iDРискаDataGridViewTextBoxColumn.Width = 200;
            // 
            // iDПериодаDataGridViewTextBoxColumn
            // 
            this.iDПериодаDataGridViewTextBoxColumn.DataPropertyName = "ID_Периода";
            this.iDПериодаDataGridViewTextBoxColumn.DataSource = this.периодыBindingSource;
            this.iDПериодаDataGridViewTextBoxColumn.DisplayMember = "НаименованиеПериода";
            this.iDПериодаDataGridViewTextBoxColumn.DropDownWidth = 100;
            this.iDПериодаDataGridViewTextBoxColumn.HeaderText = "Период";
            this.iDПериодаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDПериодаDataGridViewTextBoxColumn.Name = "iDПериодаDataGridViewTextBoxColumn";
            this.iDПериодаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDПериодаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDПериодаDataGridViewTextBoxColumn.ValueMember = "ID_Периода";
            this.iDПериодаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаОкончанияDataGridViewTextBoxColumn
            // 
            this.датаОкончанияDataGridViewTextBoxColumn.DataPropertyName = "ДатаОкончания";
            this.датаОкончанияDataGridViewTextBoxColumn.HeaderText = "Дата реализации мероприятия";
            this.датаОкончанияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаОкончанияDataGridViewTextBoxColumn.Name = "датаОкончанияDataGridViewTextBoxColumn";
            // 
            // вероятностьРискаДоМПDataGridViewTextBoxColumn
            // 
            this.вероятностьРискаДоМПDataGridViewTextBoxColumn.DataPropertyName = "ВероятностьРискаДоМП";
            this.вероятностьРискаДоМПDataGridViewTextBoxColumn.HeaderText = "Вероятность риска до мероприятия";
            this.вероятностьРискаДоМПDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.вероятностьРискаДоМПDataGridViewTextBoxColumn.Name = "вероятностьРискаДоМПDataGridViewTextBoxColumn";
            // 
            // последствияРискаДоМПDataGridViewTextBoxColumn
            // 
            this.последствияРискаДоМПDataGridViewTextBoxColumn.DataPropertyName = "ПоследствияРискаДоМП";
            this.последствияРискаДоМПDataGridViewTextBoxColumn.HeaderText = "Последствия риска до мероприятия";
            this.последствияРискаДоМПDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.последствияРискаДоМПDataGridViewTextBoxColumn.Name = "последствияРискаДоМПDataGridViewTextBoxColumn";
            // 
            // уровеньРискаДоМПDataGridViewTextBoxColumn
            // 
            this.уровеньРискаДоМПDataGridViewTextBoxColumn.DataPropertyName = "УровеньРискаДоМП";
            this.уровеньРискаДоМПDataGridViewTextBoxColumn.HeaderText = "Уровень риска до мероприятия";
            this.уровеньРискаДоМПDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.уровеньРискаДоМПDataGridViewTextBoxColumn.Name = "уровеньРискаДоМПDataGridViewTextBoxColumn";
            this.уровеньРискаДоМПDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // УровеньРискаДоМПВычисл
            // 
            this.УровеньРискаДоМПВычисл.HeaderText = "Уровень риска до мероприятия";
            this.УровеньРискаДоМПВычисл.MinimumWidth = 6;
            this.УровеньРискаДоМПВычисл.Name = "УровеньРискаДоМПВычисл";
            // 
            // вероятностьРискаПослеМПDataGridViewTextBoxColumn
            // 
            this.вероятностьРискаПослеМПDataGridViewTextBoxColumn.DataPropertyName = "ВероятностьРискаПослеМП";
            this.вероятностьРискаПослеМПDataGridViewTextBoxColumn.HeaderText = "Вероятность риска после мероприятия";
            this.вероятностьРискаПослеМПDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.вероятностьРискаПослеМПDataGridViewTextBoxColumn.Name = "вероятностьРискаПослеМПDataGridViewTextBoxColumn";
            // 
            // последствияРискаПослеМПDataGridViewTextBoxColumn
            // 
            this.последствияРискаПослеМПDataGridViewTextBoxColumn.DataPropertyName = "ПоследствияРискаПослеМП";
            this.последствияРискаПослеМПDataGridViewTextBoxColumn.HeaderText = "Последствия риска после мероприятия";
            this.последствияРискаПослеМПDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.последствияРискаПослеМПDataGridViewTextBoxColumn.Name = "последствияРискаПослеМПDataGridViewTextBoxColumn";
            // 
            // уровеньРискаПослеМПDataGridViewTextBoxColumn
            // 
            this.уровеньРискаПослеМПDataGridViewTextBoxColumn.DataPropertyName = "УровеньРискаПослеМП";
            this.уровеньРискаПослеМПDataGridViewTextBoxColumn.HeaderText = "Уровень риска после мероприятия";
            this.уровеньРискаПослеМПDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.уровеньРискаПослеМПDataGridViewTextBoxColumn.Name = "уровеньРискаПослеМПDataGridViewTextBoxColumn";
            this.уровеньРискаПослеМПDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // уровеньРискаПослеМПВычисл
            // 
            this.уровеньРискаПослеМПВычисл.HeaderText = "Уровень риска после мероприятия";
            this.уровеньРискаПослеМПВычисл.MinimumWidth = 6;
            this.уровеньРискаПослеМПВычисл.Name = "уровеньРискаПослеМПВычисл";
            // 
            // ЭффективностьМероприятия
            // 
            this.ЭффективностьМероприятия.DataPropertyName = "ЭффективностьМероприятия";
            this.ЭффективностьМероприятия.HeaderText = "Эффективность мероприятия";
            this.ЭффективностьМероприятия.MinimumWidth = 6;
            this.ЭффективностьМероприятия.Name = "ЭффективностьМероприятия";
            this.ЭффективностьМероприятия.ReadOnly = true;
            // 
            // iDПользователяDataGridViewTextBoxColumn
            // 
            this.iDПользователяDataGridViewTextBoxColumn.DataPropertyName = "ID_Пользователя";
            this.iDПользователяDataGridViewTextBoxColumn.DataSource = this.пользователиBindingSource;
            this.iDПользователяDataGridViewTextBoxColumn.DisplayMember = "Фамилия";
            this.iDПользователяDataGridViewTextBoxColumn.DropDownWidth = 100;
            this.iDПользователяDataGridViewTextBoxColumn.HeaderText = "Ответственный";
            this.iDПользователяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDПользователяDataGridViewTextBoxColumn.Name = "iDПользователяDataGridViewTextBoxColumn";
            this.iDПользователяDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDПользователяDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDПользователяDataGridViewTextBoxColumn.ValueMember = "ID_Пользователя";
            this.iDПользователяDataGridViewTextBoxColumn.Width = 110;
            // 
            // iDРискаDataGridViewTextBoxColumn2
            // 
            this.iDРискаDataGridViewTextBoxColumn2.DataPropertyName = "ID_Риска";
            this.iDРискаDataGridViewTextBoxColumn2.HeaderText = "ID_Риска";
            this.iDРискаDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.iDРискаDataGridViewTextBoxColumn2.Name = "iDРискаDataGridViewTextBoxColumn2";
            this.iDРискаDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDРискаDataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_ТипаРиска";
            this.dataGridViewTextBoxColumn2.DataSource = this.типыРисковBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "НаименованиеТипаРиска";
            this.dataGridViewTextBoxColumn2.DropDownWidth = 150;
            this.dataGridViewTextBoxColumn2.HeaderText = "Категория риска";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID_ТипаРиска";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "НаименованиеРиска";
            this.dataGridViewTextBoxColumn1.HeaderText = "Описание риска";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "РезультатРиска";
            this.dataGridViewTextBoxColumn4.HeaderText = "Возможные последствия реализации риска";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ВероятностьРиска";
            this.dataGridViewTextBoxColumn5.HeaderText = "Вероятность риска";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ПоследствияРиска";
            this.dataGridViewTextBoxColumn6.HeaderText = "Последствия риска";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // УровеньРискаВычисл
            // 
            this.УровеньРискаВычисл.HeaderText = "Уровень риска";
            this.УровеньРискаВычисл.MinimumWidth = 6;
            this.УровеньРискаВычисл.Name = "УровеньРискаВычисл";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "УровеньРиска";
            this.dataGridViewTextBoxColumn7.HeaderText = "Уровень риска";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // iDМероприятияDataGridViewTextBoxColumn1
            // 
            this.iDМероприятияDataGridViewTextBoxColumn1.DataPropertyName = "ID_Мероприятия";
            this.iDМероприятияDataGridViewTextBoxColumn1.DataSource = this.мероприятияBindingSource;
            this.iDМероприятияDataGridViewTextBoxColumn1.DisplayMember = "НаименованиеМероприятия";
            this.iDМероприятияDataGridViewTextBoxColumn1.DropDownWidth = 600;
            this.iDМероприятияDataGridViewTextBoxColumn1.HeaderText = "Мероприятия по снижению риска";
            this.iDМероприятияDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDМероприятияDataGridViewTextBoxColumn1.Name = "iDМероприятияDataGridViewTextBoxColumn1";
            this.iDМероприятияDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDМероприятияDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDМероприятияDataGridViewTextBoxColumn1.ValueMember = "ID_Меропрития";
            this.iDМероприятияDataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ПричинаРиска";
            this.dataGridViewTextBoxColumn3.HeaderText = "Возможности для снижения риска";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // iDПользователяDataGridViewTextBoxColumn2
            // 
            this.iDПользователяDataGridViewTextBoxColumn2.DataPropertyName = "ID_Пользователя";
            this.iDПользователяDataGridViewTextBoxColumn2.DataSource = this.пользователиBindingSource;
            this.iDПользователяDataGridViewTextBoxColumn2.DisplayMember = "Фамилия";
            this.iDПользователяDataGridViewTextBoxColumn2.HeaderText = "Владельцы риска";
            this.iDПользователяDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.iDПользователяDataGridViewTextBoxColumn2.Name = "iDПользователяDataGridViewTextBoxColumn2";
            this.iDПользователяDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDПользователяDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDПользователяDataGridViewTextBoxColumn2.ValueMember = "ID_Пользователя";
            this.iDПользователяDataGridViewTextBoxColumn2.Width = 110;
            // 
            // Form_Главная
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer_Главная);
            this.Name = "Form_Главная";
            this.Text = "Управление рисками";
            this.Load += new System.EventHandler(this.Form_Главная_Load);
            this.splitContainer_Главная.Panel1.ResumeLayout(false);
            this.splitContainer_Главная.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Главная)).EndInit();
            this.splitContainer_Главная.ResumeLayout(false);
            this.tabControl_Главный.ResumeLayout(false);
            this.tabPage_РискиДействия.ResumeLayout(false);
            this.splitContainer_РискиДействия.Panel1.ResumeLayout(false);
            this.splitContainer_РискиДействия.Panel2.ResumeLayout(false);
            this.splitContainer_РискиДействия.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_РискиДействия)).EndInit();
            this.splitContainer_РискиДействия.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_РискиДействия)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подразделенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мероприятияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процессыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типыРисковBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рискиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.периодыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рискиДействияBindingSource)).EndInit();
            this.tabPage_Риски.ResumeLayout(false);
            this.splitContainer_Риски.Panel1.ResumeLayout(false);
            this.splitContainer_Риски.Panel2.ResumeLayout(false);
            this.splitContainer_Риски.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Риски)).EndInit();
            this.splitContainer_Риски.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Риски)).EndInit();
            this.tabPage_ТипыРисков.ResumeLayout(false);
            this.splitContainer_ТипыРисков.Panel1.ResumeLayout(false);
            this.splitContainer_ТипыРисков.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_ТипыРисков)).EndInit();
            this.splitContainer_ТипыРисков.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ТипыРисков)).EndInit();
            this.tabPage_Процессы.ResumeLayout(false);
            this.splitContainer_Процессы.Panel1.ResumeLayout(false);
            this.splitContainer_Процессы.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Процессы)).EndInit();
            this.splitContainer_Процессы.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Процессы)).EndInit();
            this.tabPage_Периоды.ResumeLayout(false);
            this.splitContainer_Периоды.Panel1.ResumeLayout(false);
            this.splitContainer_Периоды.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Периоды)).EndInit();
            this.splitContainer_Периоды.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Периоды)).EndInit();
            this.tabPage_Подразделения.ResumeLayout(false);
            this.splitContainer_Подразделения.Panel1.ResumeLayout(false);
            this.splitContainer_Подразделения.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Подразделения)).EndInit();
            this.splitContainer_Подразделения.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Подразделения)).EndInit();
            this.tabPage_Пользователи.ResumeLayout(false);
            this.splitContainer_Пользователи.Panel1.ResumeLayout(false);
            this.splitContainer_Пользователи.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Пользователи)).EndInit();
            this.splitContainer_Пользователи.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Пользователи)).EndInit();
            this.tabPage_Мероприятия.ResumeLayout(false);
            this.splitContainer_Мероприятия.Panel1.ResumeLayout(false);
            this.splitContainer_Мероприятия.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Мероприятия)).EndInit();
            this.splitContainer_Мероприятия.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Мероприятия)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_Главная;
        private System.Windows.Forms.Button button_Выход;
        private System.Windows.Forms.TabControl tabControl_Главный;
        private System.Windows.Forms.TabPage tabPage_РискиДействия;
        private System.Windows.Forms.TabPage tabPage_Риски;
        private System.Windows.Forms.TabPage tabPage_ТипыРисков;
        private System.Windows.Forms.TabPage tabPage_Процессы;
        private System.Windows.Forms.TabPage tabPage_Периоды;
        private System.Windows.Forms.TabPage tabPage_Подразделения;
        private System.Windows.Forms.TabPage tabPage_Пользователи;
        private System.Windows.Forms.SplitContainer splitContainer_РискиДействия;
        private System.Windows.Forms.DataGridView dataGridView_РискиДействия;
        private System.Windows.Forms.Button button_Сохранить_РискиДействия;
        private System.Windows.Forms.SplitContainer splitContainer_Риски;
        private System.Windows.Forms.DataGridView dataGridView_Риски;
        private System.Windows.Forms.Button button_Сохранить_Риски;
        private System.Windows.Forms.SplitContainer splitContainer_ТипыРисков;
        private System.Windows.Forms.DataGridView dataGridView_ТипыРисков;
        private System.Windows.Forms.Button button_Сохранить_ТипыРисков;
        private System.Windows.Forms.SplitContainer splitContainer_Процессы;
        private System.Windows.Forms.DataGridView dataGridView_Процессы;
        private System.Windows.Forms.Button button_Сохранить_Процессы;
        private System.Windows.Forms.SplitContainer splitContainer_Периоды;
        private System.Windows.Forms.DataGridView dataGridView_Периоды;
        private System.Windows.Forms.Button button_Сохранить_Периоды;
        private System.Windows.Forms.SplitContainer splitContainer_Подразделения;
        private System.Windows.Forms.DataGridView dataGridView_Подразделения;
        private System.Windows.Forms.Button button_Сохранить_Подразделения;
        private System.Windows.Forms.SplitContainer splitContainer_Пользователи;
        private System.Windows.Forms.DataGridView dataGridView_Пользователи;
        private System.Windows.Forms.Button button_Сохранить_Пользователи;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.РискиДействияTableAdapter рискиДействияTableAdapter;
        private System.Windows.Forms.BindingSource типыРисковBindingSource;
        private DataSet1TableAdapters.ТипыРисковTableAdapter типыРисковTableAdapter;
        private System.Windows.Forms.BindingSource процессыBindingSource;
        private DataSet1TableAdapters.ПроцессыTableAdapter процессыTableAdapter;
        private System.Windows.Forms.BindingSource периодыBindingSource;
        private DataSet1TableAdapters.ПериодыTableAdapter периодыTableAdapter;
        private System.Windows.Forms.BindingSource подразделенияBindingSource;
        private DataSet1TableAdapters.ПодразделенияTableAdapter подразделенияTableAdapter;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private DataSet1TableAdapters.ПользователиTableAdapter пользователиTableAdapter;
        private System.Windows.Forms.Button button_Проверка;
        private System.Windows.Forms.TabPage tabPage_Мероприятия;
        private System.Windows.Forms.SplitContainer splitContainer_Мероприятия;
        private System.Windows.Forms.DataGridView dataGridView_Мероприятия;
        private System.Windows.Forms.Button button_Сохранить_Мероприятия;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource мероприятияBindingSource;
        private DataSet1TableAdapters.МероприятияTableAdapter мероприятияTableAdapter;
        private DataSet1 dataSet12;
        private DataSet1 dataSet13;
        private DataSet1TableAdapters.РискиTableAdapter рискиTableAdapter;
        private System.Windows.Forms.BindingSource рискиДействияBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТипаРискаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеТипаРискаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПериодаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеПериодаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_Экспорт_РискиДействия;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDРискаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDТипаРискаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеРискаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn результатРискаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вероятностьРискаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn последствияРискаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn уровеньРискаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn причинаРискаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_Экспорт_Риски;
        private System.Windows.Forms.BindingSource рискиBindingSource;
        private DataSet1TableAdapters.РискиTableAdapter рискиTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПроцессаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеПроцессаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПодразделенияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеПодразделенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПользователяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDПодразделенияDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isАдминистраторDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМеропритияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеМероприятияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDПодразделенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idМероприятияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDПроцессаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn IDТипаРиска;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDРискаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDПериодаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОкончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вероятностьРискаДоМПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn последствияРискаДоМПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn уровеньРискаДоМПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn УровеньРискаДоМПВычисл;
        private System.Windows.Forms.DataGridViewTextBoxColumn вероятностьРискаПослеМПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn последствияРискаПослеМПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn уровеньРискаПослеМПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn уровеньРискаПослеМПВычисл;
        private System.Windows.Forms.DataGridViewTextBoxColumn ЭффективностьМероприятия;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDПользователяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDРискаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn УровеньРискаВычисл;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDМероприятияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDПользователяDataGridViewTextBoxColumn2;
    }
}

