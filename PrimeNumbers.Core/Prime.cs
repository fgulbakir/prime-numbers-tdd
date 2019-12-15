using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers.Core
{
    public class Prime
    {

        //public static bool IsPrimeNumber(int number)
        //{
        //    return true;
        //}

        //public static bool IsPrimeNumber(int number)
        //{
        //    return number != 4;
        //}

        //public static bool IsPrimeNumber(int number)
        //{
        //    return !(number == 4 || number == 9);
        //}

        public static bool IsPrimeNumber(int number)
        {
            for (var i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;

        }


    }
}
