using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOAP_ExtendsClass
{
    // Класс определяющий "базовую кисть".
    class BaseBrush
    {
        private ConsoleColor _BrushColor;
        private int _BrushSize;

        // Публичные поля цвета и размера с обработкой геттера и сеттера.
        public ConsoleColor BrushColor
        {
            get
            {
                return _BrushColor;
            }
            set
            {
                this._BrushColor = value;
            }
        }
        public int BrushSize
        {
            get
            {
                return _BrushSize;
            }
            set
            {
                this._BrushSize = value;
            }
        }

        // Конструктор, принимает цвет и размер кисти в качестве параметров.
        public BaseBrush(ConsoleColor BrushColor, int BrushSize)
        {
            //Присваиваем полученные значения полям.
            this.BrushColor = BrushColor;
            this.BrushSize = BrushSize;
        }

        // Предоставляет данные об кисти.
        public virtual void GetInfo()
        {
            // Устанавливаем старый цвет консоли во временное хранилище.
            ConsoleColor TempColor = Console.ForegroundColor;
            // Устанавливаем цвет текста консоли для печатаемого далее текста.
            Console.ForegroundColor = this.BrushColor;

            // Печатаем текст информации о кисти.
            Console.Write("Цвет: " + BrushColor.ToString() + "; ");
            Console.WriteLine("Размер кисти: " + BrushSize.ToString());

            //Возвращаем старый цвет текста консоли.
            Console.ForegroundColor = TempColor;
        }

    }
}
