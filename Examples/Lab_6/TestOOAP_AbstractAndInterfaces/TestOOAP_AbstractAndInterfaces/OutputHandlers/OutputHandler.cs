using System;
using System.Collections.Generic;
using System.Text;

namespace TestOOAP_AbstractAndInterfaces
{
    public abstract class OutputHandler
    {
        public abstract void PrintLine(string Text);

        public abstract void Print(string Text);
    }
}
