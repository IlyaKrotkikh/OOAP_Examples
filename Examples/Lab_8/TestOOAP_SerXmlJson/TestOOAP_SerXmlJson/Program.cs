using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainLib;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TestOOAP_SerXmlJson
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputHandler ConsoleHandler  = new WindowsDotNetConsoleHandler();
            List<DrawTool> ListTools = new List<DrawTool>();
            ListTools.Add(new Pencil("Синий", ConsoleHandler));
            ListTools.Add(new Brush("Красный", 12, ConsoleHandler));
            ListTools.Add(new Square("Серый", 10, 10, ConsoleHandler));

            BinaryFormatter bf = new BinaryFormatter();
            Stream writer = new FileStream("OutData.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            bf.Serialize(writer, ListTools);
            writer.Close();

            Stream reader = new FileStream("OutData.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            List<DrawTool> DeserListTools = bf.Deserialize(reader) as List<DrawTool>;
            reader.Close();



            foreach (DrawTool dt in DeserListTools)
            {
                if (dt is Pencil)
                {
                    //(dt as Pencil).PencilOutputHandler = ConsoleHandler;
                }
                if (dt is Brush)
                {
                    (dt as Brush).BrushOutputHandler = ConsoleHandler;
                }
                if (dt is Square)
                {
                    (dt as Square).SquareOutputHandler = ConsoleHandler;
                }
                dt.Draw();

                if (dt is IFilled)
                {
                    
                    (dt as IFilled).Fill("Белый");
                }
                else
                {
                    ConsoleHandler.PrintLine("Объект не поддерживает заливку т.к. не реализован IFilled");
                }
            }
            Console.ReadLine();

        }
    }
}
