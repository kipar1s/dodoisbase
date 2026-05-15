namespace dodoisbase
{
    partial class IngrListF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngrListF));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dodoDS = new dodoisbase.dodoDS();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ингредиентыTableAdapter = new dodoisbase.dodoDSTableAdapters.ИнгредиентыTableAdapter();
            this.Количество_на_складе = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDИнгредиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценазаедDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокгодностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ингредиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodoDS)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDИнгредиентаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.ценазаедDataGridViewTextBoxColumn,
            this.срокгодностиDataGridViewTextBoxColumn,
            this.Количество_на_складе});
            this.dataGridView1.DataSource = this.ингредиентыBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(967, 423);
            this.dataGridView1.TabIndex = 6;
            // 
            // dodoDS
            // 
            this.dodoDS.DataSetName = "dodoDS";
            this.dodoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(967, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 24);
            this.toolStripButton1.Text = "Создать";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(82, 24);
            this.toolStripButton2.Text = "Изменить";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(69, 24);
            this.toolStripButton3.Text = "Удалить";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // ингредиентыTableAdapter
            // 
            this.ингредиентыTableAdapter.ClearBeforeFill = true;
            // 
            // Количество_на_складе
            // 
            this.Количество_на_складе.DataPropertyName = "Количество_на_складе";
            this.Количество_на_складе.HeaderText = "Количество_на_складе";
            this.Количество_на_складе.MinimumWidth = 6;
            this.Количество_на_складе.Name = "Количество_на_складе";
            this.Количество_на_складе.Width = 125;
            // 
            // iDИнгредиентаDataGridViewTextBoxColumn
            // 
            this.iDИнгредиентаDataGridViewTextBoxColumn.DataPropertyName = "ID_Ингредиента";
            this.iDИнгредиентаDataGridViewTextBoxColumn.HeaderText = "ID Ингредиента";
            this.iDИнгредиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDИнгредиентаDataGridViewTextBoxColumn.Name = "iDИнгредиентаDataGridViewTextBoxColumn";
            this.iDИнгредиентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDИнгредиентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценазаедDataGridViewTextBoxColumn
            // 
            this.ценазаедDataGridViewTextBoxColumn.DataPropertyName = "Цена_за_ед";
            this.ценазаедDataGridViewTextBoxColumn.HeaderText = "Цена за ед";
            this.ценазаедDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценазаедDataGridViewTextBoxColumn.Name = "ценазаедDataGridViewTextBoxColumn";
            this.ценазаедDataGridViewTextBoxColumn.Width = 125;
            // 
            // срокгодностиDataGridViewTextBoxColumn
            // 
            this.срокгодностиDataGridViewTextBoxColumn.DataPropertyName = "Срок_годности";
            this.срокгодностиDataGridViewTextBoxColumn.HeaderText = "Срок годности";
            this.срокгодностиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.срокгодностиDataGridViewTextBoxColumn.Name = "срокгодностиDataGridViewTextBoxColumn";
            this.срокгодностиDataGridViewTextBoxColumn.Width = 125;
            // 
            // ингредиентыBindingSource
            // 
            this.ингредиентыBindingSource.DataSource = typeof(dodoisbase.Nhibernate.Entites.Ingr);
            // 
            // IngrListF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "IngrListF";
            this.Text = "Справочник \"Ингредиентов\"";
            this.Load += new System.EventHandler(this.IngrListF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodoDS)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private dodoDSTableAdapters.ИнгредиентыTableAdapter ингредиентыTableAdapter;
        private dodoDS dodoDS;
        private System.Windows.Forms.BindingSource ингредиентыBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDИнгредиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценазаедDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокгодностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество_на_складе;
    }
}