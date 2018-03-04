using System;
using System.Collections.Generic;
using System.Text;

namespace TestOOAP_AbstractAndInterfaces
{
    abstract class Figure: DrawTool
    {
        private int _Height, _Width;

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
