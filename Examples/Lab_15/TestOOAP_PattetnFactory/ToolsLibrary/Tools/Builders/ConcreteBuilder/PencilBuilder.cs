using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsLibrary.Tools.Interfaces;
using ToolsLibrary.Tools.Builders;

namespace ToolsLibrary.Tools.Builders.ConcreteCreators
{
    public class PencilBuilder: ToolBuilder
    {
        protected string CurrentColor { get; set; }
        public override ITools CreateTool()
        {
            if (String.IsNullOrEmpty(CurrentColor))
                throw new Exception("Wrong tool param.");
            else return new Pencil(CurrentColor);
        }

        public override void Reset()
        {
            CurrentColor = String.Empty;
        }

        public override IBuilder SetColor(string ToolColor)
        {
            CurrentColor = ToolColor;
            return this;
        }
        public override IBuilder SetSize(int ToolSize)
        {
            throw new NotImplementedException();
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
