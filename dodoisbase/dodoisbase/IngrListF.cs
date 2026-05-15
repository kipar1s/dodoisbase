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
    public partial class IngrListF : Form
    {
        ISession nhibernate_session;
        IList<Ingr> ingrs;
        public IngrListF()
        {
            InitializeComponent();
            var c = new Configuration();
            c.Configure();
            c.AddAssembly("dodoisbase");
            nhibernate_session = c.BuildSessionFactory().OpenSession();

            //Выполним загрузки данных 
            UdateIngrGrid();
        }

        private void IngrListF_Load(object sender, EventArgs e)
        {
            this.ингредиентыTableAdapter.Fill(this.dodoDS.Ингредиенты);
            this.ингредиентыTableAdapter.Update(this.dodoDS.Ингредиенты);
        }
        void UdateIngrGrid()
        {
            //Загрузка данных из таблицы курьеры в массив объекотов 
            ingrs = nhibernate_session.QueryOver<Ingr>().List<Ingr>();
            this.ингредиентыBindingSource.DataSource = ingrs;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Ingr ingrs =MyUtiletes.Clone<Ingr>((Ingr)this.ингредиентыBindingSource.Current);
            IngrFormU ingrFormU = new IngrFormU();
            ingrFormU.SetDataSourse(ingrs);
            if(ingrFormU.ShowDialog()== DialogResult.OK) 
            {
                nhibernate_session.Merge(ingrs);
                nhibernate_session.Flush();

                UdateIngrGrid();
            }
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {         
                        
            if ((Ingr)this.ингредиентыBindingSource.Current == null) return;
            if (MessageBox.Show("Действительно хотите удалить запись?", "", MessageBoxButtons.YesNo) == DialogResult.No) return;
            
            Ingr ingrs = (Ingr)this.ингредиентыBindingSource.Current;

            nhibernate_session.Delete(ingrs);
            nhibernate_session.Flush();

            UdateIngrGrid();

        }
    }
}
