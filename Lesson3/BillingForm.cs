using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3
{
    public partial class BillingForm : Form
    {
        const decimal TAX_RATE = 0.08M;
        const decimal CAPPUCCINO_PRICE = 2.0M;
        const decimal ESPRESSO_PRICE = 2.25M;
        const decimal LATTE_PRICE = 1.75M;
        const decimal ICED_PRICE = 2.5M;

        private decimal subTotal, total, grandTotal;
        private int customerCount;

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //Declare public variables for price, tax, item amount, and quantity for the transaction.
            decimal itemAmount = 0m, price = 0m, tax = 0m;
            int quantity = 0;

            //Get the cost of the selected item
            if (CappuccinoRadioButton.Checked)
            {
                price = CAPPUCCINO_PRICE;
            }
            else if (EspressoRadioButton.Checked)
            {
                price = ESPRESSO_PRICE;
            }
            else if (LatteRadioButton.Checked)
            {
                price = LATTE_PRICE;
            }
            else if (IcedLatteRadioButton.Checked || IcedCappuccinoRadioButton.Checked)
            {
                price = ICED_PRICE;
            }

            //enter try
            try
            {

                //Set the quantity based on the amount in the textbox
                quantity = int.Parse(QuantityTextBox.Text);

                //get item amount total ( price * quantity)
                itemAmount = price * quantity;

                //set subtotal to item amount
                subTotal += itemAmount;

                //check if takeout is checked
                //if takeout is checked, tax = subtotal * tax rate
                //else tax = 0
                if(TaxCheckBox.Checked)
                {
                    tax = subTotal * TAX_RATE;
                } else
                {
                    tax = 0;
                }

                //total = subtotal + tax
                total = subTotal + tax;

                //output item amount to item amount textbox
                ItemAmountTextBox.Text = itemAmount.ToString("C");

                //output tax to tax textbox
                TaxTextBox.Text = tax.ToString("N");

                //output subtotal to subtotal textbox
                SubtotalTextBox.Text = subTotal.ToString("N");

                //output total to total due textbox
                TotalTextBox.Text = total.ToString("C");

                //disable the takeout checkbox
                TaxCheckBox.Enabled = false;

                //enable the clear button
                ClearButton.Enabled = true;

                //enable the new order button
                NewOrderButton.Enabled = true;

                //exit try enter catch
                //catch quantity exception
            }
            catch (FormatException)
            {
                //Display message box
                MessageBox.Show("Quantity must be numeric.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                //focus the quantity textbox, select all text in textbox
                QuantityTextBox.Focus();
                QuantityTextBox.SelectAll();

                //end try
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //reset cappuccino button to checked.
            CappuccinoRadioButton.Checked = true;

            //clear item amount text box
            ItemAmountTextBox.Text = "";

            //clear quantity textbox
            QuantityTextBox.Text = "";

            //set focus on quantity textbox
            QuantityTextBox.Focus();
        }


        public BillingForm()
        {
            InitializeComponent();
        }
    }
}
