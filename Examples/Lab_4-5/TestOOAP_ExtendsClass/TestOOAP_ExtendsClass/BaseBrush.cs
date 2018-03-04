using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOAP_ExtendsClass
{
    class BaseBrush
    {
        private ConsoleColor _BrushColor;
        private int _BrushSize;
        public ConsoleColor BrushColor
        {
            get {
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

        public BaseBrush(ConsoleColor BrushColor, int BrushSize)
        {
            this.BrushColor = BrushColor;
            this.BrushSize = BrushSize;
        }

        public virtual void GetInfo()
        {
            ConsoleColor TempColor = Console.ForegroundColor;
            Console.ForegroundColor = this.BrushColor;

            Console.Write("Цвет: " + BrushColor.ToString() + "; ");
            Console.WriteLine("Размер кисти: " + BrushSize.ToString());
            Console.ForegroundColor = TempColor;
        }

    }
}
