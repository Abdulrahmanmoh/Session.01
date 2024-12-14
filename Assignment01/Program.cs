using System.ComponentModel;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem.01
            ////Write a program that allows the user to enter a number then print it.
            //Console.WriteLine("Enter a Number");
            //Console.WriteLine(value: "Enter a Number"); //What is the using of value
            //double number = double.Parse(Console.ReadLine());
            //Console.Write("The Number You Have Entered is " + number);
            #endregion

            #region Problem.02*



            ///*Write C# program that converts a string to an integer,
            //but the string contains non-numeric characters. 
            ////And mention what will happen */
            //Console.WriteLine("Enter a String");
            //int convertor = int.Parse(Console.ReadLine());
            //Console.WriteLine("The Value is " + convertor);
            #endregion

            #region Problem.03


            /*Write C# program that Perform a simple arithmetic operation 
            with floating-point numbers And mention what will happen*/
            //Console.WriteLine("Enter the First Number");
            //float no01 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Second Number");
            //float no02 = float.Parse(Console.ReadLine());
            //Console.WriteLine("The Summition Of The Two Numbers =" + (no01 + no02));
            #endregion

            #region Problem.04*
            //Write C# program that Extract a substring from a given string

            #endregion

            #region Problem.05
            /*
            Write C# program that Assigning one value type variable
            to another and modifying the value of one variable and 
            mention what will happen*/
            //int x;
            //x = 5;
            //int Y = x;
            //x = 7; //Ihave changed the value of X why still printing Y with the old value?

            //Console.WriteLine(x);
            //Console.WriteLine(Y);



            #endregion

            #region Problem.06


            /*Write C# program that Assigning one reference type variable 
             to another and modifying the object through one variable and mention what will happen*/
            //string value01;
            //value01 = "Hello world";
            //string value02;
            //value02 = value01;
            //Console.WriteLine(value02);

            #endregion

            #region Problem.07
            //Write C# program that take two string variables and print them as one variable
            //Console.WriteLine("Enter Your First Name");
            //string First_name = (Console.ReadLine());
            //Console.WriteLine("Enter Your Last Name");
            //string Last_name = (Console.ReadLine());
            //Console.WriteLine("Your Full Name is "+ First_name+ " "+Last_name);
            #endregion

            #region Problem.08
            /*Write a program that calculates the simple interest given the principal amount, 
             rate of interest, and time. The formula for simple interest is 
             Interest = (principal * rate * time ) /100.*/
            //double Interest;
            //double principal;
            //double rate;
            //double time;
            //Console.WriteLine("Enter principal");
            //principal = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter rate");
            //rate = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter time");
            //time= double.Parse(Console.ReadLine());
            //Console.WriteLine("Interest = " + (principal * rate * time) / 100);
            #endregion

            #region Problem.09
            //Write a program that calculates the Body Mass Index
            //(BMI) given a person's weight in kilograms and height in meters.
            //The formula for BMI is BMI = (Weight) / (Height * Height)

            //double BMI;
            //double Weight;
            //double Height;
            //Console.WriteLine("Enter Your Weight");
            //Weight = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Your Height");
            //Height = double.Parse(Console.ReadLine());
            //Console.WriteLine("Your BMI = " + (Weight) / (Height * Height));

            #endregion

            #region Problem.10
            //Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good.
            //Assign the result in a variable then display the result.
            //Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot",
            //and anything else is "Just Good".
            //Console.WriteLine("Enter the Temperature Degree");
            // double temperature =double.Parse(Console.ReadLine());
            // string result;
            // result= temperature < 10 ? "Just coold" :
            //result =  temperature > 30? "Just hot" : "Just Good";
            // Console.WriteLine(result);
            #endregion

            #region Problem.11*
            /*
            Write a program that takes the date from the user and displays it
            in various formats using string interpolation.
            Ex:
            Today’s date : 20 , 11 , 2001
            Today's date : 20 / 11 / 2001
            Today's date : 20 – 11 – 2001
            */
            #endregion*

            #region Problem.012
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            #endregion

            #region Problem.013
            //Which of the following statements is correct about the C#.NET code snippet given below?
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            #endregion

            #region Problem.014
            ////Which of the following is the correct output for the C# code given below?
            //Console.WriteLine(13 / 2 + " " + 13 % 2);
            #endregion

            #region Problem.015
            //What will be the output of the C# code given below?

            //int num = 1, z = 5;
            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);
            #endregion
        }
    }
}
