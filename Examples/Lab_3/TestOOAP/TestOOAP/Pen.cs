using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOAP {
    class Pen {
        private ConsoleColor _Color;
        // Поля (или атрибуты) класса
        public ConsoleColor Color {
            get {
                return _Color;
            }
            set {
                try {
                    _Color = value;
                }
                catch {
                    _Color = ConsoleColor.White;
                }
            }
        }
        public int InkFuel {
            get; set;
        }
        public int ID {
            get;set;
        }

        //Конструктор класа
        public Pen(int ID, int InkFuel) // Конструктор с цветом по умолчанию
        {
            this.ID = ID;
            this.Color = ConsoleColor.Blue;
            this.InkFuel = InkFuel;
        }
        public Pen(int ID, ConsoleColor Color, int InkFuel) // Конструктор с возможностью установки цвета.
        {
            this.ID = ID;
            this.Color = Color;
            this.InkFuel = InkFuel;
        }

        // Публичный "интерфейс" управления.
        public void WriteText(String TextStr) {
            _WriteText(TextStr);
        }

        // Приватная реализация логики ручки.
        private void _WriteText(string TextStr) {
            ConsoleColor TempColor = Console.ForegroundColor;
            Console.Write(ID.ToString() + ": ");
            Console.ForegroundColor = this.Color;
            if (TextStr.Length < InkFuel) {
                Console.Write(TextStr);
                InkFuel -= TextStr.Length;
            }
            else {
                Console.Write(TextStr.Substring(0, InkFuel));
                InkFuel = 0;
            }
            Console.WriteLine();
            Console.ForegroundColor = TempColor;
        }

        // Деструктор объекта
        ~Pen() {
            Console.WriteLine("Pen with ID:" + this.ID.ToString() + " deleted");
        }
    }
}
