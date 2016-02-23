using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadsheet_Simulator
{
    class Expression : Cells
    {
        private string[,] arr;
        public Expression(Matrix matrix)
        {
            for (int i = 0; i < matrix.n; ++i)
            {
                for (int j = 0; j < matrix.m; ++j)
                {

                    cell = matrix.arr[i, j];

                    if (IsNullOrEmpty())
                    {
                        Console.WriteLine("Ячейка пуста");
                    }
                    else if (StringContainsNumbersOnly())
                    {
                        Console.WriteLine("Строка содержит только цифры");
                    }
                    else if (StartEqual())
                    {
                        Console.WriteLine("Строка начинается со знака '='");
                    }
                    else if (StartLiteral())
                    {
                        Console.WriteLine("Строка начинается со знака ' ' '");
                    }
                }
            }
           
        }


    }
}
