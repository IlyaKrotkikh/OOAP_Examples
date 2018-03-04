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
            List<DrawTool> ListTools = new List<DrawTool>();
            ListTools.Add(new Pencil("Синий"));
            ListTools.Add(new Brush("Красный", 12));
            ListTools.Add(new Square("Серый", 10, 10));

            foreach (DrawTool dt in ListTools)
            {
                dt.Draw(CurrentHandler);
                if (dt is IFilled)
                {
                    (dt as IFilled).Fill("Белый", CurrentHandler);
                }
                else
                {
                    CurrentHandler.PrintLine("Объект не поддерживает заливку т.к. не реализован IFilled");
                }
            }            
            Console.ReadLine();
        }
    }
}
