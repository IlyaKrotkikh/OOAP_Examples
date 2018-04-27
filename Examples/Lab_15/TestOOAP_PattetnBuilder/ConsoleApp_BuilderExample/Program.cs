using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsLibrary;
using ToolsLibrary.Tools.Interfaces;
using ToolsLibrary.Tools.Builders;
using ToolsLibrary.Tools.Builders.ConcreteCreators;

namespace ConsoleApp_UsingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создан и инициализирован объект управляющий выводом данных.
            OutputHandler CurrentHandler = new WindowsDotNetConsoleHandler(); // выводит данные в консоль windows.

            // Создадим и инициализируем фабрики.
            IBuilder brushCreator = new BrushBuilder();
            IBuilder pencilCreator = new PencilBuilder();
            IBuilder squareCreator = new SquareBuilder();
                 

            // Создали и инициализировали список с инструментами (объектами типа "DrawTool").
            List<ITools> ListTools = new List<ITools>();
            // Добавили несколько различных инструментов унаследованных от DrawTool.
            ListTools.Add(pencilCreator.SetColor("Белый").CreateTool());
            ListTools.Add(brushCreator.SetColor("Красный").SetSize(12).CreateTool());
            ListTools.Add(squareCreator.SetColor("Зеленый").SetHeight(50).SetWidth(50).CreateTool());

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
