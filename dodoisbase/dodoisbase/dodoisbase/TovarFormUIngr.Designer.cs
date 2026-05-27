namespace dodoisbase.Nhibernate.Maping
{
    partial class TovarFormUIngr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TovarFormUIngr));
            this.товарTableAdapter = new dodoisbase.dodoDSTableAdapters.ТоварTableAdapter();
            this.ингредиентыTableAdapter = new dodoisbase.dodoDSTableAdapters.ИнгредиентыTableAdapter();
            this.ingrbN = new System.Windows.Forms.BindingNavigator(this.components);
            this.AddNew_Ingr = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.Delete_Ingr = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Edit_Ingr = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tovarbN = new System.Windows.Forms.BindingNavigator(this.components);
            this.AddNew_Tovar = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.Delete_Tovar = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Edit_Tovat = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_IDIngr = new System.Windows.Forms.TextBox();
            this.lb_Warning = new System.Windows.Forms.Label();
            this.iDТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ингредиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDИнгредиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.калорийностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovarbS = new System.Windows.Forms.BindingSource(this.components);
            this.ingrbS = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ingrbN)).BeginInit();
            this.ingrbN.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarbN)).BeginInit();
            this.tovarbN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tovarbS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingrbS)).BeginInit();
            this.SuspendLayout();
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // ингредиентыTableAdapter
            // 
            this.ингредиентыTableAdapter.ClearBeforeFill = true;
            // 
            // ingrbN
            // 
            this.ingrbN.AddNewItem = this.AddNew_Ingr;
            this.ingrbN.BindingSource = this.ingrbS;
            this.ingrbN.CountItem = this.bindingNavigatorCountItem;
            this.ingrbN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingrbS, "ID_Ингредиента", true));
            this.ingrbN.DeleteItem = this.Delete_Ingr;
            this.ingrbN.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ingrbN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.AddNew_Ingr,
            this.Edit_Ingr,
            this.Delete_Ingr});
            this.ingrbN.Location = new System.Drawing.Point(0, 0);
            this.ingrbN.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ingrbN.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ingrbN.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ingrbN.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ingrbN.Name = "ingrbN";
            this.ingrbN.PositionItem = this.bindingNavigatorPositionItem;
            this.ingrbN.Size = new System.Drawing.Size(800, 27);
            this.ingrbN.TabIndex = 0;
            this.ingrbN.Text = "ingrbN";
            // 
            // AddNew_Ingr
            // 
            this.AddNew_Ingr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddNew_Ingr.Image = ((System.Drawing.Image)(resources.GetObject("AddNew_Ingr.Image")));
            this.AddNew_Ingr.Name = "AddNew_Ingr";
            this.AddNew_Ingr.RightToLeftAutoMirrorImage = true;
            this.AddNew_Ingr.Size = new System.Drawing.Size(29, 24);
            this.AddNew_Ingr.Text = "Добавить";
            this.AddNew_Ingr.Click += new System.EventHandler(this.AddNew_Tovar_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // Delete_Ingr
            // 
            this.Delete_Ingr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Delete_Ingr.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Ingr.Image")));
            this.Delete_Ingr.Name = "Delete_Ingr";
            this.Delete_Ingr.RightToLeftAutoMirrorImage = true;
            this.Delete_Ingr.Size = new System.Drawing.Size(29, 24);
            this.Delete_Ingr.Text = "Удалить";
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
            // Edit_Ingr
            // 
            this.Edit_Ingr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Edit_Ingr.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Ingr.Image")));
            this.Edit_Ingr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_Ingr.Name = "Edit_Ingr";
            this.Edit_Ingr.Size = new System.Drawing.Size(127, 24);
            this.Edit_Ingr.Text = "Редактирование";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.tovarbN);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Товары с этим ингридиентом";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDТовараDataGridViewTextBoxColumn,
            this.ингредиентDataGridViewTextBoxColumn,
            this.iDИнгредиентаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn,
            this.калорийностьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tovarbS;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 168);
            this.dataGridView1.TabIndex = 1;
            // 
            // tovarbN
            // 
            this.tovarbN.AddNewItem = this.AddNew_Tovar;
            this.tovarbN.BindingSource = this.tovarbS;
            this.tovarbN.CountItem = this.bindingNavigatorCountItem1;
            this.tovarbN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarbS, "ID_Товара", true));
            this.tovarbN.DeleteItem = this.Delete_Tovar;
            this.tovarbN.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tovarbN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.AddNew_Tovar,
            this.Edit_Tovat,
            this.Delete_Tovar});
            this.tovarbN.Location = new System.Drawing.Point(3, 18);
            this.tovarbN.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.tovarbN.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.tovarbN.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.tovarbN.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.tovarbN.Name = "tovarbN";
            this.tovarbN.PositionItem = this.bindingNavigatorPositionItem1;
            this.tovarbN.Size = new System.Drawing.Size(758, 31);
            this.tovarbN.TabIndex = 0;
            this.tovarbN.Text = "tovarbN";
            // 
            // AddNew_Tovar
            // 
            this.AddNew_Tovar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddNew_Tovar.Image = ((System.Drawing.Image)(resources.GetObject("AddNew_Tovar.Image")));
            this.AddNew_Tovar.Name = "AddNew_Tovar";
            this.AddNew_Tovar.RightToLeftAutoMirrorImage = true;
            this.AddNew_Tovar.Size = new System.Drawing.Size(29, 28);
            this.AddNew_Tovar.Text = "Добавить";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // Delete_Tovar
            // 
            this.Delete_Tovar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Delete_Tovar.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Tovar.Image")));
            this.Delete_Tovar.Name = "Delete_Tovar";
            this.Delete_Tovar.RightToLeftAutoMirrorImage = true;
            this.Delete_Tovar.Size = new System.Drawing.Size(29, 28);
            this.Delete_Tovar.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // Edit_Tovat
            // 
            this.Edit_Tovat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Edit_Tovat.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Tovat.Image")));
            this.Edit_Tovat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_Tovat.Name = "Edit_Tovat";
            this.Edit_Tovat.Size = new System.Drawing.Size(127, 28);
            this.Edit_Tovat.Text = "Редактироавние";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "IDИнгридиента";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(344, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 43);
            this.button1.TabIndex = 36;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_cancel.Location = new System.Drawing.Point(499, 34);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(149, 43);
            this.btn_cancel.TabIndex = 37;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_IDIngr
            // 
            this.tb_IDIngr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingrbS, "ID_Ингредиента", true));
            this.tb_IDIngr.Location = new System.Drawing.Point(125, 40);
            this.tb_IDIngr.Name = "tb_IDIngr";
            this.tb_IDIngr.Size = new System.Drawing.Size(100, 22);
            this.tb_IDIngr.TabIndex = 35;
            // 
            // lb_Warning
            // 
            this.lb_Warning.AutoSize = true;
            this.lb_Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_Warning.Location = new System.Drawing.Point(30, 80);
            this.lb_Warning.Name = "lb_Warning";
            this.lb_Warning.Size = new System.Drawing.Size(563, 25);
            this.lb_Warning.TabIndex = 38;
            this.lb_Warning.Text = "Для добавления товаров необходимо создать ингридиент";
            // 
            // iDТовараDataGridViewTextBoxColumn
            // 
            this.iDТовараDataGridViewTextBoxColumn.DataPropertyName = "ID_Товара";
            this.iDТовараDataGridViewTextBoxColumn.HeaderText = "ID_Товара";
            this.iDТовараDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDТовараDataGridViewTextBoxColumn.Name = "iDТовараDataGridViewTextBoxColumn";
            this.iDТовараDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDТовараDataGridViewTextBoxColumn.Width = 125;
            // 
            // ингредиентDataGridViewTextBoxColumn
            // 
            this.ингредиентDataGridViewTextBoxColumn.DataPropertyName = "Ингредиент";
            this.ингредиентDataGridViewTextBoxColumn.HeaderText = "Ингредиент";
            this.ингредиентDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ингредиентDataGridViewTextBoxColumn.Name = "ингредиентDataGridViewTextBoxColumn";
            this.ингредиентDataGridViewTextBoxColumn.Visible = false;
            this.ингредиентDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDИнгредиентаDataGridViewTextBoxColumn
            // 
            this.iDИнгредиентаDataGridViewTextBoxColumn.DataPropertyName = "IDИнгредиента";
            this.iDИнгредиентаDataGridViewTextBoxColumn.HeaderText = "IDИнгредиента";
            this.iDИнгредиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDИнгредиентаDataGridViewTextBoxColumn.Name = "iDИнгредиентаDataGridViewTextBoxColumn";
            this.iDИнгредиентаDataGridViewTextBoxColumn.Visible = false;
            this.iDИнгредиентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.Width = 125;
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            this.категорияDataGridViewTextBoxColumn.Width = 125;
            // 
            // калорийностьDataGridViewTextBoxColumn
            // 
            this.калорийностьDataGridViewTextBoxColumn.DataPropertyName = "Калорийность";
            this.калорийностьDataGridViewTextBoxColumn.HeaderText = "Калорийность";
            this.калорийностьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.калорийностьDataGridViewTextBoxColumn.Name = "калорийностьDataGridViewTextBoxColumn";
            this.калорийностьDataGridViewTextBoxColumn.Width = 125;
            // 
            // tovarbS
            // 
            this.tovarbS.DataSource = typeof(dodoisbase.Nhibernate.Entites.Tovar);
            // 
            // ingrbS
            // 
            this.ingrbS.DataSource = typeof(dodoisbase.Nhibernate.Entites.Ingr);
            // 
            // TovarFormUIngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Warning);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_IDIngr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ingrbN);
            this.Name = "TovarFormUIngr";
            this.Text = "Форма Товара из Ингридиентом";
            this.Load += new System.EventHandler(this.TovarFormUIngr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ingrbN)).EndInit();
            this.ingrbN.ResumeLayout(false);
            this.ingrbN.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarbN)).EndInit();
            this.tovarbN.ResumeLayout(false);
            this.tovarbN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tovarbS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingrbS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dodoDSTableAdapters.ТоварTableAdapter товарTableAdapter;
        private dodoDSTableAdapters.ИнгредиентыTableAdapter ингредиентыTableAdapter;
        private System.Windows.Forms.BindingSource tovarbS;
        private System.Windows.Forms.BindingSource ingrbS;
        private System.Windows.Forms.BindingNavigator ingrbN;
        private System.Windows.Forms.ToolStripButton AddNew_Ingr;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton Delete_Ingr;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator tovarbN;
        private System.Windows.Forms.ToolStripButton AddNew_Tovar;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton Delete_Tovar;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ингредиентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDИнгредиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn калорийностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ToolStripButton Edit_Ingr;
        private System.Windows.Forms.ToolStripButton Edit_Tovat;
        private System.Windows.Forms.TextBox tb_IDIngr;
        private System.Windows.Forms.Label lb_Warning;
    }
}