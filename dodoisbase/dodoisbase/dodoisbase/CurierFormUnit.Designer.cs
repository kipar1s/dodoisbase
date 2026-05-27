namespace dodoisbase
{
    partial class CurierFormUnit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurierFormUnit));
            this.btn_OK = new System.Windows.Forms.Button();
            this.tb_FIO = new System.Windows.Forms.TextBox();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cuncel = new System.Windows.Forms.Button();
            this.lb_Warning = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_Curier = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDКурьераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерВУDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.машинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номермашиныDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bN_Oder = new System.Windows.Forms.BindingNavigator(this.components);
            this.curierbindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.personalbindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bN_User = new System.Windows.Forms.BindingNavigator(this.components);
            this.dodoDS = new dodoisbase.dodoDS();
            this.curierTableAdapter = new dodoisbase.dodoDSTableAdapters.КурьерTableAdapter();
            this.personalTableAdapter = new dodoisbase.dodoDSTableAdapters.СотрудникиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            this.gb_Curier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bN_Oder)).BeginInit();
            this.bN_Oder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bN_User)).BeginInit();
            this.bN_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dodoDS)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(628, 98);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(173, 48);
            this.btn_OK.TabIndex = 47;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_FIO
            // 
            this.tb_FIO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "ID_Сотрудника", true));
            this.tb_FIO.Enabled = false;
            this.tb_FIO.Location = new System.Drawing.Point(126, 41);
            this.tb_FIO.Name = "tb_FIO";
            this.tb_FIO.ReadOnly = true;
            this.tb_FIO.Size = new System.Drawing.Size(75, 22);
            this.tb_FIO.TabIndex = 43;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataSource = typeof(dodoisbase.Nhibernate.Entites.Personal);
            this.personalBindingSource.CurrentChanged += new System.EventHandler(this.personalBindingSource_CurrentChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "ID_Сотрудника";
            // 
            // btn_Cuncel
            // 
            this.btn_Cuncel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cuncel.Location = new System.Drawing.Point(697, 31);
            this.btn_Cuncel.Name = "btn_Cuncel";
            this.btn_Cuncel.Size = new System.Drawing.Size(104, 48);
            this.btn_Cuncel.TabIndex = 52;
            this.btn_Cuncel.Text = "Отмена";
            this.btn_Cuncel.UseVisualStyleBackColor = true;
            // 
            // lb_Warning
            // 
            this.lb_Warning.AutoSize = true;
            this.lb_Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_Warning.Location = new System.Drawing.Point(6, 67);
            this.lb_Warning.Name = "lb_Warning";
            this.lb_Warning.Size = new System.Drawing.Size(646, 25);
            this.lb_Warning.TabIndex = 62;
            this.lb_Warning.Text = "Для добавления курьеров необходимо создать аккаунт сотрудника";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "ФИО", true));
            this.textBox3.Location = new System.Drawing.Point(142, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(483, 22);
            this.textBox3.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "ФИО Сотрудника";
            // 
            // gb_Curier
            // 
            this.gb_Curier.Controls.Add(this.dataGridView1);
            this.gb_Curier.Controls.Add(this.bN_Oder);
            this.gb_Curier.Controls.Add(this.lb_Warning);
            this.gb_Curier.Location = new System.Drawing.Point(19, 152);
            this.gb_Curier.Name = "gb_Curier";
            this.gb_Curier.Size = new System.Drawing.Size(770, 112);
            this.gb_Curier.TabIndex = 57;
            this.gb_Curier.TabStop = false;
            this.gb_Curier.Text = "Курьер";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКурьераDataGridViewTextBoxColumn,
            this.номерВУDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.машинаDataGridViewTextBoxColumn,
            this.номермашиныDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.curierBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 64);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDКурьераDataGridViewTextBoxColumn
            // 
            this.iDКурьераDataGridViewTextBoxColumn.DataPropertyName = "ID_Курьера";
            this.iDКурьераDataGridViewTextBoxColumn.HeaderText = "ID_Курьера";
            this.iDКурьераDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDКурьераDataGridViewTextBoxColumn.Name = "iDКурьераDataGridViewTextBoxColumn";
            this.iDКурьераDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерВУDataGridViewTextBoxColumn
            // 
            this.номерВУDataGridViewTextBoxColumn.DataPropertyName = "Номер_ВУ";
            this.номерВУDataGridViewTextBoxColumn.HeaderText = "Номер_ВУ";
            this.номерВУDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерВУDataGridViewTextBoxColumn.Name = "номерВУDataGridViewTextBoxColumn";
            this.номерВУDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.Width = 125;
            // 
            // машинаDataGridViewTextBoxColumn
            // 
            this.машинаDataGridViewTextBoxColumn.DataPropertyName = "Машина";
            this.машинаDataGridViewTextBoxColumn.HeaderText = "Машина";
            this.машинаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.машинаDataGridViewTextBoxColumn.Name = "машинаDataGridViewTextBoxColumn";
            this.машинаDataGridViewTextBoxColumn.Width = 125;
            // 
            // номермашиныDataGridViewTextBoxColumn
            // 
            this.номермашиныDataGridViewTextBoxColumn.DataPropertyName = "Номер_машины";
            this.номермашиныDataGridViewTextBoxColumn.HeaderText = "Номер_машины";
            this.номермашиныDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номермашиныDataGridViewTextBoxColumn.Name = "номермашиныDataGridViewTextBoxColumn";
            this.номермашиныDataGridViewTextBoxColumn.Width = 125;
            // 
            // curierBindingSource
            // 
            this.curierBindingSource.DataSource = typeof(dodoisbase.Nhibernate.Entites.Curier);
            this.curierBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.curierBindingSource_AddingNew);
            this.curierBindingSource.CurrentChanged += new System.EventHandler(this.curierBindingSource_CurrentChanged);
            // 
            // bN_Oder
            // 
            this.bN_Oder.AddNewItem = this.curierbindingNavigatorAddNewItem1;
            this.bN_Oder.BindingSource = this.curierBindingSource;
            this.bN_Oder.CountItem = this.bindingNavigatorCountItem1;
            this.bN_Oder.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bN_Oder.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bN_Oder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.curierbindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.toolStripButton1});
            this.bN_Oder.Location = new System.Drawing.Point(3, 18);
            this.bN_Oder.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bN_Oder.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bN_Oder.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bN_Oder.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bN_Oder.Name = "bN_Oder";
            this.bN_Oder.PositionItem = this.bindingNavigatorPositionItem1;
            this.bN_Oder.Size = new System.Drawing.Size(764, 27);
            this.bN_Oder.TabIndex = 0;
            this.bN_Oder.Text = "bN_Curier";
            // 
            // curierbindingNavigatorAddNewItem1
            // 
            this.curierbindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.curierbindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("curierbindingNavigatorAddNewItem1.Image")));
            this.curierbindingNavigatorAddNewItem1.Name = "curierbindingNavigatorAddNewItem1";
            this.curierbindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.curierbindingNavigatorAddNewItem1.Size = new System.Drawing.Size(29, 24);
            this.curierbindingNavigatorAddNewItem1.Text = "Добавить";
            this.curierbindingNavigatorAddNewItem1.Click += new System.EventHandler(this.curierbindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem1.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(220, 24);
            this.toolStripButton1.Text = "Просмотр и редактирование ";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Стаж", true));
            this.textBox2.Location = new System.Drawing.Point(293, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 22);
            this.textBox2.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Стаж";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // personalbindingNavigatorAddNewItem
            // 
            this.personalbindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personalbindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("personalbindingNavigatorAddNewItem.Image")));
            this.personalbindingNavigatorAddNewItem.Name = "personalbindingNavigatorAddNewItem";
            this.personalbindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.personalbindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.personalbindingNavigatorAddNewItem.Text = "Добавить";
            this.personalbindingNavigatorAddNewItem.Click += new System.EventHandler(this.personalbindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bN_User
            // 
            this.bN_User.AddNewItem = this.personalbindingNavigatorAddNewItem;
            this.bN_User.BindingSource = this.personalBindingSource;
            this.bN_User.CountItem = this.bindingNavigatorCountItem;
            this.bN_User.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "ID_Сотрудника", true));
            this.bN_User.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bN_User.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bN_User.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.personalbindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bN_User.Location = new System.Drawing.Point(0, 0);
            this.bN_User.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bN_User.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bN_User.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bN_User.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bN_User.Name = "bN_User";
            this.bN_User.PositionItem = this.bindingNavigatorPositionItem;
            this.bN_User.Size = new System.Drawing.Size(813, 27);
            this.bN_User.TabIndex = 60;
            this.bN_User.Text = "bN_Personal";
            // 
            // dodoDS
            // 
            this.dodoDS.DataSetName = "dodoDS";
            this.dodoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // curierTableAdapter
            // 
            this.curierTableAdapter.ClearBeforeFill = true;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // CurierFormUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 277);
            this.Controls.Add(this.bN_User);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gb_Curier);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cuncel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tb_FIO);
            this.Controls.Add(this.label2);
            this.Name = "CurierFormUnit";
            this.Text = "Форма Курьера";
            this.Load += new System.EventHandler(this.CurierFormUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            this.gb_Curier.ResumeLayout(false);
            this.gb_Curier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bN_Oder)).EndInit();
            this.bN_Oder.ResumeLayout(false);
            this.bN_Oder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bN_User)).EndInit();
            this.bN_User.ResumeLayout(false);
            this.bN_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dodoDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox tb_FIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource curierBindingSource;
        private System.Windows.Forms.Button btn_Cuncel;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private dodoDS dodoDS;
        private dodoDSTableAdapters.КурьерTableAdapter curierTableAdapter;
        private System.Windows.Forms.Label lb_Warning;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_Curier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bN_Oder;
        private System.Windows.Forms.ToolStripButton curierbindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton personalbindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingNavigator bN_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКурьераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерВУDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn машинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номермашиныDataGridViewTextBoxColumn;
        private dodoDSTableAdapters.СотрудникиTableAdapter personalTableAdapter;
    }
}