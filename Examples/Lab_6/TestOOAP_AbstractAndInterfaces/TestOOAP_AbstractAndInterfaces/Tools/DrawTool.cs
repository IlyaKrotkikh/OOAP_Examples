using System;
using System.Collections.Generic;
using System.Text;

namespace TestOOAP_AbstractAndInterfaces
{
    abstract class DrawTool
    {
        private string _Color;

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

        public abstract void Draw(OutputHandler ToolsOutputHandler);
    }
}
