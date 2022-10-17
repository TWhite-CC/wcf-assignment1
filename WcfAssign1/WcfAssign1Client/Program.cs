/* PROG3170-2 WCF-Assignment#1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfAssign1Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo consoleKeyInfo;
            string text, tagText, stringResult;
            char selection;
            int intResult;
            Boolean exitProgram = false, sortDoLoop = true;
            WcfAssign1Reference.Assign1ServiceClient client = new WcfAssign1Reference.Assign1ServiceClient();

            Console.WriteLine("\t\tPROG3170 - WCF Assignment #1");
            while (!exitProgram)
            {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("1) Check Prime Number");
                Console.WriteLine("2) Sum Of Digits");
                Console.WriteLine("3) Reverse a string");
                Console.WriteLine("4) Print HTML Tags");
                Console.WriteLine("5) Sort 5 Numbers");
                Console.WriteLine("6) Exit Program");
                Console.WriteLine("-----------------------------");
                Console.Write("\tMake a selection (1-6):");
                selection = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                switch (selection)
                {
                    case '1':
                        Console.Write("\tEnter a number:");
                        text = Console.ReadLine();
                        stringResult = client.IsPrimeNumber(int.Parse(text));
                        Console.WriteLine("\t" + stringResult);
                        break;
                    case '2':
                        Console.Write("\tEnter a number:");
                        text = Console.ReadLine();
                        intResult = client.SumOfDigits(text);
                        Console.WriteLine("\tThe sum of the digits is:{0}", intResult);
                        break;
                    case '3':
                        Console.Write("\tEnter a string:");
                        text = Console.ReadLine();
                        stringResult = client.ReverseString(text);
                        Console.WriteLine("\tReversed is:{0}", stringResult);
                        break;
                    case '4':
                        Console.Write("\tEnter an HTML tag:");
                        tagText = Console.ReadLine();
                        Console.Write("\tEnter data:");
                        text = Console.ReadLine();
                        stringResult = client.PrintHTMLTags(tagText, text);
                        Console.WriteLine("\tThe tagged HTML is:{0}", stringResult);
                        break;
                    case '5':
                        Console.Write("\tEnter 5 numbers separated by commas:");
                        text = Console.ReadLine();
                        sortDoLoop = true;
                        while (sortDoLoop) {
                            Console.Write("\tEnter (A) for ascending or (D) for descending:");
                            selection = Console.ReadKey().KeyChar.ToString().ToUpper().ToCharArray()[0];
                            if (selection == 'A' || selection == 'D')
                            {
                                sortDoLoop = false;
                            }
                            Console.WriteLine("");
                        }
                        stringResult = client.Sort5Numbers(selection == 'A', text);
                        if (selection == 'A')
                        {
                            Console.Write("\tThe numbers sorted ascending are:");
                        } else
                        {
                            Console.Write("\tThe numbers sorted descending are:");
                        }
                        Console.WriteLine(stringResult);
                        break;
                    case '6':
                        exitProgram = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
