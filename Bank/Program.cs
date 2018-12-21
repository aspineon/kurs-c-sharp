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

            SavingsAccount savingsAccount = new SavingsAccount("940000000001", 0.0M, "Marek", "Zając", 92010133333);
            string fullName = savingsAccount.GetFullName();
            Console.WriteLine("Pierwsze konto w systemie dostał(-a): {0}", fullName);

            SavingsAccount secondSavingsAccount = new SavingsAccount("940000000002", 0.0M, "Marek", "Zając", 92010133333);

            BillingAccount billingAccount = new BillingAccount("940000000003", 0.0M, savingsAccount.FirstName, savingsAccount.LastName, savingsAccount.Pesel);

            Printer printer = new Printer();
            printer.Print(savingsAccount);
            printer.Print(secondSavingsAccount);

            printer.Print(billingAccount);

            Console.ReadKey();
        }
    }
}
