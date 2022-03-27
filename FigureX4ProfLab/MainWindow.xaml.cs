using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KindOfFigure;

namespace FigureX4ProfLab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FindKind_Click(object sender, RoutedEventArgs e)
        {
            KindOfFigure4X kind = new KindOfFigure4X();
            Result.Text = kind.FindKind(Convert.ToInt32(X1.Text), Convert.ToInt32(Y1.Text), Convert.ToInt32(X2.Text)
                , Convert.ToInt32(Y2.Text), Convert.ToInt32(X3.Text)
                , Convert.ToInt32(Y3.Text), Convert.ToInt32(X4.Text),
                Convert.ToInt32(Y4.Text)).ToString();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данная программа имеет следующие особенности:\n" +
                "1) Возможность ввода количества знаков в поля - 5\n" +
                "2) Представлено только меню для выполнения действий, так как не было смысла разрабатывать кнопки среди полей(Для удобного восприятия)\n" +
                "3) Если у нас не четырехугольник(даже, если не правильно заданы точки - вывод информации об невозможности определения)");
        }
    }
}
