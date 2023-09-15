using System;
using System.Globalization;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

namespace CalculatorApp
{
    public class Program
    {
        static void Main(string[] args)

        {

            while (true)
            {
                Console.WriteLine("What operation would you like to perform? ");
                Console.WriteLine("[1] - Addition");
                Console.WriteLine("[2] - Subtraction");
                Console.WriteLine("[3] - Multiplication");
                Console.WriteLine("[4] - Division");

                int operation;
                int firstNumber;
                int secondNumber;
                int result = 0;

                if (int.TryParse(Console.ReadLine(), out operation) && operation >= 1 && operation <= 4)
                {
                    Console.WriteLine("Enter the first number: ");
                    firstNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second number: ");
                    secondNumber = int.Parse(Console.ReadLine());

                    if (operation == 4 && secondNumber == 0)
                    {
                        Console.WriteLine("Sorry, it's not possible to divide by zero");
                        Console.WriteLine("Do you want to try it again? [y/n]");
                        if (Console.ReadLine() == "n")
                        {
                            break;
                        }
                    }
                    else
                    {

                        switch (operation)
                        {
                            case 1:
                                {
                                    result = Addition(firstNumber, secondNumber);
                                    break;
                                }
                            case 2:
                                {
                                    result = Subtraction(firstNumber, secondNumber);
                                    break;
                                }
                            case 3:
                                {
                                    result = Multiplication(firstNumber, secondNumber);
                                    break;
                                }
                            case 4:
                                {
                                    result = Division(firstNumber, secondNumber);
                                    break;
                                }
                        }
                        Console.WriteLine("The result of the operation between the number {0} and {1} is: {2}", firstNumber, secondNumber, result);

                        Console.ReadLine();

                    }
                }
                else
                {
                    Console.WriteLine("Invalid number, please try a number between 1 and 4");
                    Console.WriteLine("Do you want to try it again? [y/n]");
                    if (Console.ReadLine() == "n")
                    {
                        break;
                    }

                }

            }

        }
        public static int Addition(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        public static int Subtraction(int num1, int num2)
        {
            int sub = num1 - num2;
            return sub;
        }
        public static int Multiplication(int num1, int num2)
        {
            int multi = num1 * num2;
            return multi;
        }
        public static int Division(int num1, int num2)
        {
            int div = num1 / num2;
            return div;
        }


    }
}