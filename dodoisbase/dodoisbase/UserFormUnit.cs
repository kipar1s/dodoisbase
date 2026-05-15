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
    public partial class UserFormUnit : Form
    {
        public UserFormUnit()
        {
            InitializeComponent();
        }

        public void CreateItem()
        {
            this.клиентbindingSource.AddNew();
        }
        public void LoadItem( int ID_Клиента)
        {
            this.клиентTableAdapter.FillBy(this.dodoDS.Клиент, ID_Клиента);
        }

        private void UserFormUnit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dodoDS.Клиент". При необходимости она может быть перемещена или удалена.
            //this.клиентTableAdapter.Fill(this.dodoDS.Клиент);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.клиентbindingSource.EndEdit();
            this.клиентTableAdapter.Update(this.dodoDS.Клиент);
            Close();
        }
    }
}
