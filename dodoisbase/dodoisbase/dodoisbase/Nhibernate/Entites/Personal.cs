using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodoisbase.Nhibernate.Entites
{
    public class Personal
    {

        public virtual int ID_Сотрудника { get; set; }
        public virtual string ФИО { get; set; }
        public virtual int Стаж { get; set; }
        public virtual int ID_Категории { get; set; }
        public virtual IList<Oder> Oders { get; set; }

    }
}
