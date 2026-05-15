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
    public partial class OdersForm : Form
    {
        public OdersForm()
        {
            InitializeComponent();
        }

        public void CreateItem(int ID_Клиента, string Адресс_доставки)
        {
            this.bS_Oder.AddNew();
            var row = ((DataRowView)this.bS_Oder.Current).Row;
            var col = this.dodoDS.Заказ.Columns["ID_Клиента"];
            var col_adress = dodoDS.Заказ.Columns["Адресс_доставки"];
            row[col] = ID_Клиента;
            row[col_adress] = Адресс_доставки;

        }
        public void LoadItem(int ID_Заказа)
        {
            this.заказTableAdapter.FillBy(this.dodoDS.Заказ, ID_Заказа);
        }

        private void OdersForm_Load(object sender, EventArgs e)
        {
            dateTPOder.Value= DateTime.Now;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bS_Oder.EndEdit();
            this.заказTableAdapter.Update(this.dodoDS.Заказ);
        }
    }
}
