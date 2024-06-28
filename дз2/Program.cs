using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз2
{
    class Program
    {
        static void Main(string[] args)
        {
            void t1()
            {
                Console.WriteLine("ВЫполнил:Агаджан Аннамурадов");
                Console.WriteLine("Teach Me Skills");
            }
            do
            {
                t1();
                double num1 = 0;
                double num2 = 0;
                double result;
                Console.WriteLine("\t\t-----------------------------");
                Console.WriteLine("\t\tCalculator Program");
                Console.WriteLine("\t\t-----------------------------");
                Console.WriteLine("Enter number:");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter number:");
                num2 = int.Parse(Console.ReadLine());


                Console.WriteLine("\n+:ADD");
                Console.WriteLine("\n-:ADD");
                Console.WriteLine("\n*:ADD");
                Console.WriteLine("\n/:ADD");
                Console.WriteLine("Enter an option");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result:{num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result:{num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result:{num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result:{num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;

                }
                Console.WriteLine("Would you like continue?(Y = yes, N = no):");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");
            Console.Read();

        }
    }
}
