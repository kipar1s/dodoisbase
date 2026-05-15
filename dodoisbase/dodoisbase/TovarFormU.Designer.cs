namespace dodoisbase
{
    partial class TovarFormU
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
            this.comboBoxIngredients = new System.Windows.Forms.ComboBox();
            this.dodoDS = new dodoisbase.dodoDS();
            this.ингредиентыTableAdapter = new dodoisbase.dodoDSTableAdapters.ИнгредиентыTableAdapter();
            this.товарTableAdapter = new dodoisbase.dodoDSTableAdapters.ТоварTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingrbindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dodoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingrbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIngredients
            // 
            this.comboBoxIngredients.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Категория", true));
            this.comboBoxIngredients.FormattingEnabled = true;
            this.comboBoxIngredients.Items.AddRange(new object[] {
            "Пицца",
            "Додсте",
            "Стартер",
            "Паста",
            "Десерт",
            "Коктель",
            "Лимонад",
            "Закуска"});
            this.comboBoxIngredients.Location = new System.Drawing.Point(133, 153);
            this.comboBoxIngredients.Name = "comboBoxIngredients";
            this.comboBoxIngredients.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIngredients.TabIndex = 0;
            // 
            // dodoDS
            // 
            this.dodoDS.DataSetName = "dodoDS";
            this.dodoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ингредиентыTableAdapter
            // 
            this.ингредиентыTableAdapter.ClearBeforeFill = true;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Калорийность";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Калорийность", true));
            this.textBox3.Location = new System.Drawing.Point(133, 188);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "IDИнгредиента", true));
            this.textBox1.Location = new System.Drawing.Point(133, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(33, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 68);
            this.button1.TabIndex = 32;
            this.button1.Text = "Сохранить ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Категория";
            // 
            // tb_sum
            // 
            this.tb_sum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Название", true));
            this.tb_sum.Location = new System.Drawing.Point(133, 87);
            this.tb_sum.Name = "tb_sum";
            this.tb_sum.Size = new System.Drawing.Size(100, 22);
            this.tb_sum.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "IDИнгридиента";
            // 
            // tb_id
            // 
            this.tb_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "ID_Товара", true));
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(133, 21);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(53, 22);
            this.tb_id.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Цена", true));
            this.textBox2.Location = new System.Drawing.Point(133, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Цена";
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataSource = typeof(dodoisbase.Nhibernate.Entites.Tovar);
            // 
            // ingrbindingSource
            // 
            this.ingrbindingSource.DataSource = typeof(dodoisbase.Nhibernate.Entites.Ingr);
            // 
            // TovarFormU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 319);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxIngredients);
            this.Name = "TovarFormU";
            this.Text = "TovarFormU";
            ((System.ComponentModel.ISupportInitialize)(this.dodoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingrbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIngredients;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private dodoDS dodoDS;
        private System.Windows.Forms.BindingSource ingrbindingSource;
        private dodoDSTableAdapters.ИнгредиентыTableAdapter ингредиентыTableAdapter;
        private dodoDSTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}