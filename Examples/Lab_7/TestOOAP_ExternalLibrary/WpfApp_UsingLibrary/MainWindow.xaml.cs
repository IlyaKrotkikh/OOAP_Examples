using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToolsLibrary;

namespace WpfApp_UsingLibrary
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public OutputHandler CurrentHandler { get; set; }
        public List<DrawTool> ListTools { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Инициализирован объект управляющий выводом данных.
            CurrentHandler = new ListOutputHandler(); // выводит данные в консоль windows.

            // Инициализировали список с инструментами (объектами типа "DrawTool").
            ListTools = new List<DrawTool>();
            // Добавили несколько различных инструментов унаследованных от DrawTool.
            ListTools.Add(new Pencil("Синий"));
            ListTools.Add(new Brush("Красный", 12));
            ListTools.Add(new Square("Серый", 10, 10));

            this.DataContext = this;

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
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void BtnPaint_Click(object sender, RoutedEventArgs e)
        {
            if (LstPaintTools.SelectedItem == null)
                return;
            (LstPaintTools.SelectedItem as DrawTool).Draw(CurrentHandler);
            NotifyPropertyChanged();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
