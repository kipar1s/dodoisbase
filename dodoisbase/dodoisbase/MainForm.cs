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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserListForm users_list_unit = new UserListForm();
            users_list_unit.MdiParent = this;
            users_list_unit.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalListForm personal_List_Form = new PersonalListForm();
            personal_List_Form.MdiParent = this;
            personal_List_Form.Show();
        }

        private void заказыКлинетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OderFormUser oder_form_user = new OderFormUser();
            oder_form_user.MdiParent = this;
            oder_form_user.Show();
        }

        private void курьерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurierList curier_List_Form = new CurierList();
            curier_List_Form.MdiParent= this;
            curier_List_Form.Show();
        }

        private void ингрединтыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngrListF ingr_List_F =new IngrListF();
            ingr_List_F.MdiParent = this;
            ingr_List_F.Show();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OderListF oder_list_f = new OderListF();
            oder_list_f.MdiParent = this;
            oder_list_f.Show();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TovarListF tovar_list_F = new TovarListF();
            tovar_list_F.MdiParent = this;
            tovar_list_F.Show();
        }
    }
}
