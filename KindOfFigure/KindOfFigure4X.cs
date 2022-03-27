using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindOfFigure
{
    public class KindOfFigure4X
    {
        int[,] _arr;
        public string KindOfFigure { get; set; }
        public bool FindKind(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            int[,] arr = new int[4, 2];
            arr[0, 0] = x1;
            arr[0, 1] = y1;
            arr[1, 0] = x2;
            arr[1, 1] = y2;
            arr[2, 0] = x3;
            arr[2, 1] = y3;
            arr[3, 0] = x4;
            arr[3, 1] = y4;
            return FindKind(arr);
        }
        public bool FindKind(int[,] arr)
        {
            if (arr == null || arr.GetLength(0) <= 3 || arr.GetLength(0) > 4
                || arr.GetLength(1) <= 1 || arr.GetLength(1) > 2)
            {
                Clear();
                return false;
            }
            _arr = arr;
            double[] mas = new double[4];
            mas[3] = Math.Sqrt(Math.Pow(arr[0, 0] - arr[3, 0], 2) + Math.Pow(arr[0, 1] - arr[3, 1], 2));
            for (int i = 0; i < mas.Length-1; i++)
            {
                mas[i] = Math.Sqrt(Math.Pow(arr[i + 1, 0] - arr[i, 0], 2) + Math.Pow(arr[i + 1, 1] - arr[i, 1], 2));
            }
            if (mas[0] == mas[1] && mas[1] == mas[2] && mas[2] == mas[3] && mas[3] == mas[0])
            {                
                if (EqualDiags()) KindOfFigure = "Квадрат";
                else KindOfFigure = "Ромб";
                return true;
            }
            if ((mas[0] == mas[1] && mas[2] == mas[3] && mas[1] != mas[2] && mas[0] != mas[3]) ||
                (mas[1] == mas[2] && mas[3] == mas[0] && mas[0] != mas[1] && mas[2] != mas[3]))
            {
                if (EqualDiags()) KindOfFigure = "Прямоугольник";
                else KindOfFigure = "Параллелограмм";
            }
            return false;
        }
        public void Clear()
        {
            KindOfFigure = "";
            _arr = null;
        }
        /// <summary>
        /// Поиск диагоналей
        /// </summary>
        /// <returns></returns>
        private double[] FindDiag()
        {
            double[] diags = new double[2];
            diags[0] = Math.Sqrt(Math.Pow(_arr[2, 0] - _arr[0, 0], 2) + Math.Pow(_arr[2, 1] - _arr[0, 1], 2));
            diags[1] = Math.Sqrt(Math.Pow(_arr[3, 0] - _arr[1, 0], 2) + Math.Pow(_arr[3, 1] - _arr[1, 1], 2));
            return diags;
        }
        private bool EqualDiags()
        {
            double[] diags = FindDiag();
            if (diags[0] == diags[1]) return true;
            return false;
        }
    }
}
