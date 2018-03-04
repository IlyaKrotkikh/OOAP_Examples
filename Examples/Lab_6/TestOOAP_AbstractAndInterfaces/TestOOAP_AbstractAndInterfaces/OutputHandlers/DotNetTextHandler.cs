using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TestOOAP_AbstractAndInterfaces
{
    /// <summary>
    /// Выводит текст в текстовый файл.
    /// </summary>
    public class DotNetTextHandler : OutputHandler
    {
        // Поток, который пишет в файл.
        private Stream CurrentFileStram { get; set; }
        // "Писатель" в поток.
        private StreamWriter OutputText { get; set; }

        /// <summary>
        /// Конструктор класса DotNetTextHandler, инициализирует новый экземпляр данного класса.
        /// </summary>
        /// <param name="FileName">Имя файла в который будут выводиться данные.</param>
        public DotNetTextHandler(string FileName)
        {
            // Инициализация потока и писателя.
            CurrentFileStram = new FileStream(FileName, FileMode.Append, FileAccess.Write);
            OutputText = new StreamWriter(CurrentFileStram);
            OutputText.AutoFlush = true;
        }

        /// <summary>
        /// Переопределенный от родителя метод. Печатает строку без символа окончания строки.
        /// </summary>
        /// <param name="Text">Печатаемый текст.</param>
        public override void Print(string Text)
        {
            // Пишем в поток без символа окончания строки.
            OutputText.Write(Text);
        }

        /// <summary>
        /// Переопределенный от родителя метод. Печатает строку с символом окончания строки.
        /// </summary>
        /// <param name="Text">Печатаемый текст.</param>
        public override void PrintLine(string Text)
        {
            // Пишем в поток с символом окончания строки.
            OutputText.WriteLine(Text);
        }
    }
}
