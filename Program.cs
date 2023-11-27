using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_21
{
   public delegate int ArithmeticOperation(int a, int b);
        internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b) 
        {
            return a * b; 
        }
        static int Divide(int a, int b)
        {
            return a / b;
        }
        static void Main()
        {
            ArithmeticOperation addDelegate =new ArithmeticOperation(Add);
            ArithmeticOperation subtractDelegate = Subtract;
            ArithmeticOperation multiplyDelegate = Multiply;
            ArithmeticOperation divideDelegate = Divide;

            Console.Write("Enter the first Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose the Operation which you want to perform. \n1.Addition \n2.Subractionc \n3.Multiplication. \n4.Division");    
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Addition of {num1} and {num2} is " + addDelegate(num1, num2));
                    break;
                case 2:
                    Console.WriteLine($"Subraction of {num1} and {num2} is " + subtractDelegate(num1, num2));
                    break;
                case 3:
                    Console.WriteLine($"Multiplication of {num1} and {num2} is " + multiplyDelegate(num1, num2));
                    break;
                case 4:
                    Console.WriteLine($"Division of {num1} and {num2} is " + divideDelegate(num1, num2));
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
