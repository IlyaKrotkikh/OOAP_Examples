using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOAP_ExtendsClass
{

    // Класс формирующий стиль кисти.
    class BrushStyle
    {
        // Поле с названием стиля.
        public String Name { get; set; }

        // Конструктор класса, в данном случае принимает название стиля.
        public BrushStyle(string Name)
        {
            this.Name = Name;
        }

        // Переопределенный метод преобразования объекта в строку.
        public override string ToString()
        {
            return this.Name;
        }
    }
}
