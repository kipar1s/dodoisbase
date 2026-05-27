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
    public partial class CategoriEnumU : Form
    {
        public CategoriEnumU()
        {
            InitializeComponent();
        }

        private void CategoriEnumU_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dodoDS.Категории". При необходимости она может быть перемещена или удалена.
            this.категорииTableAdapter.Fill(this.dodoDS.Категории);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Сохранение
            this.категорииBindingSource.EndEdit();
            this.категорииTableAdapter.Update(this.dodoDS.Категории);

            //Подгрузка данных
            this.категорииTableAdapter.Fill(this.dodoDS.Категории);
        }

        private void CategoriEnumU_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.категорииBindingSource.EndEdit();
            if(this.dodoDS.HasChanges())
            {
                var result = MessageBox.Show("Сохранить изменения перед выходом?", "Внимание",
                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(result == DialogResult.Cancel){
                    e.Cancel = true;
                    return;}

                if (result == DialogResult.Yes)
                {
                    dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    this.категорииTableAdapter.Update(this.dodoDS.Категории);}}
        }
    }
}
