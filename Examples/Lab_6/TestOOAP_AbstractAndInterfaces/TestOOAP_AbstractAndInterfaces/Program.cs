using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestOOAP_AbstractAndInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // ! Ошибка, нельзя создать экземпляр абстрактного класса.
            //Brush b = new Brush();
            OutputHandler CurrentHandler = new WindowsDotNetConsoleHandler();
            DotNetTextHandler TextFileHandler = new DotNetTextHandler("OutText.txt");
            List<DrawTool> ListTools = new List<DrawTool>();
            ListTools.Add(new Pencil("Синий", TextFileHandler));
            ListTools.Add(new Brush("Красный", 12, TextFileHandler));
            ListTools.Add(new Square("Серый", 10, 10, TextFileHandler));

            foreach (DrawTool dt in ListTools)
            {
                dt.Draw();
                if (dt is IFilled)
                {
                    (dt as IFilled).Fill("Белый");
                }
                else
                {
                    TextFileHandler.PrintLine("Объект не поддерживает заливку т.к. не реализован IFilled");
                }
            }            
            Console.ReadLine();
        }
    }
}
