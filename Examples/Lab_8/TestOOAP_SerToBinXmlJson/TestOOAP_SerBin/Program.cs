using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ToolsLibrary;

namespace TestOOAP_SerBin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создан и инициализирован объект управляющий выводом данных.
            OutputHandler CurrentHandler = new WindowsDotNetConsoleHandler(); // выводит данные в консоль windows.

            // Создали и инициализировали список с инструментами (объектами типа "DrawTool").
            List<DrawTool> ListTools = new List<DrawTool>();
            // Добавили несколько различных инструментов унаследованных от DrawTool.
            ListTools.Add(new Pencil("Синий"));
            ListTools.Add(new Brush("Красный", 12));
            ListTools.Add(new Square("Серый", 10, 10));

            // Создан объект-"сериализатор" в бинарный формат.
            BinaryFormatter bf = new BinaryFormatter();

            // Поток, пишущий в файл.
            Stream writer = new FileStream("OutData.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            bf.Serialize(writer, ListTools); // Сериализуем объект в поток.
            writer.Close(); // Закрываем поток.

            // Выводим сообщении о сериализации в файл.
            CurrentHandler.PrintLine("ListTools сериализован в файл \"OutData.bin\"");

            // Поток, читающий из файла.
            Stream reader = new FileStream("OutData.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            List<DrawTool> DeserListTools = bf.Deserialize(reader) as List<DrawTool>; // Десериализуем из потока в объект.
            reader.Close(); // Закрываем поток.

            // Выводим сообщении о десериализации из файла.
            CurrentHandler.PrintLine("Десериализован файл \"OutData.bin\" в DeserListTools");


            // Производим имитацию рисования каждым инструментом.
            foreach (DrawTool dt in ListTools)
            {
                dt.Draw(CurrentHandler); // Рисуем и обрабатываем вывод контроллером "CurrentHandler".
                if (dt is IFilled) // Если объект можно представить как объект типа IFilleв...
                {
                    (dt as IFilled).Fill("Белый", CurrentHandler); // То указываем, что данный объект типа IFilled и вызываем метод заливки.
                }
                else
                {
                    CurrentHandler.PrintLine("Объект не поддерживает заливку т.к. не реализован IFilled"); // В противном случае выводим данную строку.
                }
            }

            // Блокируем завершение программы пока не введем строку.
            Console.ReadLine();
        }
    }
}
