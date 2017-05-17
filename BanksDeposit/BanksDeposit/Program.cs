using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanksDeposit 
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();
            var customer = new Customer();
            var depositContract = new DepositContract()
            {
                Amount = 1000000,
                DurationInMonths = 24
            };

            var deposit = bank.DepositFormulate(customer, depositContract);

            if (deposit == null)
            {
                Console.WriteLine("Duq hanravorutyun chuneq nshvac gumar@ 2 tarov avand dzevakerpel");
            }
            else
            {


            }
        }
    }
}
