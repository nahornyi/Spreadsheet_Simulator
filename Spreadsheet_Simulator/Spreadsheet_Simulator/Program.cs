using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadsheet_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(2,2);
            Console.WriteLine("Enter the table cells:\n");
            matrix.Fill();
            Console.WriteLine("Filled table:\n");
            matrix.Print();


            Console.ReadKey();
        }
    }
}
