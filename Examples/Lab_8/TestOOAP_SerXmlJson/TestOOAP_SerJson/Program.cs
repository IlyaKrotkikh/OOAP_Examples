using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

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

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(List<Head>));

            Stream writer = new FileStream("OutJson.json", FileMode.Create, FileAccess.Write, FileShare.None);
            js.WriteObject(writer, LstHeads);
            writer.Close();

            Stream reader = new FileStream("OutJson.json", FileMode.Open, FileAccess.Read, FileShare.None);
            List<Head> DeserListHeads = js.ReadObject(reader) as List<Head>;
            reader.Close();

            foreach (Head h in DeserListHeads)
            {
                Console.WriteLine(h.ToString());
            }
            Console.ReadLine();

        }
    }
    [DataContract]
    public class Head
    {
        [DataMember]
        public Eye LeftEye { get; set; }
        [DataMember]
        public Eye RightEye { get; set; }
        [DataMember]
        public Nose MainNose { get; set; }

        public override string ToString()
        {
            return "Левый глаз: " + LeftEye.ToString() + "\n"
                + "Правый глаз: " + RightEye.ToString() + "\n"
                + "Нос: " + MainNose.ToString() + "\n";
        }
    }
    [DataContract]
    public class Eye
    {
        [DataMember]
        public string Color { get; set; }
        [DataMember]
        public double Radius { get; set; }

        public override string ToString()
        {
            return Color.ToString() + " " + Radius.ToString() + " см\n";
        }
    }
    [DataContract]
    public class Nose
    {
        [DataMember]
        public double Height { get; set; }
        [DataMember]
        public string Color { get; set; }

        public override string ToString()
        {
            return Color.ToString() + " " + Height.ToString() + " см\n";
        }
    }
}
