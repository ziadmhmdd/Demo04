using OOP04.Abstraction;
using OOP04.Mapping;
using OOP04.Operator_OverLoading;
using OOP04.Static;
using System.Numerics;

namespace OOP04
{
    internal class Program
    {
        static void Main()
        { 
            #region Abstraction 
            // Abstraction : التجريد 
            // abstract : C# Keyword بتستخدم مع [class - methods - properties]
            // abstract class
            // abstract method 
            // abstract property 

            // 2D shape 


            //Shape shape = new Shape(); // invalid
            // Note : Can't Create Object From Abstract Class 

            //shape.GetArea();

            Rectangle rectangle = new Rectangle() { Dim01 = 12, Dim02 = 3 };

            //rectangle.Perimeter = 12;

            Console.WriteLine(rectangle.Perimeter);

            Console.WriteLine(rectangle.GetArea());

            rectangle.Print();

            #endregion

            #region Interface Vs Abstract Class
            // Interface Vs Abstract Class 

            #endregion

            #region Operator OverLoading 

            // Operator OverLoading 

            // + - * / % > < >= <= != == || && ! | & ! ^ >>

            // + 

            //int X = 3 + 4;
            //string Y = "Hello" + "World";


            // Complex Number : Real + Imag 

            // 4 + 3 i
            // 4 + 3 ت 

            //Complex C01 = new Complex() { Real = 3, Imag = 4 };
            //Complex C02 = new Complex() { Real = 4, Imag = 2 };

            //Console.WriteLine(C01);
            //Console.WriteLine(C02);


            //Complex C03 = C01 - null;

            //Console.WriteLine(C03);

            // ++ __ 
            // Unary Operator 

            //int X = 12;
            //X++;

            //Console.WriteLine(X);

            //if (C01 >= C02)
            //{
            //    Console.WriteLine("C01 is greater Than C02");
            //}
            //else
            //{
            //    Console.WriteLine("C01 is not greater Than C02");
            //}

            #endregion

            #region User-Difined Casting Operator & Manual Mapping
            // double X = 12;

            // int Y = (int) X;
            // (int) : Casting Operator 

            Operator_OverLoading.Complex C01 = new Operator_OverLoading.Complex() { Real = 3, Imag = 4 };

            //String S = (string) C01;
            //// (string) : Convert Complex Number To string

            //// Operator Overloading
            //// User-Difined Casting Operator

            //Console.WriteLine(S);

            //int X = (int)C01;

            //Console.WriteLine(X);

            //int X = (int) new Operator_OverLoading.Complex() { Real = 4, Imag = 7 };

            // Maping : Convert From Datatype to Datatype

            // Code First
            // DB First

            // User [Id, Name, Email, Password, PhoneNumber, CardNumber, ExpireDate]

            // UserViewModel 
            // UserDto
            // [Name, Email, PhoneNumber]

            User user = new User(); // From DB

            // Mannual Maping 
            UserDto userDto = new UserDto()
            {
                Name = user.Name,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };

            // AutoMapper : Mapping Automatic 
            #endregion

            #region static

            // static : C# Keyword [class - method - property - constructor - attributes]
            // static class
            // static method
            // static property
            // static constructor
            // static attribute

            //Utilities U01 = new Utilities();
            //Utilities U02 = new Utilities();
            //Utilities U03 = new Utilities();

            //Console.WriteLine(U01.CmToInch(254)); // 100
            //Console.WriteLine(U02.CmToInch(254)); // 100
            //Console.WriteLine(U03.CmToInch(254)); // 100


            //Console.WriteLine(Utilities.CmToInch(254)); // 100
            //Console.WriteLine(Utilities.CmToInch(254)); // 100
            //Console.WriteLine(Utilities.CmToInch(254)); // 100


            //Console.WriteLine(Utilities.Pi);
            //Console.WriteLine(Utilities.Pi);
            //Console.WriteLine(Utilities.Pi);

            #endregion

            #region Sealed
            // Sealed : C3 Keyword [class - method - property]

            #endregion

            // Partial : C# Keyword

            //Employee employee = new Employee();
            //employee.

        }
    }
}
