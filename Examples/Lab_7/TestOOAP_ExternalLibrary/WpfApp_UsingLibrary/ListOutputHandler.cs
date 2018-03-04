using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsLibrary;

namespace WpfApp_UsingLibrary
{
    class ListOutputHandler : OutputHandler
    {
        public ObservableCollection<string> LstOutputLog { get; set; }

        public ListOutputHandler()
        {
            LstOutputLog = new ObservableCollection<string>();
        }

        public override void Print(string Text)
        {
            LstOutputLog[LstOutputLog.Count - 1] = LstOutputLog.Last() + Text;
        }

        public override void PrintLine(string Text)
        {
            LstOutputLog.Add(Text);
        }
    }
}
