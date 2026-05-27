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
    public partial class UserListForm : Form
    {
        public UserListForm()
        {
            InitializeComponent();
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dodoDS.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.dodoDS.Клиент);
            this.клиентTableAdapter.Update(this.dodoDS.Клиент);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            UserFormUnit user_form_unit  = new  UserFormUnit();
            user_form_unit.CreateItem();
            if (user_form_unit.ShowDialog() == DialogResult.OK)
            {
                //Обнова знач в таб
                this.клиентTableAdapter.Fill(this.dodoDS.Клиент);
            }
            ;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var row = ((DataRowView)this.клиентBindingSource.Current).Row;
            var column = dodoDS.Клиент.Columns["ID_Клиента"];
            int user_id = Convert.ToInt32(row[column]);

            //Открытие формы для ред
            UserFormUnit user_form_unit = new UserFormUnit();
            user_form_unit.LoadItem(user_id);
            user_form_unit.ShowDialog();
            //Обнова знач
            this.клиентTableAdapter.Fill(this.dodoDS.Клиент);
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (this.клиентBindingSource.Current == null) return;

            if (MessageBox.Show("Действительно хотите удалить запись?", "", MessageBoxButtons.YesNo) == DialogResult.No) return;

            this.клиентBindingSource.RemoveCurrent();

            this.клиентTableAdapter.Update(this.dodoDS.Клиент);
            this.клиентTableAdapter.Fill(this.dodoDS.Клиент);
        }
    }
}
