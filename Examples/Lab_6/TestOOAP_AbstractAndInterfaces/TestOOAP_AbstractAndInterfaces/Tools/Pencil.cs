using System;
using System.Collections.Generic;
using System.Text;

namespace TestOOAP_AbstractAndInterfaces
{
    class Pencil : DrawTool
    {
        public Pencil(string Color)
        {
            base.Color = Color;
        }

        public override void Draw(OutputHandler ToolsOutputHandler)
        {
            ToolsOutputHandler.PrintLine("Рисуем карандашом, Цвет: " + Color);
        }
    }
}
