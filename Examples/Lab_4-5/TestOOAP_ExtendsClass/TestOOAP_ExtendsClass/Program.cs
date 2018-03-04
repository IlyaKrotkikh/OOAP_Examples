using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOAP_ExtendsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List < BaseBrush > ListBrushes  = new List<BaseBrush>();
            ListBrushes.Add(new BaseBrush(ConsoleColor.DarkCyan, 24));
            ListBrushes.Add(new BaseBrush(ConsoleColor.DarkGreen, 30));

            StyledBrush StyledBrash1 = new StyledBrush(ConsoleColor.Magenta, 30, "Каллиграфия");
            //StyledBrash1.GetInfo();

            ListBrushes.Add(StyledBrash1);

            StyledBrash1.ShowStyle();

            foreach (BaseBrush bb in ListBrushes)
            {
                bb.GetInfo();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
