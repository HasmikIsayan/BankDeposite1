using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanksDeposit
{
    class Bank
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int MinAmount { get; set; }//bankum pahelu minimal gumari chap
        public int MaxAmount { get; set; }//sa ayn maqsimal gumarn e, vor kareli e bankum pahel
        public int Percentage { get; set; }//
        public Currency Currency { get; set; }
        public List<Deposit> Deposits = new List<Deposit>();
        public List<Customer> Customers = new List<Customer>();

        public Deposit DepositFormulate(Customer customer, DepositContract depositContract)// avandi dzevakerpum
        {
            if(depositContract.Amount > this.MaxAmount || depositContract.Amount < this.MinAmount) { return null; }
            Deposit deposit = new Deposit(this, customer)
            {
                StartDate = DateTimeOffset.Now,
                DurationInMonths = depositContract.DurationInMonths,
                TotalAmount = depositContract.Amount,
                PeriodInMonths = 1,//aysinqn avandi tokosadruyq@ karox enq amsekan stanal
            };

            Customers.Add(customer);
            Deposits.Add(deposit);
            customer.Deposits.Add(deposit);

           
            return deposit;
        }






    }
}
