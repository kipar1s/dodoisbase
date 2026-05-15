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
    public partial class OderListF : Form
    {
        public OderListF()
        {
            InitializeComponent();
        }

        private void OderListF_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dodoDS.Заказ". При необходимости она может быть перемещена или удалена.
            this.oderTableAdapter.Fill(this.dodoDS.Заказ);

        }

        private void tsb_Create_Click(object sender, EventArgs e)
        {
            OderFormUser oder_form_user = new OderFormUser();
            oder_form_user.Show();          
            this.oderTableAdapter.Fill(this.dodoDS.Заказ);
            
        }

        private void tsb_Edit_Click(object sender, EventArgs e)
        {
            OderFormUser oder_form_user = new OderFormUser();
            oder_form_user.Show();
            this.oderTableAdapter.Fill(this.dodoDS.Заказ);
        }

        private void tsb_Delite_Click(object sender, EventArgs e)
        {
            if (this.заказBindingSource.Current == null) return;

            if (MessageBox.Show("Действительно хотите удалить запись?", "", MessageBoxButtons.YesNo) == DialogResult.No) return;

            this.заказBindingSource.RemoveCurrent();
            this.oderTableAdapter.Fill(this.dodoDS.Заказ); 
            this.oderTableAdapter.Fill(this.dodoDS.Заказ);
        }
    }
}
