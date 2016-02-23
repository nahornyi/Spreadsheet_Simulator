using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadsheet_Simulator
{
    class Cells
    {
        protected String cell;

        //Возвращает пустую ячейку
        public bool IsNullOrEmpty()
        {
            return String.IsNullOrEmpty(cell);
        }

        //Возвращает ячейку в которой только лишь цифры
        public bool StringContainsNumbersOnly()
        {
            return System.Text.RegularExpressions.Regex.IsMatch(cell, @"^\d+$");
        }

        //Возвращает ячейку в которой только лишь буквы
        public bool StringContainsLettersOnly()
        {
            return System.Text.RegularExpressions.Regex.IsMatch(cell, @"^[a-zA-Z]+$");
        }

        //Возвращает ячейку в которой строка начинается со знака " = "
        public bool StartEqual()
        {
            return cell.Substring(0, 1).Equals("=");
        }

        //Возвращает ячейку в которой строка начинается со знака " ' "
        public bool StartLiteral()
        {
            return cell.Substring(0, 1).Equals("'");
        }
   
    }
}
