using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOAP_ExtendsClass
{
    // Класс определяющий стилизованную кисть, унаследован от базовой кисти.
    class StyledBrush: BaseBrush
    {
        // Используем композицию.
        // _BrushStyle создается и уничтожается вместе с основным классом, который использует этот объект.
        private BrushStyle _BrushStyle;
        
        // Открытое поле для взаимодействия с CurretBrushStyle.
        public BrushStyle CurretBrushStyle
        {
            get
            {
                return this._BrushStyle;
            }
            set
            {
                this._BrushStyle = value;
            }
        }

        // Конструктор для стилизованной кисти принимает все параметры класса-родителя + имя стиля.
        // Синтаксис ": base(BrushColor, BrushSize)" Переопределяет параметры BrushColor и BrushSize в конструктор класса-родителя.
        public StyledBrush(ConsoleColor BrushColor, int BrushSize, string StyleName) : base(BrushColor, BrushSize)
        {
            this.CurretBrushStyle = new BrushStyle(StyleName);
        }

        // Переопределенный метод GetInfo. Возвращает вывод базового метода + дописывает в консоль свою информацию о стиле.
        public override void GetInfo()
        {
            base.GetInfo(); // Вызов метода из родительского класса.
            Console.WriteLine("Стиль кисти: " + CurretBrushStyle);
        }

        // Метод показывает текущий стиль кисти.
        public void ShowStyle()
        {
            Console.WriteLine("Стиль кисти: " + CurretBrushStyle);
        }
    }
}
