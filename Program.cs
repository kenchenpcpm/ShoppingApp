using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    class Program
    {
        public static IEList list { get; private set; }

        static void Main(string[] args)
        {
            IEList item = new DiskList("Ken's shopping cart");


            EnterLists(list);
            //EnterItems(item);

            Console.WriteLine($"");
            Console.WriteLine($"Account Name:  {myAccount.AccountName}, Total Items: {myAccount.AccountTotal }  ");
        }

        private static void EnterAccountName()
        {

        }

        public static void EnterLists(IEList list)
        {
            while (true)
            {
                Console.WriteLine("Enter item name or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var item = string.IsNullOrEmpty(input);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine(" - - - ");
                }
            }
        }
    }
}
