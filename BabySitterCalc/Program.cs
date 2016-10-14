using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterCalc
{
    class Program
    {

        static void Main(string[] args)
        {
            PayCalculator myCalc = new PayCalculator();
            GetUserStartTime(myCalc);
            GetUserBedTime(myCalc);
            GetUserEndTime(myCalc);
            ShowAmountDo(myCalc);

        }

        static void PrintHeader()
        {
            string head = "($$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$)";
            head += "\n \t          Baby Sitter Calculator";
            head += "\n($$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$) \n";
            head += "\n  Please enter in the requested information below to \n" +
                      "  calculate your earned wages for the evening. \n\n";
            Console.Write(head);
        }

        static void PrintFooter()
        {
            string foot = "($$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$)";
            foot += "\n          By Baby Co, where your baby is our business.";
            foot += "\n($$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$) \n \n";
            Console.Write(foot);

        }

        static void GetUserStartTime(PayCalculator myCalc)
        {
            bool done = false;
            while (!done)
            {
                PrintHeader();
                Console.Write("\n \n \t Please Enter the time you begain your job. \n \t Example Format - 5:21 \n \n");
                PrintFooter();
                string buffer = null;
                buffer = Console.ReadLine();

                int p = buffer.IndexOf(':');
                if (p > 0)
                {
                    int hour = 0;
                    int min = 0;
                    try
                    {
                        string h = null;
                        string m = null;

                        h = buffer.Substring(0, p);
                        hour = Convert.ToInt32(h);
                        int c = p + 1;
                        m = buffer.Substring(c, 2);
                        min = Convert.ToInt32(m);
                    }
                    catch (InvalidCastException e)
                    {
                        Console.WriteLine("Ivalid cast exception : %s", e);
                    }

                    myCalc.SetStartTime(hour, min, 0);
                    done = true;
                    Console.Clear();
                }
                else
                {
                    Console.Write(" \n \n \t The format you entered is not valid press any key to try again.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }

        static void GetUserBedTime(PayCalculator myCalc)
        {
            bool done = false;
            while (!done)
            {
                PrintHeader();
                Console.Write("\n \n \t Please Enter the time you placed the child to be \n \t Example Format - 5:21 \n \n");
                PrintFooter();
                string buffer = null;
                buffer = Console.ReadLine();

                int p = buffer.IndexOf(':');
                if (p > 0)
                {
                    int hour = 0;
                    int min = 0;
                    try
                    {
                        string h = null;
                        string m = null;

                        h = buffer.Substring(0, p);
                        hour = Convert.ToInt32(h);
                        int c = p + 1;
                        m = buffer.Substring(c, 2);
                        min = Convert.ToInt32(m);
                    }
                    catch (InvalidCastException e)
                    {
                        Console.WriteLine("Ivalid cast exception : %s", e);
                    }

                    myCalc.SetBedTime(hour, min, 0);
                    done = true;
                    Console.Clear();
                }
                else
                {
                    Console.Write(" \n \n \t The format you entered is not valid press any key to try again.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void GetUserEndTime(PayCalculator myCalc)
        {
            bool done = false;
            while (!done)
            {
                PrintHeader();
                Console.Write("\n \n \t Please Enter the time your job ended. \n \t Example Format - 5:21 \n \n");
                PrintFooter();
                string buffer = null;
                buffer = Console.ReadLine();

                int p = buffer.IndexOf(':');
                if (p > 0)
                {
                    int hour = 0;
                    int min = 0;
                    try
                    {
                        string h = null;
                        string m = null;

                        h = buffer.Substring(0, p);
                        hour = Convert.ToInt32(h);
                        int c = p + 1;
                        m = buffer.Substring(c, 2);
                        min = Convert.ToInt32(m);
                    }
                    catch (InvalidCastException e)
                    {
                        Console.WriteLine("Ivalid cast exception : %s", e);
                    }

                    myCalc.SetEndTime(hour, min, 0);
                    done = true;
                    Console.Clear();
                }
                else
                {
                    Console.Write(" \n \n \t The format you entered is not valid press any key to try again.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }


        public static void ShowAmountDo(PayCalculator myCalc)
        {
            PrintHeader();
            myCalc.CalculateNightsPay();
            Console.WriteLine("   Calculated start to bed ay : {0}", myCalc.startToBedPay);
            Console.WriteLine("   Calculated bed to midnight pay : {0}", myCalc.bedToMidnightPay);
            Console.WriteLine("   Calculated midnight to end of night pay: {0}", myCalc.midnightToEndPay);
            Console.WriteLine("   Final Amount Owed : {0}", myCalc.fullPay);
            Console.WriteLine("\n \n Thank you for using our Calculator, Press any key to exit.");
            PrintFooter();
            Console.ReadKey();
        }
    }
}
