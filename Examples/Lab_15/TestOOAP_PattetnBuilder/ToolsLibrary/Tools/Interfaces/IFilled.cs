using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsLibrary
{
    /// <summary>
    /// Интерфейс. Требует от реализующего класса реализацию метода Fill(string, OutputHandler)
    /// </summary>
    public interface IFilled
    {
        /// <summary>
        /// Предполагает реализацию заливки фигуры цветом.
        /// </summary>
        /// <param name="Color">Цвет заливки.</param>
        /// <param name="ToolsOutputHandler">Контроллер вывода данных.</param>
        void Fill(string Color, OutputHandler ToolsOutputHandler);
    }
}
