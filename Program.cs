using System;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new Account();
            myAccount.AccountName = "Ken's account";
            myAccount.ShoppingCart = " \n";
            myAccount.AddItems();

            Console.WriteLine($"Account Name:  {myAccount.AccountName}, Total Items: {myAccount.AccountTotal }  ");
        }
    }
}
