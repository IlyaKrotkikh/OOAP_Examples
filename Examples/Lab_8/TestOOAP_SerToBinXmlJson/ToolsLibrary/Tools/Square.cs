using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsLibrary
{
    /// <summary>
    /// Класс Square (Квадрат). Реализует абстрактный класс Figure и интерфейс IFilled.
    /// </summary>
    [Serializable]
    public class Square : Figure, IFilled
    {
        /// <summary>
        /// Конструктор класса Square, инициализирует новый экземпляр данного класса.
        /// </summary>
        /// <param name="BorderColor">Цвет границы квадрата.</param>
        /// <param name="Height">Высота квадрата.</param>
        /// <param name="Width">Ширина квадрата.</param>
        public Square(string BorderColor, int Height, int Width)
        {
            Color = BorderColor;
            this.Height = Height;
            this.Width = Width;
        }

        /// <summary>
        /// Реализация метода Draw из абстрактного класса DrawTool. Имитирует рисование квадрата.
        /// </summary>
        /// <param name="ToolsOutputHandler">Контроллер вывода данных.</param>
        public override void Draw(OutputHandler ToolsOutputHandler)
        {
            // По средствам данного контроллера происходит отвязка данного класса от конкретной реализации вывода данных.
            ToolsOutputHandler.PrintLine("Рисуем кистью, Цвет: " + Color + " Размер: " + Height.ToString() + "x" + Width.ToString());
        }

        /// <summary>
        /// Реализует метод Fill от интерфейса IFilled. Имитирует заливку квадрата.
        /// </summary>
        /// <param name="Color"></param>
        /// <param name="ToolsOutputHandler"></param>
        void IFilled.Fill(string Color, OutputHandler ToolsOutputHandler)
        {
            // По средствам данного контроллера происходит отвязка данного класса от конкретной реализации вывода данных.
            ToolsOutputHandler.PrintLine("Квадрат залит цветом " + Color);
        }
    }
}
