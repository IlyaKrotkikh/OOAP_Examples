using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MainLib
{
    public class DotNetTextHandler : OutputHandler
    {
        private Stream CurrentFileStram { get; set; }
        private StreamWriter OutputText {get;set;}

        public DotNetTextHandler(string FileName)
        {
            CurrentFileStram = new FileStream(FileName, FileMode.Append,FileAccess.Write);
            OutputText = new StreamWriter(CurrentFileStram);
            OutputText.AutoFlush = true;
        }

        public override void Print(string Text)
        {
             OutputText.Write(Text);

        }

        public override void PrintLine(string Text)
        {
            OutputText.WriteLine(Text);
        }
    }
}
