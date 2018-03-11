using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace ToolsLibrary
{
    /// <summary>
    /// Кисть. унаследована от абстрактного класса DrawTool.
    /// </summary>
    [Serializable] // Указывает, что класс может быть сериализован.  (Необходим для сериализации в Бинарный формат файла)
    [DataContract] // Указывает, что этот элемент является частью контракта данных и сериализуется DataContractSerializer. (Необходим для сериализации в Json)
    public class Brush : DrawTool
    {
        private int _Size;

        /// <summary>
        /// Размер пера.
        /// </summary>
        [DataMember] // Указываем, что поле "Size" должно сериализоваться. (Необходим для сериализации в Json)
        [XmlAttribute]
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

        /// <summary>
        /// Конструктор класса Brush, инициализирует новый экземпляр объекта Brush
        /// </summary>
        /// <param name="Color">Цвет кисти.</param>
        /// <param name="Size">Размер кисти.</param>
        public Brush(string Color, int Size)
        {
            base.Color = Color;
            this.Size = Size;
        }

        /// <summary>
        /// Конструктор класса Brush без параметров.
        /// (Необходим для десериализации из Xml)
        /// </summary>
        internal Brush() { }

        /// <summary>
        /// Реализация метода Draw. Эмитируется рисование. 
        /// </summary>
        /// <param name="ToolsOutputHandler">Контроллер вывода данных</param>
        public override void Draw(OutputHandler ToolsOutputHandler)
        {
            // По средствам данного контроллера происходит отвязка данного класса от конкретной реализации вывода данных.
            ToolsOutputHandler.PrintLine("Рисуем кистью, Цвет: " + Color + " Размер: " + Size.ToString());
        }
    }
}
