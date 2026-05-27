using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodoisbase.Nhibernate.Entites
{
    public class Ingr
    {
        public virtual int ID_Ингредиента { get; set; }
        public virtual string Название { get; set; }
        public virtual int Цена_за_ед { get; set; }
        public virtual DateTime Срок_годности { get; set; }

        public virtual int Количество_на_складе { get; set; }
    }
}
