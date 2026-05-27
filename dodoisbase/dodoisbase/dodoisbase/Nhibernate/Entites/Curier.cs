using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodoisbase.Nhibernate.Entites
{
    public class Curier
    {
        
        public virtual int ID_Курьера { get; set; }
        public virtual Personal Сотрудник { get; set; }
        public virtual int IDСотрудника {
            get {
                return Сотрудник.ID_Сотрудника;
            }
            set {
                Сотрудник.ID_Сотрудника = value;
            }
        }

        public virtual int Номер_ВУ { get; set; }   
        public virtual string Телефон { get; set; }      
        public virtual string Машина { get; set; } 
        public virtual string Номер_машины { get; set; }
    }
}
