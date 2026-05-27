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

namespace dodoisbase
{
    public partial class CurierList : Form
    {
        ISession nhibernate_session;
        IList<Curier> curiers;
        public CurierList()
        {
            InitializeComponent();
        }

        private void CurierList_Load(object sender, EventArgs e)
        {
            var c = new Configuration();
            c.Configure();
            c.AddAssembly("dodoisbase");
            nhibernate_session = c.BuildSessionFactory().OpenSession();

            //Выполним загрузки данных 
            UdateCurierGrid();
        }

        void UdateCurierGrid()
        {
            //Загрузка данных из таблицы курьеры в массив объекотов 
            curiers = nhibernate_session.QueryOver<Curier>().List<Curier>();
            this.curierBindingSource.DataSource = curiers;
        }

        private void tsb_Create_Click(object sender, EventArgs e)
        {
            Curier curier = new Curier();
            CurierFormUnit curier_form_unit = new CurierFormUnit();
            curier_form_unit.SetDataSourse(curier);
            if (curier_form_unit.ShowDialog() == DialogResult.OK)
            {
                nhibernate_session.Save(curier);
                nhibernate_session.Flush();

                //Обнов данных
                UdateCurierGrid();
            }
        }

        private void tsb_Edit_Click(object sender, EventArgs e)
        {
            Curier curier = MyUtiletes.Clone<Curier>((Curier)this.curierBindingSource.Current);
            CurierFormUnit curier_form_unit = new CurierFormUnit();
            curier_form_unit.SetDataSourse(curier);
            if (curier_form_unit.ShowDialog() == DialogResult.OK)
            {
                nhibernate_session.Merge(curier);
                nhibernate_session.Flush();

                //Обнов данных
                UdateCurierGrid();
            }
        }       
        private void tsb_Delite_Click(object sender, EventArgs e)
        {

        }
    }
}
