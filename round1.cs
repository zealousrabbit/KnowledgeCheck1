using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter first number: ");
            int first = Console.ReadLine();

            Console.WriteLine("Please enter second number: ");
            int second = Console.ReadLine();

            Console.WriteLine("State your operator: + - / * ");
            string operator = Console.ReadLine();

            switch (operator)
                    {

                case "+":
                    if (int.TryParse(first, out int addfirst) && int.TryParse(second, out int addsecond))
                    {
                        Console.WriteLine("The solution is: " first + second);

                    }
                    else
                    {
                        Console.WriteLine("The numbers are invalid.");
                    }
                    break;

                case "-":
                    if (int.TryParse(first, out int subfirst) && int.TryParse(second, out int subsecond))
                    {
                        Console.WriteLine("The solution is: " first - second);

                    }
                    else
                    {
                        Console.WriteLine("The numbers are invalid.");
                    }
                    break;

                case "*":
                    if (int.TryParse(first, out int mulfirst) && int.TryParse(second, out int mulsecond))
                    {
                        Console.WriteLine("The solution is: " first * second);

                    }
                    else
                    {
                        Console.WriteLine("The numbers are invalid.");
                    }
                    break;

                case "/":
                    if (int.TryParse(first, out int divfirst) && int.TryParse(second, out int divsecond))
                    {
                        Console.WriteLine("The solution is: " first / second);

                    }
                    else
                    {
                        Console.WriteLine("The numbers are invalid.");
                    }
                    break;


                default:
                    Console.WriteLine("I'm sorry, I don't know what you mean.");
                    break;
                }
            }

        }
    }
}