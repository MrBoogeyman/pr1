using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Data *****\n");

            // Создать счет.
            SavingsAccount s1 = new SavingsAccount(50);

            // Вывести текущую процентную ставку.
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            // Попытаться изменить процетнтую ставку через свойство.
            SavingsAccount.SetInterestRate(0.08);

            // Создать второй счет.
            SavingsAccount s2 = new SavingsAccount(100);

            // Должно вывести 0.08... не так ли??
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            Console.ReadLine();
        }
    }
}
