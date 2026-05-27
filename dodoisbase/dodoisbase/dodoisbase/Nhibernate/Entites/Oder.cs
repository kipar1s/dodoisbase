using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodoisbase.Nhibernate.Entites
{
    public class Oder
    {
        public virtual int ID_Заказа { get; set; }
        public virtual int ID_Клиента { get; set; }
        public virtual DateTime Дата_заказа { get; set; }
        public virtual int Сумма { get; set; }
        public virtual string  Статус { get; set; }
        public virtual string  Адресс_доставки { get; set; }
    }
}
