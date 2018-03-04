using System;
using System.Collections.Generic;
using System.Text;

namespace TestOOAP_AbstractAndInterfaces
{
    class Pencil : DrawTool
    {
        private OutputHandler _PencilOutputHandler;

        public OutputHandler PencilOutputHandler
        {
            get
            {
                return this._PencilOutputHandler;
            }
            set
            {
                this._PencilOutputHandler = value;
            }
        }

        public Pencil(string Color, OutputHandler PencilOutputHandler)
        {
            base.Color = Color;
            this.PencilOutputHandler = PencilOutputHandler;
        }

        public override void Draw()
        {
            PencilOutputHandler.PrintLine("Рисуем карандашом, Цвет: " + Color);
        }
    }
}
