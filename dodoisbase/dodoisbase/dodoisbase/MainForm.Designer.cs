namespace dodoisbase
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыКлинетовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ингрединтыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курьерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перечисленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ингридиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.составЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникToolStripMenuItem,
            this.перечисленияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.заказыToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.ингрединтыToolStripMenuItem,
            this.курьерыToolStripMenuItem,
            this.товарыToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.справочникToolStripMenuItem.Text = "Справочник";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.заказыToolStripMenuItem.Text = "Заказы";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыКлинетовToolStripMenuItem});
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // заказыКлинетовToolStripMenuItem
            // 
            this.заказыКлинетовToolStripMenuItem.Name = "заказыКлинетовToolStripMenuItem";
            this.заказыКлинетовToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.заказыКлинетовToolStripMenuItem.Text = "Заказы Клинетов";
            this.заказыКлинетовToolStripMenuItem.Click += new System.EventHandler(this.заказыКлинетовToolStripMenuItem_Click);
            // 
            // ингрединтыToolStripMenuItem
            // 
            this.ингрединтыToolStripMenuItem.Name = "ингрединтыToolStripMenuItem";
            this.ингрединтыToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.ингрединтыToolStripMenuItem.Text = "Ингредиенты";
            this.ингрединтыToolStripMenuItem.Click += new System.EventHandler(this.ингрединтыToolStripMenuItem_Click);
            // 
            // курьерыToolStripMenuItem
            // 
            this.курьерыToolStripMenuItem.Name = "курьерыToolStripMenuItem";
            this.курьерыToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.курьерыToolStripMenuItem.Text = "Курьеры";
            this.курьерыToolStripMenuItem.Click += new System.EventHandler(this.курьерыToolStripMenuItem_Click);
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.товарыToolStripMenuItem.Text = "Товары";
            this.товарыToolStripMenuItem.Click += new System.EventHandler(this.товарыToolStripMenuItem_Click);
            // 
            // перечисленияToolStripMenuItem
            // 
            this.перечисленияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.категорииToolStripMenuItem,
            this.ингридиентыToolStripMenuItem,
            this.доставкаToolStripMenuItem,
            this.составЗаказаToolStripMenuItem});
            this.перечисленияToolStripMenuItem.Name = "перечисленияToolStripMenuItem";
            this.перечисленияToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.перечисленияToolStripMenuItem.Text = "Перечисления";
            // 
            // категорииToolStripMenuItem
            // 
            this.категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
            this.категорииToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.категорииToolStripMenuItem.Text = "Категории";
            this.категорииToolStripMenuItem.Click += new System.EventHandler(this.категорииToolStripMenuItem_Click);
            // 
            // ингридиентыToolStripMenuItem
            // 
            this.ингридиентыToolStripMenuItem.Name = "ингридиентыToolStripMenuItem";
            this.ингридиентыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ингридиентыToolStripMenuItem.Text = "Ингридиенты";
            this.ингридиентыToolStripMenuItem.Click += new System.EventHandler(this.ингридиентыToolStripMenuItem_Click);
            // 
            // доставкаToolStripMenuItem
            // 
            this.доставкаToolStripMenuItem.Name = "доставкаToolStripMenuItem";
            this.доставкаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.доставкаToolStripMenuItem.Text = "Доставка";
            this.доставкаToolStripMenuItem.Click += new System.EventHandler(this.доставкаToolStripMenuItem_Click);
            // 
            // составЗаказаToolStripMenuItem
            // 
            this.составЗаказаToolStripMenuItem.Name = "составЗаказаToolStripMenuItem";
            this.составЗаказаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.составЗаказаToolStripMenuItem.Text = "Состав заказа";
            this.составЗаказаToolStripMenuItem.Click += new System.EventHandler(this.составЗаказаToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 744);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник Додо Пиица ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ингрединтыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курьерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыКлинетовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перечисленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ингридиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доставкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem составЗаказаToolStripMenuItem;
    }
}

