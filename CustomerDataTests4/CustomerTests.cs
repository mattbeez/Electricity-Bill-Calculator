using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Electricity Bill Calculator (Class Tests) - Apr. 28th, 2021 - Matt Biesbroek - */

namespace BillCalculator
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void CustomerTest()
        {
            // Arrange
            int account = 5;
            string fname = "John";
            string lname = "Smith";
            int kwh = 250;

            // Act
            Customer cust = new Customer(account, fname, lname, kwh);

            // Assert
            Assert.AreEqual(5, cust.NewAcct);
            Assert.AreEqual("John", cust.FirstName);
            Assert.AreEqual("Smith", cust.LastName);
            Assert.AreEqual(250, cust.KwhUsed);
        }

        [TestMethod()]
        public void CalculateCharge()
        {
            // Arrange
            int account = 5;
            string fname = "Bill";
            string lname = "James";
            decimal kwh1 = 500m;
            decimal kwh2 = 250m;
            decimal kwh3 = 325m;
            decimal exp1 = 12 + (500m * 0.07m);
            decimal exp2 = 12 + (250m * 0.07m);
            decimal exp3 = 12 + (325m * 0.07m);

            // Act
            Customer cust = new Customer(account, fname, lname, kwh1);
            decimal charge1 = cust.CalculateCharge();
            cust = new Customer(account, fname, lname, kwh2);
            decimal charge2 = cust.CalculateCharge();
            cust = new Customer(account, fname, lname, kwh3);
            decimal charge3 = cust.CalculateCharge();

            // Assert
            Assert.AreEqual(exp1, charge1);
            Assert.AreEqual(exp2, charge2);
            Assert.AreEqual(exp3, charge3);
        }
    }
}