using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class MyMath
    {
        /// <summary>
        /// Сложение двух чмсел
        /// </summary>
        /// <param name="number1">первое число</param>
        /// <param name="number2">второе число</param>
        /// <returns>сумма двух чисел</returns>
        public int AdditionTwoNumbers(int number1, int number2)
        {
            int result = 0;
            result = number1 + number2;
            return result;
        }

        /// <summary>
        /// Длинна строки
        /// </summary>
        /// <param name="str">строка</param>
        /// <returns>длинна строки</returns>
        public int GetLengthString(string str)
        {
            if (str == null) return 0;
            int result = 0;
            result = str.Length;
            return result;
        }


    }
}
