using System;
using System.Collections.Generic;
using System.Text;

namespace MainLib
{
    public class WindowsDotNetConsoleHandler : OutputHandler
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
