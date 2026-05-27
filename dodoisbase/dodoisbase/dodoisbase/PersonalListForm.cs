using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using dodoisbase.Nhibernate.Entites;

namespace dodoisbase
{
    public partial class PersonalListForm : Form
    {

        /*ISession nhibernate_session;
        IList<Personal> personals;*/

        public PersonalListForm()
        {
            InitializeComponent();
        }

        private void PersonalListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dodoDS.Курьер". При необходимости она может быть перемещена или удалена.
            //this.курьерTableAdapter.Fill(this.dodoDS.Курьер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dodoDS.Категории". При необходимости она может быть перемещена или удалена.
            this.категорииTableAdapter.Fill(this.dodoDS.Категории);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dodoDS.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.dodoDS.Сотрудники);

            //Иницилизация NHibernate , создание сессии
            /*var c = new Configuration();
            c.Configure();
            c.AddAssembly("dodoisbase");
            nhibernate_session = c.BuildSessionFactory().OpenSession();*/

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PersonalFormUnit pers_form_unit = new PersonalFormUnit();            
            pers_form_unit.CreateItem();
            if (pers_form_unit.ShowDialog() == DialogResult.OK)
            {
                //Обнова знач в таб
                this.сотрудникиTableAdapter.Fill(this.dodoDS.Сотрудники);
            }
            ;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var row = ((DataRowView)this.сотрудникиBindingSource.Current).Row;
            var column = dodoDS.Сотрудники.Columns["ID_Сотрудника"];
            int pers_id = Convert.ToInt32(row[column]);

            //Открытие формы для ред
            PersonalFormUnit pers_form_unit = new PersonalFormUnit();
            pers_form_unit.LoadItem(pers_id);
            pers_form_unit.ShowDialog();
            //Обнова знач в таб
            this.сотрудникиTableAdapter.Fill(this.dodoDS.Сотрудники);
        }

        private void PersonalListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Сохранение изменения при закрытие
            this.сотрудникиTableAdapter.Update(this.dodoDS.Сотрудники);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (this.сотрудникиBindingSource.Current == null) return;

            if (MessageBox.Show("Действительно хотите удалить запись?", "", MessageBoxButtons.YesNo) == DialogResult.No) return;

            this.сотрудникиBindingSource.RemoveCurrent();

            this.сотрудникиTableAdapter.Update(this.dodoDS.Сотрудники);
            this.сотрудникиTableAdapter.Fill(this.dodoDS.Сотрудники);
        }
    }
}
