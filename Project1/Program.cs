using System;

namespace Calculator
{
    class Program
    {
        public static void Addition(int a,int b)
        {
            int result =a + b;
            Console.WriteLine("Addition :{0}",result);
        }
        public static void Subtraction(int a,int b)
        {
            int result =a - b;
            Console.WriteLine("Subtraction :{0}",result);
        }

        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division :{0}", result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication :{0}", result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number :");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number :");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your choice");
            Console.WriteLine("Press 1 for Addition:");
            Console.WriteLine("Press 2 for Subtraction:");
            Console.WriteLine("Press 3 for Multiplication:");
            Console.WriteLine("Press 4 for Division:");

            int c= int.Parse(Console.ReadLine());

                switch(c)
                { 
                case 1:
                    Program.Addition(num1,num2);
                    break;
                case 2:
                    Program.Subtraction(num1, num2);
                    break;
                case 3:
                    Program.Multiplication(num1, num2);
                    break;
                case 4:
                    Program.Division(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid CHoice");
                        break;
            }





        }
    }
}
