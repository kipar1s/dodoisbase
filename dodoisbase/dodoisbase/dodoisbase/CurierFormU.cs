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
    public partial class CurierForm : Form
    {
        public CurierForm()
        {
            InitializeComponent();
        }
        public void CreateItem(int IDСотрудника, int ID_Курьера)
        {
            this.curierBindingSource.AddNew();
            var row = ((DataRowView)this.curierBindingSource.Current).Row;
            var col_s = this.dodoDS.Заказ.Columns["IDСотрудника"];
            var col_cur = dodoDS.Заказ.Columns["ID_Курьера"];
            row[col_s] = IDСотрудника;
            row[col_cur] = ID_Курьера;

        }
        public void LoadItem(int ID_Курьера)
        {
            this.curierTableAdapter.FillBy(this.dodoDS.Курьер, ID_Курьера);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.curierBindingSource.EndEdit();
            this.curierTableAdapter.Update(this.dodoDS.Курьер);
        }
    }
}
