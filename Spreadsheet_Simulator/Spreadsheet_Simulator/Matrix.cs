using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadsheet_Simulator
{
    class Matrix
    {
        private int n;
        private int m;
        private string [,] arr;

        //Конструктор задания размерности таблицы
        public Matrix(int _n, int _m)
        {
            n = _n;
            m = _m;
        }

        //Метод заполнения таблицы размерностью nxm
        public void Fill()
        {
            arr = new string[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i,j] = Console.ReadLine();
                }
            }
        }

        //Печать таблицы
        public void Print()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
