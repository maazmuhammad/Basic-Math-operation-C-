using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declearing variables 
            int firstNum, secondNum, result, length, width;
            double radius, circumference;

            //(x+y)^2
            Console.WriteLine("Task#1: (x+y)^2");
            Console.Write("\nEnter value of x:");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of y:");
            secondNum = Convert.ToInt32(Console.ReadLine());
            result = (firstNum * firstNum) + (secondNum * secondNum) + (2 * firstNum * secondNum);
            Console.WriteLine("The Answer is " + result);

            //(x-y)^2
            Console.WriteLine("\nTask#2: (x-y)^2");
            Console.Write("\nEnter value of x: ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of y: ");
            secondNum = Convert.ToInt32(Console.ReadLine());
            result = (firstNum * firstNum) + (secondNum * secondNum) - (2 * firstNum * secondNum);
            Console.WriteLine("The Answer is " + result);

            // x^2 - y^2
            Console.WriteLine("\nTask#3: x^2 - y^2");
            Console.Write("\nEnter value of x: ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of y: ");
            secondNum = Convert.ToInt32(Console.ReadLine());
            result = (firstNum - secondNum)*(firstNum + secondNum);
            Console.WriteLine("The Answer is " + result);

            // (x-y)^3
            Console.WriteLine("\nTask#4: (x-y)^3 ");
            Console.Write("\nEnter value of x: ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of y: ");
            secondNum = Convert.ToInt32(Console.ReadLine());
            result = (firstNum * firstNum * firstNum) - 3 * (firstNum * firstNum) * (secondNum) + 3*(firstNum)*(secondNum * secondNum) - (secondNum * secondNum * secondNum);
            Console.WriteLine("The Answer is " + result);

            //circumference of circle(2 Pie r)
            Console.WriteLine("\nTask#5: circumference of circle ");
            Console.Write("Enter value of radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            circumference = (2 * 3.14f * radius);
            Console.WriteLine("The circumference of circle is:" + circumference);

            //Area of rectangle (L*W)
            Console.WriteLine("\nTask#6: Area of rectangle");
            Console.Write("\nplease enter the length: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter the width");
            width = Convert.ToInt32(Console.ReadLine());
            result = (length * width);
            Console.WriteLine("The area of rectangle is  "+ result);
            

            //Area of square (L*L)
            Console.WriteLine("\nTask#7: Area of square ");
            Console.Write("\nplease enter the length: ");
            length = Convert.ToInt32(Console.ReadLine());
            result = (length * length);
            Console.WriteLine("The area of square is  " + result);

            //calculate cube (x^3)
            Console.WriteLine("\nTask#8: calculate cube ");
            Console.Write("\nplease enter the number: ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            result = (firstNum * firstNum *firstNum);
            Console.WriteLine("The cube is " + result);

            //calculate square (x^2)
            Console.WriteLine("\nTask#9: calculate square ");
            Console.Write("\nplease enter the number: ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            result = (firstNum * firstNum);
            Console.WriteLine("The square is " + result);

            Console.ReadKey();



            


        }
    }
}
