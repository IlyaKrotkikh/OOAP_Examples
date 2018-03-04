using System;
using System.Collections.Generic;
using System.Text;

namespace MainLib
{
    public abstract class OutputHandler
    {
        public abstract void PrintLine(string Text);

        public abstract void Print(string Text);
    }
}
