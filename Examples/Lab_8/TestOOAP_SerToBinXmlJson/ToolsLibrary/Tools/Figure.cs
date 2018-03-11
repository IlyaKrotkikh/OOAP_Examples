using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ToolsLibrary
{
    /// <summary>
    /// Абстрактный класс Figure (Фигура), наследуется от абстрактного класса DrawTool
    /// </summary>
    [Serializable]
    [DataContract]
    public abstract class Figure : DrawTool
    {
        private int _Height, _Width;

        /// <summary>
        /// Поле, содержит данные о высоте фигуры.
        /// </summary>
        [DataMember]
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
        [DataMember]
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
