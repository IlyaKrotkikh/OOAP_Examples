using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary.Tools.Interfaces.Creators
{
    public abstract class ToolsCreator
    {
        public abstract ITools CreateTool();
    }
}