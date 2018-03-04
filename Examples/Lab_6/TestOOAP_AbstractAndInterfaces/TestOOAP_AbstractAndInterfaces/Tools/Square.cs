using System;
using System.Collections.Generic;
using System.Text;

namespace TestOOAP_AbstractAndInterfaces
{
    class Square : Figure, IFilled
    {
        public Square(string BorderColor, int Height, int Width)
        {
            Color = BorderColor;
            this.Height = Height;
            this.Width = Width;
        }

        public override void Draw(OutputHandler ToolsOutputHandler)
        {
            ToolsOutputHandler.PrintLine("Рисуем кистью, Цвет: " + Color + " Размер: " + Height.ToString() + "x" + Width.ToString());
        }

        void IFilled.Fill(string Color, OutputHandler ToolsOutputHandler)
        {
            ToolsOutputHandler.PrintLine("Квадрат залит цветом " + Color);
        }
    }
}
