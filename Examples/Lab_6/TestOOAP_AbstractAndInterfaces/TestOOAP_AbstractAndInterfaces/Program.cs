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

            // Создан и инициализирован объект управляющий выводом данных.
            OutputHandler CurrentHandler = new WindowsDotNetConsoleHandler(); // выводит данные в консоль windows.
            
            // Выводит данные в текстовый файл "OutputLog.txt". (Раскомментировать для использования).
            //OutputHandler CurrentHandler = new DotNetTextHandler("OutputLog.txt");

            // Создали и инициализировали список с инструментами (объектами типа "DrawTool").
            List<DrawTool> ListTools = new List<DrawTool>();
            // Добавили несколько различных инструментов унаследованных от DrawTool.
            ListTools.Add(new Pencil("Синий"));
            ListTools.Add(new Brush("Красный", 12));
            ListTools.Add(new Square("Серый", 10, 10));

            // Производим имитацию рисования каждым инструментом.
            foreach (DrawTool dt in ListTools)
            {
                dt.Draw(CurrentHandler); // Рисуем и обрабатываем вывод контроллером "CurrentHandler".
                if (dt is IFilled) // Если класс можно представить как объект типа IFilleв...
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
