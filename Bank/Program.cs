using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nazwa: bank";
            string author = "Autor: Marek Zając";
            Console.WriteLine(name);
            Console.WriteLine(author);

            Account savingsAccount = new SavingsAccount(1, "Marek", "Zając", 92010133333);
            string fullName = savingsAccount.GetFullName();
            Console.WriteLine("Pierwsze konto w systemie dostał(-a): {0}", fullName);

            Account secondSavingsAccount = new SavingsAccount(2, "Marek", "Zając", 92010133333);

            Account billingAccount = new BillingAccount(3, savingsAccount.FirstName, savingsAccount.LastName, savingsAccount.Pesel);

            Printer printer = new Printer();
            printer.Print(savingsAccount);
            printer.Print(secondSavingsAccount);

            printer.Print(billingAccount);

            savingsAccount = billingAccount;
            printer.Print(savingsAccount);

            Console.ReadKey();
        }
    }
}
