using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ToolsLibrary
{
    /// <summary>
    /// Кисть. унаследована от абстрактного класса DrawTool.
    /// </summary>
    [Serializable]
    [DataContract]
    public class Brush : DrawTool
    {
        private int _Size;

        /// <summary>
        /// Размер пера.
        /// </summary>
        [DataMember]
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
