using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsLibrary
{
    /// <summary>
    /// Абстрактный класс. Представляет собой контроллер управляющий выводом данных.
    /// </summary>
    public abstract class OutputHandler
    {
        /// <summary>
        /// Абстрактный метод (реализация отсутствует). Печатает строку без символа окончания строки.
        /// </summary>
        /// <param name="Text">Текст для печати.</param>
        public abstract void PrintLine(string Text);

        /// <summary>
        /// Абстрактный метод (реализация отсутствует). Печатает строку с символом окончания строки.
        /// </summary>
        /// <param name="Text">Текст для печати.</param>
        public abstract void Print(string Text);
    }
}
