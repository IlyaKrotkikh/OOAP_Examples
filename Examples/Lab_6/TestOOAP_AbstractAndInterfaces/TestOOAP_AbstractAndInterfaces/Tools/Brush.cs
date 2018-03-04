using System;
using System.Collections.Generic;
using System.Text;

namespace TestOOAP_AbstractAndInterfaces
{
    class Brush : DrawTool
    {
        private int _Size;

        public int Size
        {
            get
            {
                return this._Size;
            }

            set
            {
                this._Size = value;
            }
        }

        public Brush(string Color, int Size)
        {
            base.Color = Color;
            this.Size = Size;
        }

        public override void Draw(OutputHandler ToolsOutputHandler)
        {
            ToolsOutputHandler.PrintLine("Рисуем кистью, Цвет: " + Color + " Размер: " + Size.ToString());
        }
    }
}
