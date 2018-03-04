using System;
using System.Collections.Generic;
using System.Text;

namespace MainLib
{
    [Serializable]
    public class Brush : DrawTool
    {
        private int _Size;
        [NonSerialized]
        private OutputHandler _BrushOutputHandler;

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

        public OutputHandler BrushOutputHandler
        {
            get
            {
                return this._BrushOutputHandler;
            }
            set
            {
                this._BrushOutputHandler = value;
            }
        }

        public Brush(string Color, int Size, OutputHandler BrushOutputHandler)
        {
            base.Color = Color;
            this.Size = Size;
            this.BrushOutputHandler = BrushOutputHandler;
        }

        public override void Draw()
        {
            BrushOutputHandler.PrintLine("Рисуем кистью, Цвет: " + Color + " Размер: " + Size.ToString());
        }
    }
}
