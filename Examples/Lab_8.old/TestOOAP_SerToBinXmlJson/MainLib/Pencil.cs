using System;
using System.Collections.Generic;
using System.Text;

namespace MainLib
{
    [Serializable]
    public class Pencil : DrawTool
    {
        //[NonSerialized]
        //private OutputHandler _PencilOutputHandler;

        //public OutputHandler PencilOutputHandler
        //{
        //    get
        //    {
        //        return this._PencilOutputHandler;
        //    }
        //    set
        //    {
        //        this._PencilOutputHandler = value;
        //    }
        //}

        public Pencil(string Color, OutputHandler PencilOutputHandler)
        {
            base.Color = Color;
            //this.PencilOutputHandler = PencilOutputHandler;
        }

        public override void Draw()
        {
            //PencilOutputHandler.PrintLine("Рисуем карандашом, Цвет: " + Color);
        }
    }
}
