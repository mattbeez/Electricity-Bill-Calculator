using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Electricity Bill Calculator (Customer Setup) - Apr. 28th, 2021 - Matt Biesbroek - */

namespace BillCalculator
{
    public class Customer
    {
        public static decimal AdminFee = 12.0m;
        public static decimal UseageFee = 0.07m;
        public int NewAcct { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal KwhUsed { get; set; }

        public decimal BillAmount { get; set; }

        
        public Customer(int AccountNo, string Fname, string Lname, decimal Kused)
        {
            NewAcct = AccountNo;
            FirstName = Fname;
            LastName = Lname;
            KwhUsed = Kused;
            BillAmount = CalculateCharge();

        }
        
        //Calculates the total bill charge
        public decimal CalculateCharge()
        {
            return AdminFee + (KwhUsed * UseageFee);
        }
        public override string ToString()
        {
            return "Account " + NewAcct.ToString() + " : " + FirstName.ToString() + " " + LastName.ToString() + " - " + KwhUsed.ToString() + " kWh Used " + " - " + BillAmount.ToString("C");
        }
    }
}