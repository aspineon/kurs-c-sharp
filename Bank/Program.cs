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

            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.AccountNumber = "940000000001";
            savingsAccount.Balance = 0.0M;
            savingsAccount.FirstName = "Marek";
            savingsAccount.LastName = "Za";
            savingsAccount.Pesel = 12345678909;

            SavingsAccount secondSavingsAccount = new SavingsAccount();
            secondSavingsAccount.AccountNumber = "940000000002";
            secondSavingsAccount.Balance = 0.0M;
            secondSavingsAccount.FirstName = "Jarek";
            secondSavingsAccount.LastName = "Zając";
            secondSavingsAccount.Pesel = 12345543211;

            BillingAccount billingAccount = new BillingAccount();
            billingAccount.AccountNumber = "940000000003";
            billingAccount.Balance = 0.0M;
            billingAccount.FirstName = savingsAccount.FirstName;
            billingAccount.LastName = savingsAccount.LastName;
            billingAccount.Pesel = savingsAccount.Pesel;

            Console.WriteLine("Dane konta:");
            Console.WriteLine("Numer konta: {0}", savingsAccount.AccountNumber);
            Console.WriteLine("Saldo: {0}zł", savingsAccount.Balance);
            Console.WriteLine("Imię właściciela: {0}", savingsAccount.FirstName);
            Console.WriteLine("Nazwisko właściciela: {0}", savingsAccount.LastName);
            Console.WriteLine("PESEL właściciela: {0}", savingsAccount.Pesel);

            Console.WriteLine("Dane konta:");
            Console.WriteLine("Numer konta: {0}", secondSavingsAccount.AccountNumber);
            Console.WriteLine("Saldo: {0}zł", secondSavingsAccount.Balance);
            Console.WriteLine("Imię właściciela: {0}", secondSavingsAccount.FirstName);
            Console.WriteLine("Nazwisko właściciela: {0}", secondSavingsAccount.LastName);
            Console.WriteLine("PESEL właściciela: {0}", secondSavingsAccount.Pesel);

            Console.WriteLine("Dane konta:");
            Console.WriteLine("Numer konta: {0}", billingAccount.AccountNumber);
            Console.WriteLine("Saldo: {0}zł", billingAccount.Balance);
            Console.WriteLine("Imię właściciela: {0}", billingAccount.FirstName);
            Console.WriteLine("Nazwisko właściciela: {0}", billingAccount.LastName);
            Console.WriteLine("PESEL właściciela: {0}", billingAccount.Pesel);

            Console.ReadKey();
        }
    }
}
