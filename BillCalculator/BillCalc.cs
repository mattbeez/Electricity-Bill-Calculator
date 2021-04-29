using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Electricity Bill Calculator - Apr. 28th, 2021 - Matt Biesbroek - */ 

namespace BillCalculator
{
    public partial class BillCalc : Form
    {
        public decimal TotalKWH { get; set; }
        public decimal AverageBill { get; set; }
        public decimal TotalCust { get; set; }

        private int AccountNo = 2500;
        
        private List<Customer> accounts;
        public BillCalc()
        {
            InitializeComponent();
        }
        //Resets Text Boxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            BoxClear();
        }
        //Inital Form Load
        private void BillCalc_Load(object sender, EventArgs e)
        {
            TotalKWH = 0;
            AverageBill = 0;
            lblAvgBill.Text = AverageBill.ToString("C");
            lblTotalKWH.Text = TotalKWH.ToString("F") + " KWH";
            accounts = new List<Customer>();
        }

       //Adds customer info to List Box
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Checks if the required fields are filled out
            if (txtFname.Text == "")
            {
                MessageBox.Show("Please enter your first name.", "Error");
                txtFname.Focus();
                return;
            }
            else if (txtLname.Text == "")
            {
                MessageBox.Show("Please enter your last name.", "Error");
                txtLname.Focus();
                return;
            }
            else if (txtKWH.Text == "")
            {
                MessageBox.Show("Please enter your kWh used.", "Error");
                txtKWH.Focus();
                return;
            }

            decimal Kused = decimal.Parse(txtKWH.Text);
            
            //Creates a new account that is added to the list box
            Customer newCust = new Customer(AccountNo, txtFname.Text, txtLname.Text, Kused);
            accounts.Add(newCust);

            //Displays each new customer in list box
            listCust.Items.Add(newCust.ToString());

            //Calculates the total kWH used
            TotalKWH += Kused;
            
            //Calculating Average Bill Cost
            TotalCust = (accounts.Count * Customer.AdminFee) + (TotalKWH * Customer.UseageFee);
            AverageBill = TotalCust / accounts.Count;
            
            //Incrementing set account number (2500) by 1 with each customer added
            AccountNo++;
                        
            BoxClear();
            txtFname.Focus();
            lblAvgBill.Text = AverageBill.ToString("C");
            lblTotalKWH.Text = TotalKWH.ToString("F") + " KWH";
            lblTotalCusts.Text = accounts.Count.ToString();
            

        }
        
        //Only allows numeric entries to KWH text box.  Prompts error if a letter is entered.
        private void txtKWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                MessageBox.Show("This must be a numeric value.", "Error");
                e.Handled = true;
            }

            // Allows for one decimal point, if needed.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {

                e.Handled = true;
            }
        }
        
        //Only allows for letter enteries to First Name box.  Prompts error if a number is entered.
        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                MessageBox.Show("This does not accept a numeric value.", "Error");
                e.Handled = true;
            }

        }
        
        //Only allows for letter enteries to Last Name box.  Prompts error if a number is entered.
        private void txtLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                MessageBox.Show("This does not accept a numeric value.", "Error");
                e.Handled = true;
            }

        }
        //Clears values from text boxes.  Used when clicking "add" or "reset" button
        private void BoxClear()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtKWH.Text = "";            
        }
        //Exits application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
