using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsLibrary.Tools.Interfaces;
using ToolsLibrary.Tools.Builders;

namespace ToolsLibrary.Tools.Builders.ConcreteCreators
{
    public class BrushBuilder : ToolBuilder
    {
        protected int CurrentSize { get; set;}
        protected string CurrentColor { get; set; }

        
        public override ITools CreateTool()
        {
            if (String.IsNullOrEmpty(CurrentColor) || CurrentSize <= 0)
                throw new Exception("Wrong tool param.");
            else return new Brush(CurrentColor, CurrentSize);             
        }

        public override void Reset()
        {
            CurrentSize = 0;
        }

        public override IBuilder SetColor(string ToolColor)
        {
            CurrentColor = ToolColor;
            return this;
        }

        public override IBuilder SetSize(int ToolSize)
        {
            CurrentSize = ToolSize;
            return this;
        }

        public override IBuilder SetHeight(int ToolHeight)
        {
            throw new NotImplementedException();
        }

        public override IBuilder SetWidth(int ToolWidth)
        {
            throw new NotImplementedException();
        }
    }
}
