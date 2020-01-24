using DocumentFormat.OpenXml.Spreadsheet;
using System;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            //EItem item = new Cart("Ken's shopping cart");

            var myAccount = new Account();
            myAccount.AccountName = "Ken's account";
            myAccount.ShoppingCart = " \n";

            EnterItems(item);
            

            Console.WriteLine($"Account Name:  {myAccount.AccountName}, Total Items: {myAccount.AccountTotal }  ");
        }

        private static void EnterAccountName()
        {

        }

        public static void EnterItems(EItem item)
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
