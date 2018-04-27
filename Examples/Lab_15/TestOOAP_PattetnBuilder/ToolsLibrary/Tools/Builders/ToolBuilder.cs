using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsLibrary.Tools.Interfaces;

namespace ToolsLibrary.Tools.Builders
{
    public abstract class ToolBuilder: IBuilder
    {
        public abstract ITools CreateTool();

        public abstract IBuilder SetColor(string ToolColor);

        public abstract IBuilder SetSize(int ToolSize);

        public abstract IBuilder SetHeight(int ToolHeight);

        public abstract IBuilder SetWidth(int ToolWidth);
        
        public abstract void Reset();
    }
}