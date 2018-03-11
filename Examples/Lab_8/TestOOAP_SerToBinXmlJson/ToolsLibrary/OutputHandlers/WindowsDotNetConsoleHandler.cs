using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsLibrary
{
    /// <summary>
    /// Выводит текст в консоль Windows.
    /// </summary>
    public class WindowsDotNetConsoleHandler : OutputHandler
    {
        /// <summary>
        /// Переопределенный от родителя метод. Печатает строку без символа окончания строки.
        /// </summary>
        /// <param name="Text">Печатаемый текст.</param>
        public override void Print(string Text)
        {
            Console.Write(Text);
        }

        /// <summary>
        /// Переопределенный от родителя метод. Печатает строку с символом окончания строки.
        /// </summary>
        /// <param name="Text">Печатаемый текст.</param>
        public override void PrintLine(string Text)
        {
            Console.WriteLine(Text);
        }
    }
}
