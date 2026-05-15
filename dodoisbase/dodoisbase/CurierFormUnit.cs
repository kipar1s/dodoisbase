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

    enum State_CurierFormUnit
    {
        Create = 1,//Создание нового клиента
        Update = 2,//Обновление сущ  клиента
    }

    public partial class CurierFormUnit : Form
    {
        ISession nhibernate_session;
        IList<Curier> curiers;

        static State_CurierFormUnit state;
        public CurierFormUnit()
        {
            InitializeComponent();
        }

        private void CurierFormUnit_Load(object sender, EventArgs e)
        {
            this.curierTableAdapter.Fill(this.dodoDS.Курьер);
            //Есть ли клиент
            if (this.dodoDS.Клиент.Count > 0)
            {//Клиент есть - редактирование
                state = State_CurierFormUnit.Update;

            }
            else
            {//Клиента нет - создание
                state = State_CurierFormUnit.Create;
            }
        }
        public void SetDataSourse(Curier curier)
        {
            this.curierBindingSource.DataSource = curier;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Сохранение позиции отредак сотрудника
            int current_position = this.personalBindingSource.Position;

            this.personalBindingSource.EndEdit();
            this.personalTableAdapter.Update(this.dodoDS.Сотрудники);

            if (state == State_CurierFormUnit.Create)
            {
                ShowOderList();
                state = State_CurierFormUnit.Update;

            }
            else
            {
                this.curierTableAdapter.Update(this.dodoDS.Курьер);
            }
            this.personalTableAdapter.Fill(this.dodoDS.Сотрудники);
            this.personalBindingSource.Position = current_position;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void personalBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (state == State_CurierFormUnit.Create) return;

            if (this.personalBindingSource.Current == null) return;

            //Выполнение загрузки заказов данного клиента
            this.curierTableAdapter.FillByIDСотрудника(
                this.dodoDS.Курьер,
                GetCurrentСотрудникID()
                );
        }

        int GetCurrentКурьерID()
        {
            var row = ((DataRowView)this.curierBindingSource.Current).Row;
            var col = this.dodoDS.Курьер.Columns["ID_Курьера"];
            return Convert.ToInt32(row[col]);
        }

        int GetCurrentСотрудникID()
        {
            var row = ((DataRowView)this.personalBindingSource.Current).Row;
            var col = this.dodoDS.Сотрудники.Columns["IDСотрудника"];
            return Convert.ToInt32(row[col]);
        }
        void ShowOderList()
        {
            lb_Warning.Visible = false;
            gb_Curier.Visible = true;
        }

        void HideOderList()
        {
            lb_Warning.Visible = true;
            gb_Curier.Visible = false;
        }
                
        private void curierbindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            CurierForm cf = new CurierForm();
            cf.CreateItem(GetCurrentСотрудникID(), GetCurrentКурьерID());
            if (cf.ShowDialog() == DialogResult.OK)
            {
                personalBindingSource_CurrentChanged(null, null);
            }
        }

        private void personalbindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            CurierForm cf = new CurierForm();
            //cf.CreateItem()
            if (cf.ShowDialog() == DialogResult.OK) {
                personalBindingSource_CurrentChanged(null, null);
            }
            state = State_CurierFormUnit.Create;
            HideOderList();
        }

        private void curierBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            if ((DataRowView)this.curierBindingSource.Current == null) return;
            //Автомотическая подстановка значения ID_Сотрудника в табличной части
            var row = ((DataRowView)this.curierBindingSource.Current).Row;
            var col_s = this.dodoDS.Заказ.Columns["IDСотрудника"];
            var col_cur = dodoDS.Заказ.Columns["ID_Курьера"];
            row[col_s] = GetCurrentСотрудникID();            
            row[col_cur] = GetCurrentКурьерID();
        }

        private void curierBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (state == State_CurierFormUnit.Create) return;
            if (this.curierBindingSource.Current == null) return;

            this.curierTableAdapter.FillByIDСотрудника(
                this.dodoDS.Курьер, GetCurrentКурьерID());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
