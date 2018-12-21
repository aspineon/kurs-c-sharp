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
            AccountsManager manager = new AccountsManager();

            manager.CreateBillingAccount("Marek", "Zajac", 1234567890);
            manager.CreateSavingsAccount("Marek", "Zajac", 1234567890);
            manager.CreateSavingsAccount("Aaaaa", "Bbbbb", 0987654321);

            IEnumerable<string> users = manager.ListOfCustomers();

            foreach (string user in users)
            {
                Console.WriteLine(user);
            }

            Console.ReadKey();
        }
    }
}
