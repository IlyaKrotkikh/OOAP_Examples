using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsLibrary.Tools.Interfaces;
using ToolsLibrary.Tools.Builders;

namespace ToolsLibrary.Tools.Builders.ConcreteCreators
{
    public class SquareBuilder : ToolBuilder
    {

        protected string CurrentColor { get; set; }
        protected int CurrentHeight { get; set; }
        protected int CurrentWidth { get; set; }

        public override ITools CreateTool()
        {
            if (String.IsNullOrEmpty(CurrentColor) || CurrentHeight <= 0 || CurrentWidth <= 0)
                throw new Exception("Wrong tool param.");
            else return new Square(CurrentColor, CurrentHeight, CurrentWidth);
        }

        public override void Reset()
        {
            CurrentColor = String.Empty;
            CurrentHeight = 0;
            CurrentWidth = 0;
        }

        public override IBuilder SetColor(string ToolColor)
        {
            CurrentColor = ToolColor;
            return this;
        }

        public override IBuilder SetHeight(int ToolHeight)
        {
            CurrentHeight = ToolHeight;
            return this;
        }

        public override IBuilder SetSize(int ToolSize)
        {
            throw new NotImplementedException();
        }

        public override IBuilder SetWidth(int ToolWidth)
        {
            CurrentWidth = ToolWidth;
            return this;
        }
    }
}