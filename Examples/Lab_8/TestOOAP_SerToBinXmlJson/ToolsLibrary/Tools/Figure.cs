using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsLibrary
{
    /// <summary>
    /// Абстрактный класс Figure (Фигура), наследуется от абстрактного класса DrawTool
    /// </summary>
    [Serializable]
    public abstract class Figure : DrawTool
    {
        private int _Height, _Width;

        /// <summary>
        /// Поле, содержит данные о высоте фигуры.
        /// </summary>
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
