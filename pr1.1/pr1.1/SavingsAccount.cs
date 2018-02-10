using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1._1
{
    class SavingsAccount
    {
        // Данные уровня экземпляра.
        public Double currBalance;
        public static double currInteresеtRate;

        // Статический элемент данных.
        public static Double currInterestRate = 0.04;
        public SavingsAccount(double balance)
        {
            currInterestRate = 0.04; // Это статические данные!
            currBalance = balance;
        }
        
        // Статические члены для установки/получения процентной ставки.
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }
        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}
