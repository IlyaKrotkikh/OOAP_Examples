using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary.Tools.Interfaces
{
    public interface IBuilder
    {
        ITools CreateTool();
        IBuilder SetColor(string ToolColor);
        IBuilder SetSize(int ToolSize);
        IBuilder SetHeight(int ToolHeight);
        IBuilder SetWidth(int ToolWidth);
        void Reset();
    }
}
