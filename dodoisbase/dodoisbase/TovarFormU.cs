using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using dodoisbase.Nhibernate.Entites;

namespace dodoisbase
{
    public partial class TovarFormU : Form
    {
        // Список ингредиентов для выпадающего списка
        IList<Ingr> allIngredients;
        ISession session;

        public TovarFormU()
        {
            InitializeComponent();
        }

        private void TovarFormU_Load(object sender, EventArgs e)
        {
            // Инициализируем сессию для загрузки списка ингредиентов
            var c = new Configuration();
            c.Configure();
            c.AddAssembly("dodoisbase");
            session = c.BuildSessionFactory().OpenSession();

            // Загружаем все ингредиенты, чтобы пользователь мог выбрать один из них
            LoadIngredients();
        }

        private void LoadIngredients()
        {
            try
            {
                allIngredients = session.QueryOver<Ingr>().List();
                // Привязываем список ингредиентов к ComboBox
                // Предполагается, что на форме есть comboBoxIngredients
                comboBoxIngredients.DataSource = allIngredients;
                comboBoxIngredients.DisplayMember = "Название"; // Что видим
                comboBoxIngredients.ValueMember = "ID_Ингредиента"; // Что сохраняем
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки списка ингредиентов: " + ex.Message);
            }
        }

        public void SetDataSourse(Tovar tovar)
        {
            // Привязываем объект товара к BindingSource формы
            this.tovarBindingSource.DataSource = tovar;

            // Если у товара уже есть ингредиент, устанавливаем его в ComboBox
            if (tovar.Ингредиент != null)
            {
                comboBoxIngredients.SelectedValue = tovar.Ингредиент.ID_Ингредиента;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // 1. Завершаем редактирование в BindingSource
            this.tovarBindingSource.EndEdit();

            // 2. Принудительно обновляем связь с ингредиентом из ComboBox
            Tovar currentTovar = (Tovar)this.tovarBindingSource.Current;
            currentTovar.Ингредиент = (Ingr)comboBoxIngredients.SelectedItem;

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