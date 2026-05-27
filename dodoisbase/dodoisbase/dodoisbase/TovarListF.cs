using dodoisbase.Nhibernate.Entites;
using dodoisbase.Nhibernate.Maping;
using NHibernate;
using NHibernate.Cfg;
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
    public partial class TovarListF : Form
    {
        ISession nhibernate_session;
        IList<Tovar> tovars; // Переименовал в tovars для ясности (список)

        public TovarListF()
        {
            InitializeComponent();
        }

        private void TovarListF_Load(object sender, EventArgs e)
        {
            try
            {
                var c = new Configuration();
                c.Configure();
                c.AddAssembly("dodoisbase");
                nhibernate_session = c.BuildSessionFactory().OpenSession();

                // Выполним загрузку данных 
                UpdateTovarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка инициализации NHibernate: " + ex.Message);
            }
        }

        void UpdateTovarGrid()
        {
            // Загрузка данных из таблицы товаров в массив объектов 
            // Используем try-catch, чтобы увидеть ошибку, если маппинг все еще неверный
            try
            {
                tovars = nhibernate_session.QueryOver<Tovar>().List<Tovar>();
                this.tovarBindingSource.DataSource = tovars;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки товаров: " + ex.Message +
                                "\nПроверьте файл Tovar.hbm.xml на опечатки.");
            }
        }

        private void tsb_Create_Click(object sender, EventArgs e)
        {
            
            Tovar new_tovar = new Tovar();

            TovarFormUIngr tovar_form_unit_ingr = new TovarFormUIngr();
            tovar_form_unit_ingr.SetDataSourse(new_tovar);

            if (tovar_form_unit_ingr.ShowDialog() == DialogResult.OK)
            {
                nhibernate_session.Save(new_tovar);
                nhibernate_session.Flush();

                // Обновление данных
                UpdateTovarGrid();
            }
        }

        private void tsb_Edit_Click(object sender, EventArgs e)
        {
            if (this.tovarBindingSource.Current == null) return;

            // Клонируем объект, чтобы изменения не применились сразу к списку без сохранения
            Tovar selected_tovar = MyUtiletes.Clone<Tovar>((Tovar)this.tovarBindingSource.Current);

            TovarFormUIngr tovar_form_unit_ingr = new TovarFormUIngr();
            tovar_form_unit_ingr.SetDataSourse(selected_tovar);

            if (tovar_form_unit_ingr.ShowDialog() == DialogResult.OK)
            {
                nhibernate_session.Merge(selected_tovar);
                nhibernate_session.Flush();

                // Обновление данных
                UpdateTovarGrid();
            }
        }

        private void tsb_Delete_Click(object sender, EventArgs e)
        {
            if (this.tovarBindingSource.Current == null) return;

            if (MessageBox.Show("Удалить выбранный товар?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Tovar current_tovar = (Tovar)this.tovarBindingSource.Current;
                nhibernate_session.Delete(current_tovar);
                nhibernate_session.Flush();
                UpdateTovarGrid();
            }
        }
    }
}