using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Calculation
{
    public class MyException : ApplicationException
    {
        private string msg;
        public DateTime TimeExp { get; private set; }
        public MyException()
        {
            msg = "Can't divided by zero";
            TimeExp = DateTime.Now;
        }
        public override string Message
        {
            get { return msg; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.DarkBlue;
            string act;
            float num1 = 0, num2 = 0, res = 0;

            WriteLine("Ruls calculation");
            WriteLine("Input number 1 and press Enter");
            WriteLine("Then input action +, -, /, * and press Enter");
            WriteLine("Then input number 2 and press Enter");
            ReadLine();
            while (true)
            {
                Clear();
            l1:
                try
                {
                    num1 = float.Parse(ReadLine());
                }
                catch (FormatException ex)
                {
                    WriteLine($"{ex.Message}");
                    goto l1;
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
                            catch (FormatException ex)
                            {
                                WriteLine($"{ex.Message} ");
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
                            catch (FormatException ex)
                            {
                                WriteLine($"{ex.Message} ");
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
                            catch (FormatException ex)
                            {
                                WriteLine($"{ex.Message} ");
                            }
                            WriteLine(num1 * num2);
                        }
                        break;
                    case "/":
                        {
                            try
                            {
                                num2 = float.Parse(ReadLine());
                                if ( num2 == 0 ) { throw new MyException(); }
                                res = num1 / num2;
                                WriteLine(res);
                            }
                            catch (FormatException ex)
                            {
                                WriteLine($"{ex.Message}");
                            }
                            catch (MyException myexp)
                            {
                                WriteLine($"{myexp.Message}");
                            }
                            
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