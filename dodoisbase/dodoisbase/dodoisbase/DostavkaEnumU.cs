using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dodoisbase
{
    public partial class DostavkaEnumU : Form
    {
        public DostavkaEnumU()
        {
            InitializeComponent();
        }

        private void DostavkaEnumU_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dodoDS.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.dodoDS.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dodoDS.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.dodoDS.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dodoDS.Доставка". При необходимости она может быть перемещена или удалена.
            this.доставкаTableAdapter.Fill(this.dodoDS.Доставка);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.доставкаBindingSource.EndEdit();
            this.доставкаTableAdapter.Update(this.dodoDS.Доставка);

            this.доставкаTableAdapter.Fill(this.dodoDS.Доставка);

        }

        private void DostavkaEnumU_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.доставкаBindingSource.EndEdit();
            if (this.dodoDS.HasChanges())
            {
                var result = MessageBox.Show("Сохранить изменения перед выходом?", "Внимание",
                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }

                if (result == DialogResult.Yes)
                {
                    dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    this.доставкаTableAdapter.Update(this.dodoDS.Доставка);
                }
            }
        }
    }
}
