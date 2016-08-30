using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (quit == false)
            {
                calculate();
            }
        }

        static float calculate()
        {

            float num1 = 0, num2 = 0, answer = 0;

            Console.Clear();
            Console.Out.WriteLine("Welcome to Calculator!");
            Console.Out.WriteLine("Please Select a Numbered Option Below:");
            Console.Out.WriteLine("1: Addition");
            Console.Out.WriteLine("2: Subtraction");
            Console.Out.WriteLine("3: Multiplication");
            Console.Out.WriteLine("4: Division");
            Console.Out.WriteLine("5: To the Power of");

            string selection = Console.ReadLine();

            switch (selection)
            {

                case "1":

                    Console.Out.WriteLine("Enter the First Number to Add:");
                    try
                    {
                        num1 = float.Parse(Console.ReadLine());
                    }

                    catch (Exception e) { Console.WriteLine("{0} Exception caught. Please use only numbers!", e); }

                    Console.Out.WriteLine("Enter the Second Number to Add:");
                    num2 = float.Parse(Console.ReadLine());

                    answer = num1 + num2;
                    Console.Out.WriteLine("Answer:" + answer);

                    Console.Out.WriteLine("Press Any Key to Continue...");
                    Console.ReadLine();
                    return answer;

                case "2":

                    Console.Out.WriteLine("Enter the First Number to Subtract:");
                    num1 = float.Parse(Console.ReadLine());

                    Console.Out.WriteLine("Enter the Second Number to Subtract:");
                    num2 = float.Parse(Console.ReadLine());

                    answer = num1 - num2;
                    Console.Out.WriteLine("Answer:" + answer);

                    Console.Out.WriteLine("Press Any Key to Continue...");
                    Console.ReadLine();
                    return answer;

                case "3":

                    Console.Out.WriteLine("Enter the First Number to Multiply:");
                    num1 = float.Parse(Console.ReadLine());

                    Console.Out.WriteLine("Enter the Second Number to Multiply:");
                    num2 = float.Parse(Console.ReadLine());

                    answer = num1 * num2;
                    Console.Out.WriteLine("Answer:" + answer);

                    Console.Out.WriteLine("Press Any Key to Continue...");
                    Console.ReadLine();
                    return answer;

                case "4":

                    Console.Out.WriteLine("Enter the First Number to Divide:");
                    num1 = float.Parse(Console.ReadLine());

                    Console.Out.WriteLine("Enter the Second Number to Divide:");
                    num2 = float.Parse(Console.ReadLine());

                    answer = num1 / num2;
                    Console.Out.WriteLine("Answer:" + answer);

                    Console.Out.WriteLine("Press Any Key to Continue...");
                    Console.ReadLine();
                    return answer;

                case "5":

                    Console.Out.WriteLine("Enter the First Number to Divide:");
                    num1 = float.Parse(Console.ReadLine());

                    Console.Out.WriteLine("Enter the Second Number to Divide:");
                    num2 = float.Parse(Console.ReadLine());

                    answer = (float)Math.Pow(num1, num2);
                    Console.Out.WriteLine("Answer:" + answer);

                    Console.Out.WriteLine("Press Any Key to Continue...");
                    Console.ReadLine();
                    return answer;

                default:
                    Console.Out.WriteLine("Please Enter a valid selection!");
                    Console.Out.WriteLine("Press Any Key to Continue...");
                    Console.ReadLine();
                    return 0;

            }

        }

    }

}
