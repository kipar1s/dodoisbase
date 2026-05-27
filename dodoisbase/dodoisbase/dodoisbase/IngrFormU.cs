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

namespace dodoisbase
{
    public partial class IngrFormU : Form
    {
        public IngrFormU()
        {
            InitializeComponent();
        }
        public void SetDataSourse(Ingr ingrs)
        {
            this.ингредиентыBindingSource.DataSource = ingrs;
        }
        public void CreateItem()
        {
            this.ингредиентыBindingSource.AddNew();
        }        
        public void LoadItem(int ID_Ингредиента)
        {
            this.ингредиентыTableAdapter.FillBy(this.dodoDS.Ингредиенты, ID_Ингредиента);
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            this.ингредиентыBindingSource.EndEdit();
            this.ингредиентыTableAdapter.Update(this.dodoDS.Ингредиенты);
        }

        private void InrgFormU_Load(object sender, EventArgs e)
        {
            
        }
    }


}
