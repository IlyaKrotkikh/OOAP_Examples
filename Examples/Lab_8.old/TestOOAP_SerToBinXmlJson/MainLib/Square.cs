using System;
using System.Collections.Generic;
using System.Text;

namespace MainLib
{
    [Serializable]
    public class Square : Figure, IFilled
    {
        [NonSerialized]
        private OutputHandler _SquareOutputHandler;
       
        public OutputHandler SquareOutputHandler
        {
            get
            {
                return this._SquareOutputHandler;
            }
            set
            {
                this._SquareOutputHandler = value;
            }
        }

        public Square(string BorderColor, int Height, int Width, OutputHandler SquareOutputHandler)
        {
            Color = BorderColor;
            this.Height = Height;
            this.Width = Width;
            this.SquareOutputHandler = SquareOutputHandler;
        }

        public override void Draw()
        {
            SquareOutputHandler.PrintLine("Рисуем кистью, Цвет: " + Color + " Размер: " + Height.ToString() + "x" + Width.ToString());
        }

        void IFilled.Fill(string Color)
        {
            SquareOutputHandler.PrintLine("Квадрат залит цветом " + Color);
        }
    }
}
