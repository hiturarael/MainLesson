using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class BookSaleForm : Form
    {
        const decimal DISCOUNT_RATE = 0.15M;

        public BookSaleForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //instantiate variables
            int quantity;
            decimal price, extendedPrice, discount, discountedPrice;

            //set values per textbox
                //quantity from quantity textbox
                //price from price textbox.
            quantity = int.Parse(QuantityTextBox.Text);
            price = decimal.Parse(PriceTextBox.Text);

            //calculate values
                //extended price = quantity * price
                //discount = extended price * discount rate (round to 2 decimal places)
                //discounted price = extended price - discount
            extendedPrice = quantity * price;
            discount = Math.Round(extendedPrice * DISCOUNT_RATE, 2);
            discountedPrice = extendedPrice - discount;

            //display results
            //extended price as currency
            //discount as number
            //discounted price as currency
            ExtendedPriceTextBox.Text = extendedPrice.ToString("C");
            DiscountTextBox.Text = discount.ToString("N");
            DiscountedPriceTextBox.Text = discountedPrice.ToString("C");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clear Textboxes
            TitleTextBox.Clear();
            PriceTextBox.Clear();
            ExtendedPriceTextBox.Clear();
            DiscountedPriceTextBox.Clear();
            DiscountTextBox.Clear();
            QuantityTextBox.Clear();

            //Set focus on Quantity
            QuantityTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
