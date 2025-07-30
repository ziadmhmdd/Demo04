using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Static
{
    // static [helper]
    internal static class Utilities
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        private static double pi ;


        //public Utilities()
        //{
        //    pi = 3.14;
        //}

        static Utilities()
        {
            pi = 3.14;
        }

        // Static Method : Class Member Method 
        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }


        // 3.14
        // static property
        public static double PI()
        {
            return pi;
        }
    }
}
