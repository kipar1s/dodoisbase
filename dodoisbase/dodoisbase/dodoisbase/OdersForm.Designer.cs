namespace dodoisbase
{
    partial class OdersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.bS_Oder = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_adress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTPOder = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.заказTableAdapter = new dodoisbase.dodoDSTableAdapters.ЗаказTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dodoDS = new dodoisbase.dodoDS();
            ((System.ComponentModel.ISupportInitialize)(this.bS_Oder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodoDS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_Oder, "ID_Заказа", true));
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(141, 43);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(53, 22);
            this.tb_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата заказа";
            // 
            // tb_sum
            // 
            this.tb_sum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_Oder, "Сумма", true));
            this.tb_sum.Location = new System.Drawing.Point(141, 119);
            this.tb_sum.Name = "tb_sum";
            this.tb_sum.Size = new System.Drawing.Size(100, 22);
            this.tb_sum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сумма заказа";
            // 
            // tb_adress
            // 
            this.tb_adress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_Oder, "Адресс_доставки", true));
            this.tb_adress.Location = new System.Drawing.Point(141, 164);
            this.tb_adress.Multiline = true;
            this.tb_adress.Name = "tb_adress";
            this.tb_adress.Size = new System.Drawing.Size(455, 36);
            this.tb_adress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Адресс доставки";
            // 
            // dateTPOder
            // 
            this.dateTPOder.CustomFormat = "yyyy-mm-dd";
            this.dateTPOder.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bS_Oder, "Дата_заказа", true));
            this.dateTPOder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTPOder.Location = new System.Drawing.Point(141, 82);
            this.dateTPOder.Name = "dateTPOder";
            this.dateTPOder.Size = new System.Drawing.Size(100, 22);
            this.dateTPOder.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(124, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 68);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сохранить ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Статус заказа";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Доставлен",
            "Отменен"});
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_Oder, "Статус", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Доставлен",
            "Отменен"});
            this.comboBox1.Location = new System.Drawing.Point(335, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // dodoDS
            // 
            this.dodoDS.DataSetName = "dodoDS";
            this.dodoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 322);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTPOder);
            this.Controls.Add(this.tb_adress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label1);
            this.Name = "OdersForm";
            this.Text = "Форма Заказа";
            this.Load += new System.EventHandler(this.OdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bS_Oder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodoDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_sum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_adress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTPOder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bS_Oder;
        private dodoDSTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private dodoDS dodoDS;
    }
}