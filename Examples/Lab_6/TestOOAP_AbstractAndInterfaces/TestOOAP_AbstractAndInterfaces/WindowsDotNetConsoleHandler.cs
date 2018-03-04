using System;
using System.Collections.Generic;
using System.Text;

namespace TestOOAP_AbstractAndInterfaces
{
    class WindowsDotNetConsoleHandler : OutputHandler
    {
        public override void Print(string Text)
        {
            Console.Write(Text);
        }

        public override void PrintLine(string Text)
        {
            Console.WriteLine(Text);
        }
    }
}
