using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBasic
{
    internal class Program
    {
        static public decimal GetInput()
        {
            if (!decimal.TryParse(Console.ReadLine(), out decimal variable))
            {
                throw new Exception("Podana wartość nie jest liczbą.");
            }
            return variable;
    }

    static void Main(string[] args)
        {
            int mathChoice;
            decimal varA, varB;


            while (true)
            {
                try
                {
                    Console.WriteLine("Cześć, to jest prosty kalkulator!\nZaznacz jaką chcesz wykonać operację:");
                    Console.WriteLine("1. Dodawanie");
                    Console.WriteLine("2. Odejmowanie");
                    Console.WriteLine("3. Mnożenie");
                    Console.WriteLine("4. Dzielenie");
                    Console.WriteLine("5. Wyjście");
                    Console.Write("Twój wybór: ");

                    if (!int.TryParse(Console.ReadLine(), out mathChoice))
                    {
                        throw new Exception("Podana wartość nie jest liczbą z zakresu 1 - 5.");
                    }

                    if (mathChoice == 5)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Write("Podaj pierwszą wartość do operacji matematycznej: ");
                        varA = GetInput();

                        Console.Write("Podaj drugą wartość do operacji matematycznej: ");
                        varB = GetInput();

                        Console.WriteLine($"Wynik działania to = {MathOperations.Calculate(varA, varB, mathChoice)}");
                    }

                //    if (mathChoice == 5)
                //    {
                //        Environment.Exit(0);
                //    }
                //    else if (mathChoice == 1 || mathChoice == 2 || mathChoice == 3 || mathChoice == 4)
                //    {
                //        Console.Write("Podaj pierwszą wartość do operacji matematycznej: ");
                //        varA = GetInput();

                //        Console.Write("Podaj drugą wartość do operacji matematycznej: ");
                //        varB = GetInput();



                //        switch (mathChoice)
                //        {
                //            case 1:
                //                {
                //                    Console.WriteLine("\nWynik to= " + MathOperations.Add(varA, varB));
                //                    break;
                //                }
                //            case 2:
                //                {
                //                    Console.WriteLine("\nWynik to= " + MathOperations.Subtract(varA, varB));
                //                    break;
                //                }
                //            case 3:
                //                {
                //                    Console.WriteLine("\nWynik to= " + MathOperations.Multiplication(varA, varB));
                //                    break;
                //                }
                //            case 4:
                //                {
                //                    Console.WriteLine("\nWynik to= " + MathOperations.Division(varA, varB));
                //                    break;
                //                }
                //            default: break;
                //        }
                //    }
                //    else if (mathChoice != 1 || mathChoice != 2 || mathChoice != 3 || mathChoice != 4)
                //    {
                //        throw new Exception("Wybrałeś złą operację.");
                //    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
                finally
                {
                    Console.WriteLine();
                }
            }           
        }
    }
}
