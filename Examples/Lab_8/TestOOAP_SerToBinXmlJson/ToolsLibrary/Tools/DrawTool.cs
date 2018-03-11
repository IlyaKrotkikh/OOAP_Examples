using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace ToolsLibrary
{
    /// <summary>
    /// Абстрактный класс. Представляет инструмент для рисования.
    /// </summary>
    [Serializable] // Указывает, что класс может быть сериализован.  (Необходим для сериализации в Бинарный формат файла)
    [DataContract] // Указывает, что этот элемент является частью контракта данных и сериализуется DataContractSerializer. (Необходим для сериализации в Json)
    public abstract class DrawTool
    {
        private string _Color;

        /// <summary>
        /// Цвет, которым рисует инструмент.
        /// </summary>
        [DataMember] // Указываем, что поле "Color" должно сериализоваться. (Необходим для сериализации в Json)
        [XmlAttribute]
        public string Color
        {
            get
            {
                if (_Color == "")
                    return "белый";
                else return this._Color;
            }
            set
            {
                try
                {
                    this._Color = value;
                }
                catch
                {
                    this._Color = "белый";
                }
            }
        }

        /// <summary>
        /// Абстрактный метод (реализация отсутствует). Представляет метод, позволяющий рисовать инструментом.
        /// </summary>
        /// <param name="ToolsOutputHandler">Контроллер вывода данных.</param>
        public abstract void Draw(OutputHandler ToolsOutputHandler);
    }
}
