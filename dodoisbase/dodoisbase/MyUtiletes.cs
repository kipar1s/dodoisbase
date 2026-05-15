using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace dodoisbase
{
    public class MyUtiletes
    {
        //Создание клонов объекта 
        public static T Clone<T>(T source)
        {
            var json = JsonSerializer.Serialize(source);
            return JsonSerializer.Deserialize<T>(json);
        }

    }
}
