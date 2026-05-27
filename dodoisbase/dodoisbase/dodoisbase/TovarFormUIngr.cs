using dodoisbase.Nhibernate.Entites;
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

namespace dodoisbase.Nhibernate.Maping
{
    public partial class TovarFormUIngr : Form
    {
        ISession nhibernate_session;
        IList<Ingr> ingrs;

        public TovarFormUIngr()
        {
            InitializeComponent();
        }
        private void TovarFormUIngr_Load(object sender, EventArgs e)
        {
            // Инициализируем сессию для загрузки списка ингредиентов
            var c = new Configuration();
            c.Configure();
            c.AddAssembly("dodoisbase");
            nhibernate_session = c.BuildSessionFactory().OpenSession();

            // Загружаем все ингредиенты, чтобы пользователь мог выбрать один из них
            // Привязываем BindingSource ингридиентов к BindingNavigator (если сделано в коде)
            this.ingrbS.DataSource = ingrs; // список объектов IList<Ingr>
            this.ingrbN.BindingSource = this.ingrbS; // если навигатор создан

        }

        

        void UdateIngrGrid()
        {
            //Загрузка данных из таблицы курьеры в массив объекотов 
            ingrs = nhibernate_session.QueryOver<Ingr>().List<Ingr>();
            this.ingrbS.DataSource = ingrs;
        }
        public void SetDataSourse(Tovar tovar)
        {
            // Привязываем объект товара к BindingSource формы
            this.tovarbS.DataSource = tovar;

            
        }

        private void AddNew_Tovar_Click(object sender, EventArgs e)
        {
            Ingr ingrs = new Ingr();
            IngrFormU ingrFormU = new IngrFormU();
            ingrFormU.SetDataSourse(ingrs);
            if (ingrFormU.ShowDialog() == DialogResult.OK)
            {
                nhibernate_session.Save(ingrs);
                nhibernate_session.Flush();

                UdateIngrGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Завершаем редактирование в BindingSource
            this.tovarbS.EndEdit();

            // 2. Принудительно обновляем связь с ингредиентом из ComboBox
            Tovar currentTovar = (Tovar)this.tovarbS.Current;
            currentTovar.Ингредиент = (Ingr)this.ingrbS.Current;

            // 3. Закрываем форму с результатом OK (сохранение выполнит вызывающая форма TovarListF)
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
    }
    
}
