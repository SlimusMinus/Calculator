using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.DarkBlue;
            string act;
            float num1, num2, res;

            WriteLine("Ruls calculation");
            WriteLine("Input number 1 and press Enter");
            WriteLine("Then input action +, -, /, * and press Enter");
            WriteLine("Then input number 2 and press Enter");
            ReadLine();
            while (true)
            {
                Clear();
                try
                {
                    num1 = float.Parse(ReadLine());
                }
                catch (Exception)
                {
                    WriteLine("Error, input just number!!!");
                    WriteLine("Press Enter, and input new numbers");
                    ReadLine();
                    continue;
                }

                act = ReadLine();
                switch (act)
                {
                    case "+":
                        {
                            try
                            {
                                num2 = float.Parse(ReadLine());
                            }
                            catch (Exception)
                            {
                                WriteLine("Error, input just number!!!");
                                WriteLine("Press Enter");
                                ReadLine();
                                continue;
                            }
                            WriteLine(num1 + num2);
                        }
                        break;
                    case "-":
                        {
                            try
                            {
                                num2 = float.Parse(ReadLine());
                            }
                            catch (Exception)
                            {
                                WriteLine("Error, input just number!!!");
                                WriteLine("Press Enter");
                                ReadLine();
                                continue;
                            }
                            WriteLine(num1 - num2);
                        }
                        break;
                    case "*":
                        {
                            try
                            {
                                num2 = float.Parse(ReadLine());
                            }
                            catch (Exception)
                            {
                                WriteLine("Error, input just number!!!");
                                WriteLine("Press Enter");
                                ReadLine();
                                continue;
                            }
                            WriteLine(num1 * num2);
                        }
                        break;
                    case "/":
                        {
                            try
                            {
                                num2 = float.Parse(ReadLine());
                            }
                            catch (Exception)
                            {
                                WriteLine("Error, input just number!!!");
                                WriteLine("Press Enter");
                                ReadLine();
                                continue;
                            }
                            if (num2 == 0)
                            {
                                WriteLine("Сan't divide by 0, press Enter");
                                ReadLine();
                                continue;
                            }
                            else
                                WriteLine(num1 / num2);
                        }
                        break;
                    default:
                        WriteLine("Error action");
                        break;
                }
                WriteLine("Press Enter and input new numbers");
                ReadLine();
            }

        }
    }
}
