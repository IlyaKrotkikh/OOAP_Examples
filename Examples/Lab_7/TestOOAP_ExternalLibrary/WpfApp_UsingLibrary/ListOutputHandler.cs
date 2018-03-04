using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsLibrary;

namespace WpfApp_UsingLibrary
{       
    /// <summary>
    /// Выводит текст в коллекцию ObservableCollection.
    /// </summary>
    class ListOutputHandler : OutputHandler
    {
        /// <summary>
        /// Коллекция хранящая данные.
        /// </summary>
        public ObservableCollection<string> LstOutputLog { get; set; }

        /// <summary>
        /// Конструктор класса, создает новый экземпляр класса ListOutputHandler.
        /// </summary>
        public ListOutputHandler()
        {
            LstOutputLog = new ObservableCollection<string>();
        }

        /// <summary>
        /// Реализация абстрактного метода Print. Печатает текст в текущий элемент коллекции.
        /// </summary>
        /// <param name="Text">Текст для вывода.</param>
        public override void Print(string Text)
        {
            LstOutputLog[LstOutputLog.Count - 1] = LstOutputLog.Last() + Text;
        }

        /// <summary>
        /// Реализация абстрактного метода Print. Печатает текст в новый элемент коллекции.
        /// </summary>
        /// <param name="Text">Текст для вывода.</param>
        public override void PrintLine(string Text)
        {
            LstOutputLog.Add(Text);
        }
    }
}
