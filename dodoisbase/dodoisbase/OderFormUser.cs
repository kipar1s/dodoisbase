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

    enum State_OderFormUser
    {
        Create = 1,//Создание нового клиента
        Update = 2,//Обновление сущ  клиента
    }
    public partial class OderFormUser : Form
    {
        static State_OderFormUser state;
        public OderFormUser()
        {
            InitializeComponent();
        }

        private void OderFormUser_Load(object sender, EventArgs e)
        {           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dodoDS.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.dodoDS.Клиент);

            //Есть ли клиент
            if (this.dodoDS.Клиент.Count > 0)
            {//Клиент есть - редактирование
                state = State_OderFormUser.Update;
                ShowOderList();//Отобразить табл заказов
            }
            else
            {//Клиента нет - создание
                state= State_OderFormUser.Create;
                HideOderList();//Отобразить предуприждение
            }
        }

        

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Сохранение позиции отредак работадателя
            int current_position = this.клиентbindingSource.Position;

            this.клиентbindingSource.EndEdit();
            this.клиентTableAdapter.Update(this.dodoDS.Клиент);
            
            if (state == State_OderFormUser.Create)
            {
                ShowOderList();
                state = State_OderFormUser.Update;

            }
            else
            {
                this.заказTableAdapter.Update(this.dodoDS.Заказ);
            }
            this.клиентTableAdapter.Fill(this.dodoDS.Клиент);
            this.клиентbindingSource.Position = current_position;
        }

        private void клиентbindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (state == State_OderFormUser.Create) return;

            if (this.клиентbindingSource.Current == null) return;
            
            //Выполнение загрузки заказов данного клиента
            this.заказTableAdapter.FillByЗаказID(
                this.dodoDS.Заказ,
                GetCurrentКлиентID()
                );
        }

        int GetCurrentКлиентID()
        {
            var row = ((DataRowView)this.клиентbindingSource.Current).Row;
            var col = this.dodoDS.Клиент.Columns["ID_Клиента"];
            return Convert.ToInt32(row[col]);
        }

        int GetCurrentЗаказID()
        {
            var row = ((DataRowView)this.заказbindingSource.Current).Row;
            var col = this.dodoDS.Заказ.Columns["ID_Заказа"];
            return Convert.ToInt32(row[col]);
        }

        string GetCurrentАдресс_доставки()
        {
            var row = ((DataRowView)this.заказbindingSource.Current).Row;
            var col = this.dodoDS.Заказ.Columns["Адресс_доставки"];
            return Convert.ToString(row[col]);
        }

        //Отобразить табл заказов и спрятать предуприждение
        void ShowOderList()
        {
            lb_Warning.Visible = false;
            gb_Oder.Visible = true;
        }

        //Скрыть табл заказов и показать предуприждение
        void HideOderList()
        {
            lb_Warning.Visible = true;
            gb_Oder.Visible = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            state = State_OderFormUser.Create;
            HideOderList();
        }

        private void заказbindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            if ((DataRowView)this.заказbindingSource.Current == null) return;
            //Автомотическая подстановка значения ID_Клиента в табличной части
            var row = ((DataRowView)this.заказbindingSource.Current).Row;
            var col = dodoDS.Заказ.Columns["ID_Клиента"];
            var col_adress = dodoDS.Заказ.Columns["Адресс_доставки"];
            row[col] = GetCurrentКлиентID();
            row[col_adress] = GetCurrentАдресс_доставки();
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            //Отображаем форму заказа
            OdersForm odf = new OdersForm();
            odf.CreateItem(GetCurrentКлиентID(),GetCurrentАдресс_доставки());
            if (odf.ShowDialog() == DialogResult.OK)
            {
                клиентbindingSource_CurrentChanged(null, null);

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Отображаем форму заказа
            OdersForm odf = new OdersForm();
            odf.LoadItem(GetCurrentЗаказID());
            if (odf.ShowDialog() == DialogResult.OK)
            {
                клиентbindingSource_CurrentChanged(null, null);

            }
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
