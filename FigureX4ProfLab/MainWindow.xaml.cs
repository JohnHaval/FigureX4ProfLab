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
            int x1,y1,x2, y2,x3,y3,x4,y4;
            try
            {
                x1 = Convert.ToInt32(X1.Text);
            }
            catch
            {
                Message("x1");
                X1.Focus();
                return;
            }
            try
            {
                y1 = Convert.ToInt32(Y1.Text);
            }
            catch
            {
                Message("y1");
                Y1.Focus();
                return;
            }
            try
            {
                x2 = Convert.ToInt32(X2.Text);
            }
            catch
            {
                Message("x2");
                X2.Focus();
                return;
            }
            try
            {
                y2 = Convert.ToInt32(Y2.Text);
            }
            catch
            {
                Message("y2");
                Y2.Focus();
                return;
            }
            try
            {
                x3 = Convert.ToInt32(X3.Text);
            }
            catch
            {
                Message("x3");
                X3.Focus();
                return;
            }
            try
            {
                y3 = Convert.ToInt32(Y3.Text);
            }
            catch
            {
                Message("y3");
                Y3.Focus();
                return;
            }
            try
            {
                x4 = Convert.ToInt32(X4.Text);
            }
            catch
            {
                Message("x4");
                X4.Focus();
                return;
            }
            try
            {
                y4 = Convert.ToInt32(Y4.Text);
            }
            catch
            {
                Message("y4");
                Y4.Focus();
                return;
            }
            if (kind.FindKind(x1, y1, x2, y2, x3, y3, x4, y4)) Result.Text = kind.KindOfFigure;
        }
        private void Message(string value)
        {
            MessageBox.Show($"Неверно введено значение {value}!",
                "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данная программа имеет следующие особенности:\n" +
                "1) Возможность ввода количества знаков в поля - 4\n" +
                "2) Представлено только меню для выполнения действий, так как не было смысла разрабатывать кнопки среди полей(Для удобного восприятия)\n" +
                "3) Программа предназначена для определения вида ТОЛЬКО четырехугольника", "Справка",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void AboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик программы: Лопаткин Сергей ИСП-31 (GitHub.Name = \"Hapro Bishop\")\n" +
                "Задание 5.Разработать программу определения вида четырехугольника, " +
                "заданного координатами вершин на плоскости: " +
                "квадрат, прямоугольник, параллелограмм, ромб, " +
                "равнобедренная трапеция, прямоугольная трапеция, " +
                "трапеция общего вида, четырехугольник общего вида.", "О программе",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Result.Clear();
            X1.Text = X2.Text = X3.Text = X4.Text = Y1.Text = Y2.Text = Y3.Text = Y4.Text = "";
        }
    }
}
