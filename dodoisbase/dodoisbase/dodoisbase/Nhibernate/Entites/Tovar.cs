using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodoisbase.Nhibernate.Entites
{
    public class Tovar
    {
        public virtual int ID_Товара { get; set; }
        private Ingr _ингредиент;
        public virtual Ingr Ингредиент
        {
            get => _ингредиент ?? (_ингредиент = new Ingr()); // Если null, создаем новый
            set => _ингредиент = value;
        }
        public virtual int IDИнгредиента
        {
            get
            {
                // Проверяем: если объект Ингредиент пустой, возвращаем 0, а не падаем с ошибкой
                return Ингредиент != null ? Ингредиент.ID_Ингредиента : 0;
            }
            set
            {
                // Если ингредиента еще нет, создаем "пустой" объект, чтобы не было ошибки при присваивании
                if (Ингредиент == null) Ингредиент = new Ingr();
                Ингредиент.ID_Ингредиента = value;
            }
        }

        public virtual string Название { get; set; }
        public virtual int Цена { get; set; }
        public virtual string Категория { get; set; }
        public virtual int Калорийность { get; set; }
    }
}