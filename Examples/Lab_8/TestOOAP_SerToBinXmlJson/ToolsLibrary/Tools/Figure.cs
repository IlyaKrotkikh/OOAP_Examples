using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace ToolsLibrary
{
    /// <summary>
    /// Абстрактный класс Figure (Фигура), наследуется от абстрактного класса DrawTool
    /// </summary>
    [Serializable] // Указывает, что класс может быть сериализован.  (Необходим для сериализации в Бинарный формат файла)
    [DataContract] // Указывает, что этот элемент является частью контракта данных и сериализуется DataContractSerializer. (Необходим для сериализации в Json)
    public abstract class Figure : DrawTool
    {
        private int _Height, _Width;

        /// <summary>
        /// Поле, содержит данные о высоте фигуры.
        /// </summary>
        [DataMember] // Указываем, что поле "Height" должно сериализоваться. (Необходим для сериализации в Json)
        public int Height
        {
            get
            {
                return this._Height;
            }
            set
            {
                this._Height = value;
            }
        }
        
        /// <summary>
        /// Поле, содержит информацию о ширине фигуры.
        /// </summary>
        [DataMember] // Указываем, что поле "Width" должно сериализоваться. (Необходим для сериализации в Json)
        public int Width
        {
            get
            {
                return this._Width;
            }
            set
            {
                this._Width = value;
            }
        }
    }
}
