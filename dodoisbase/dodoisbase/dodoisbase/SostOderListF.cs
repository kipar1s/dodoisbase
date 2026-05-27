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
    public partial class SostOderListF : Form
    {
        public SostOderListF()
        {
            InitializeComponent();
        }

        private void SostOderListF_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dodoDS.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.dodoDS.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dodoDS.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.dodoDS.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dodoDS.Состав_заказа". При необходимости она может быть перемещена или удалена.
            this.состав_заказаTableAdapter.Fill(this.dodoDS.Состав_заказа);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.составзаказаBindingSource.EndEdit();
            this.состав_заказаTableAdapter.Update(this.dodoDS.Состав_заказа);
            this.состав_заказаTableAdapter.Fill(this.dodoDS.Состав_заказа);
        }

        private void SostOderListF_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.составзаказаBindingSource.EndEdit();
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
                    this.состав_заказаTableAdapter.Update(this.dodoDS.Состав_заказа);
                }
            }
        }
    }
}
