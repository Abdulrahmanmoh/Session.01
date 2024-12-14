//Solution: Is a container of projects
//Namespace:Is a container of classes
//Class:Is a container of Functions
//Functions:Is a container of Codes or statments
//Calling a function: Namespace.Class.Function()
//File is prefered to contain only on class
//Global Using: Group of global namespaces will be used in the project
using System;
using System.Net.Security;
using System.Runtime.InteropServices;
namespace Session._01

{
    internal class Program
    {
        static void Main()
        {

            #region Variables

            //Console.WriteLine("Hello, World!");

            ////int Number;  //declare
            ////Number = 5; //Intialze 
            ////Console.WriteLine(Number); //print

            //int Number = 5; //declare+Intialze
            //Console.WriteLine(Number); //Print

            //int Number01 = 5, Number02 = 6, Number03 = 7;
            //Console.WriteLine(Number01);
            //Console.WriteLine(Number02);
            //Console.WriteLine(Number03);
            #endregion




            //CLS->Common Language specification
            //CTS->Common type systme


            //Tyoes of data types:
            //Value data type--> stored in stack RAM
            //Reference data type-->stored in Heap RAM

            #region value data type
            ////1-value data type
            ////a.declare variable
            //int number01; //c# key word
            //int32 number02; //bcl
            ////b. value intializaiotn 
            //number01 = 5;
            //number02 = 10;
            ////c.printing 
            //console.writeline(number01);
            //console.writeline(number02);
            #endregion
            #region Reference Data Type

            Point P01;
            // Declare Refernce From Type 'Point'
            // P01 : Can Refer To Object From Type 'Point'
            // 8 Bytes Will Be Allocated At Stack For The 'P01'
            // 0 Bytes Will Be Allocated At Heap
            P01 = new Point();
            //New effect
            // 1. Allocate The Number Of Required Bytes For The Object at Heap
            // 2. Initialized The Allocated Byte With The Defaul Value of The Datatype
            // 3. Call User-Defined Constructor if Exsits
            // 4. Assign The Object Address To The Reference 'P01'


            //P01.x = 5;
            //P01.y = 10;
            //Console.WriteLine(P01.x);
            //Console.WriteLine(P01.y);
            //Console.WriteLine(P01);
            #endregion

            #region object
            //object ob01;
            //ob01 = new object();
            //ob01 = 1;
            //Console.WriteLine(ob01);
            //ob01 = 3.5;
            //Console.WriteLine(ob01);
            //ob01 = "Hello";
            //Console.WriteLine(ob01);
            //ob01 = new Point();
            //Console.WriteLine(ob01);


            ////TO String()
            //Console.WriteLine(ob01.ToString());
            ////Get hash cosw
            //Console.WriteLine(ob01.GetHashCode());
            #endregion

            #region casting
            //Casting: Convert From Any Datatype To Any Datatype
            // 1. Implicit Casting
            //int x = 5;
            //double y = x;
            //Console.WriteLine(y);

            //// 2. Explicit Casting

            //double X = 2.5;

            //int Y = (int)X; // Explicit Casting (UnSafe)
            //Console.WriteLine(Y);

            //Parse
            //Console.WriteLine(value: "Enter Your Age");
            ////Console.ReadLine();
            ////int age = int.Parse(Console.ReadLine());
            ////Console.WriteLine(value: "Enter Your GPA");
            ////double GPA= double.Parse(Console.ReadLine());
            ////Console.WriteLine("Your Age is:" + age);
            ////Console.WriteLine("Your GPA is" + GPA);

            //Convert class
            //Console.WriteLine(value: "Enter Your Age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your Age is:" + age);

            //tryparse
            //Console.WriteLine(value: "Enter Your Age");
            //int Age;
            //bool flag = int.TryParse(Console.ReadLine(), out Age);
            //Console.WriteLine(Age);
            //Console.WriteLine(flag);
            #endregion



            #region Fractions And Discards
            ////double X = 1.5;
            ////float Y = 1.5F;

            ////decimal Z = 1.5m;

            //int X = 1_000_000_000; // Discard

            //Console.WriteLine(X);
            #endregion

            #region Operators

            // 1. Unary Operators -> Works On One Operand (Variable) ++ --
            //int X = 10;
            // ++
            // PreFix [Increment then print]
            //Console.WriteLine(++X); // 11
            //// PostFix [Print then Increment]
            //Console.WriteLine(X++); // 10
            //Console.WriteLine(X); // 11

            // PreFix [decrement then print]
            //Console.WriteLine( -- X); // 9
            // PostFix [Print then decrement]
            //Console.WriteLine(X--); // 10
            //Console.WriteLine(X); // 9


            // 2.Binary Operators => Works on Two Operands (Variables)
            // + = /* %
            //int Sum, Mul, Sub, Mod;
            //int Number01= 2, Number02= 6;

            //Sum = Number01 + Number02; // 8
            //Mul = Number01 * Number02; // 12
            //Sub = Number01 - Number02; // -4
            //Mod = Number01 % Number02; // 2
            // 23 % 3 = 2

            // 3. Assignment Operators
            //int x;
            //x = 4;
            //x += 2; // X = X + 2 / / 6
            //Console.WriteLine(x);
            //x -= 2; // X = X - 2 // 2
            //Console.WriteLine(x);
            //x *= 2; // X = X * 2 //8
            //Console.WriteLine(x);
            //x /= 2; // X = x / 2 //2
            //Console.WriteLine(x);
            //x %= 2; //X = X % 2 //0
            //Console.WriteLine(x);


            // 4. Relational Operators [Comparsion]

            //int x = 6, y = 5;
            //Console.WriteLine(x == y);
            //Console.WriteLine(x != y);
            //Console.WriteLine(x>y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x < y);
            //Console.WriteLine(x >= y);
            //Console.WriteLine(x <= y);

            // 5. Logical Operators [AND , OR , NOT]
            // Console.WriteLine(!false); // ! -> Not
            //Console.WriteLine(false && true); // && -> AND Short Circuit
            //Console.WriteLine(false | | true); // || -> OR Short Circuit

            ////6. BitWise Operators
            //Console.WriteLine(!false); // ! -> Not
            //Console.WriteLine(false & true); // && -> AND Long Circuit
            //Console.WriteLine(false | true); // || -> OR Long Circuit

            //// 7. Ternary Operator [Conditional Operator]

            //bool flag = 4 > 2;
            //Console.WriteLine(flag);
            //string flag = 4 < 2 ? "Cornect" : "Not Correct";
            //Console.WriteLine(flag);


            #endregion



        }
    }
}
