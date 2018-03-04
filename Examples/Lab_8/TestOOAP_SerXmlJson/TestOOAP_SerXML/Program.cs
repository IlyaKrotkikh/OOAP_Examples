using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using MainLib;

namespace TestOOAP_SerXML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Head> LstHeads = new List<Head>();
            LstHeads.Add(new Head
            {
                LeftEye = new Eye
                {
                    Color = "Голубой",
                    Radius = 1.5
                },
                RightEye = new Eye
                {
                    Color = "Голубой",
                    Radius = 1.5
                },
                MainNose = new Nose
                {
                    Height = 6,
                    Color = "Синий"
                }
            });
            LstHeads.Add(new Head
            {
                LeftEye = new Eye
                {
                    Color = "Карий",
                    Radius = 1.5
                },
                RightEye = new Eye
                {
                    Color = "Карий",
                    Radius = 2
                },
                MainNose = new Nose
                {
                    Height = 7,
                    Color = "Красный"
                }
            });

            XmlSerializer xs = new XmlSerializer(typeof (List< Head >));
            
            Stream writer = new FileStream("OutXml.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            xs.Serialize(writer, LstHeads);
            writer.Close();

            Stream reader = new FileStream("OutXml.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            List<Head> DeserListHeads = xs.Deserialize(reader) as List<Head>;
            reader.Close();

            foreach (Head h in DeserListHeads)
            {
                Console.WriteLine(h.ToString());
            }
            Console.ReadLine();

        }
    }

    public class Head
    {
        public Eye LeftEye { get; set; }
        public Eye RightEye { get; set; }
        public Nose MainNose { get; set; }

        public override string ToString()
        {
            return "Левый глаз: " + LeftEye.ToString() + "\n"
                + "Правый глаз: " + RightEye.ToString() + "\n"
                + "Нос: " + MainNose.ToString() + "\n";
        }
    }
    public class Eye
    {
        public string Color { get; set; }
        public double Radius { get; set; }
        public override string ToString()
        {
            return Color.ToString() + " " + Radius.ToString() + " см\n";
        }
    }
    public class Nose
    {
        public double Height { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return Color.ToString() + " " + Height.ToString() + " см\n";
        }
    }
}
