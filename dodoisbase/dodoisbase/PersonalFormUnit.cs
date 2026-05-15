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
    public partial class PersonalFormUnit : Form
    {
        public PersonalFormUnit()
        {
            InitializeComponent();
        }

        public void CreateItem()
        {
            this.сотрудникиBindingSource.AddNew();
        }
        public void LoadItem(int ID_Сотрудника)
        {
            this.сотрудникиTableAdapter.FillBy(this.dodoDS.Сотрудники, ID_Сотрудника);

            
        }

        private void PerconalFormUnit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dodoDS.Категории". При необходимости она может быть перемещена или удалена.
            this.категорииTableAdapter.Fill(this.dodoDS.Категории);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dodoDS.Сотрудники". При необходимости она может быть перемещена или удалена.
            //this.сотрудникиTableAdapter.Fill(this.dodoDS.Сотрудники);
            //Костыль для подгрузкаи правильных данных в комбобокс
            cb_Categor.DataBindings["SelectedValue"]?.ReadValue();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.EndEdit();
            this.сотрудникиTableAdapter.Update(this.dodoDS.Сотрудники);
            Close();
        }
    }
}
