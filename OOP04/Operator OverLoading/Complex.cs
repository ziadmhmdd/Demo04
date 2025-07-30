﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Operator_OverLoading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }


        // Operator OverLoading
        // + 
        // Must Be : Public - Static 

        // Binary : + - * / % 

        //public static Complex operator +(Complex left, Complex right)
        //{
        //    return new Complex();
        //    {
        //        Real = (left?.Real ?? 0) + (right?.Real ?? 0),
        //        Imag = (left?.Imag ?? 0) + (right?.Imag ?? 0)
        //    };
        //}


        //public static Complex operator -(Complex left, Complex right)
        //{
        //    return new Complex();
        //    {
        //       Real = (left?.Real ?? 0) - (right?.Real ?? 0),
        //        Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0)
        //    };
        //}

        // Operator Overloading 
        // ++ --
        //Function : Public - Static

        // Unary Operator ++ --
        public static Complex operator ++(Complex complex)
        {
            if (complex is not null)
            {
                complex.Real++;
                return complex;
            }
            return new Complex();
        }

        public static Complex operator --(Complex complex)
        {
            if (complex is not null)
            {
                complex.Real--;
                return complex;
            }
            return new Complex();
        }

        // Comparsion Operation Binary : > < >= <= != ==
        // Must Be Boolean 

        public static bool operator >(Complex left, Complex right)
        { 
            if (left.Real == right.Real)
                return left.Imag > right.Imag;

            return left.Real > right.Real;
        }

        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag < right.Imag;

            return left.Real < right.Real;
        }


        public static bool operator >=(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag >= right.Imag;

            return left.Real >= right.Real;
        }

        public static bool operator <=(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag <= right.Imag;

            return left.Real <= right.Real;
        }

        public static bool operator ==(Complex left, Complex right)
        { 
            return left.Real == right.Real && left.Imag == right.Imag;
        }

        public static bool operator !=(Complex left, Complex right)
        {
            return left.Real != right.Real || left.Imag != right.Imag;
        }


        // User-Difined Casting Operator
        // Complex ---> String 
        // Function : Public - Static 

        // Implicit - Explicit 
        public static explicit operator string(Complex complex)
        {
            return complex.ToString();
        }

        public static explicit operator int(Complex complex)
        {
            return complex.Real;
        }


        public override string ToString()
        {
            return $"{Real} + {Imag} i";
        }
    }
}
