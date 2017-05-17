using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanksDeposit
{
    class Deposit
    {
        private Bank _bank;
        private Customer _customer;
        public Deposit(Bank bank, Customer customer)
        {
            _bank = bank;
            _customer = customer;
        }
        public int TotalAmount { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public int PeriodInMonths { get; set; }
        public int DurationInMonths { get; set; }

        public decimal CustomerAccount { get; set; }

        public void GiveAmount(decimal amount)
        {
            this.CustomerAccount += amount;
        }


        public decimal CalculateProfitInBreak()// hashvum e xzelis avelacac gumar@
        {
            var month = ((DateTimeOffset.Now - this.StartDate).TotalDays) / 30; //gtnelu hamar qani amis e
            var totalMonth = this.DurationInMonths - month;

            var amontInBreak = Convert.ToInt32(totalMonth * this.TotalAmount * _bank.Percentage / 100);// xzelu pahin avelaac gumar@
               
            return amontInBreak;
        }
    }
}
