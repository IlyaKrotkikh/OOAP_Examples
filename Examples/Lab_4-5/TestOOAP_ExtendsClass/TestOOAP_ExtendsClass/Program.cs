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
            // Создали список с базовыми кистями и инициализировали его.
            List < BaseBrush > ListBrushes  = new List<BaseBrush>();

            // Добавили в список два новых объекта типа "BaseBrush" - базовая кисть.
            ListBrushes.Add(new BaseBrush(ConsoleColor.DarkCyan, 24));
            ListBrushes.Add(new BaseBrush(ConsoleColor.DarkGreen, 30));

            // Создали объект "StyledBrush1" типа "StyledBrush" - стилизованная кисть и инициализировали его.
            StyledBrush StyledBrush1 = new StyledBrush(ConsoleColor.Magenta, 30, "Каллиграфия");
            //StyledBrash1.GetInfo();

            // Добавляем "StyledBrush1" в список.
            // Так как StyledBrush унаследован от BaseBrush данная операция становится возможной.
            ListBrushes.Add(StyledBrush1);

            StyledBrush1.ShowStyle();

            // Перечисляем все элементы списка и у каждого элемента вызываем метод "GetInfo()".
            foreach (BaseBrush bb in ListBrushes)
            {
                bb.GetInfo();
                Console.WriteLine();
            }

            // Ожидаем ввода строки для предотвращения закрытия программы сразу после выполнения кода выше.
            Console.ReadLine();
        }
    }
}
