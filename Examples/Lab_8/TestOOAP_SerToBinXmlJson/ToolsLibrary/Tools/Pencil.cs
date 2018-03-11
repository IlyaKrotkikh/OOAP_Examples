using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ToolsLibrary
{
    /// <summary>
    /// Класс Pencil (Карандаш). Реализует абстрактный класс DrawTool
    /// </summary>
    [Serializable] // Указывает, что класс может быть сериализован.  (Необходим для сериализации в Бинарный формат файла)
    [DataContract] // Указывает, что этот элемент является частью контракта данных и сериализуется DataContractSerializer. (Необходим для сериализации в Json)
    public class Pencil : DrawTool
    {
        /// <summary>
        /// Конструктор класса Pencil, инициализирует новый экземпляр данного класса.
        /// </summary>
        /// <param name="Color">Цвет карандаша.</param>
        public Pencil(string Color)
        {
            // base - Обращаемся к полям родительского класса.
            base.Color = Color;
        }

        /// <summary>
        /// Конструктор класса Pencil без параметров.
        /// (Необходим для десериализации из Xml)
        /// </summary>
        internal Pencil()
        { }

        /// <summary>
        /// Реализация метода Draw абстрактного класса DrawTool. Имитирует рисование карандашом.
        /// </summary>
        /// <param name="ToolsOutputHandler">Контроллер вывода данных.</param>
        public override void Draw(OutputHandler ToolsOutputHandler)
        {
            // По средствам данного контроллера происходит отвязка данного класса от конкретной реализации вывода данных.
            ToolsOutputHandler.PrintLine("Рисуем карандашом, Цвет: " + Color);
        }
    }
}
