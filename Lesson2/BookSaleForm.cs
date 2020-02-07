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
        private int saleCount = 0, quantityCount = 0;
        private decimal discountSum = 0, DiscountedPriceSum;

        public BookSaleForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //instantiate variables
            int quantity = 0;
            decimal price = 0, extendedPrice = 0, discount = 0, discountedPrice = 0, discountAverage = 0;

            try
            {
                //set values per textbox
                //quantity from quantity textbox

                quantity = int.Parse(QuantityTextBox.Text);
                try
                {
                    //price from price textbox.
                    price = decimal.Parse(PriceTextBox.Text);

                    //calculate values
                    //extended price = quantity * price
                    //discount = extended price * discount rate (round to 2 decimal places)
                    //discounted price = extended price - discount
                    extendedPrice = quantity * price;
                    discount = Math.Round(extendedPrice * DISCOUNT_RATE, 2);
                    discountedPrice = extendedPrice - discount;

                    //Calculate the summary info
                    //Add quantity
                    //Increment sale
                    //Calculate discount price
                    //Calculate average discount

                    quantityCount += quantity;
                    discountSum += discount;
                    DiscountedPriceSum += discountedPrice;
                    saleCount++;
                    discountAverage = discountSum / saleCount;

                    //display results
                    //extended price as currency
                    //discount as number
                    //discounted price as currency
                    ExtendedPriceTextBox.Text = extendedPrice.ToString("C");
                    DiscountTextBox.Text = discount.ToString("N");
                    DiscountedPriceTextBox.Text = discountedPrice.ToString("C");

                    //format summary
                    QuantitySumTextBox.Text = quantityCount.ToString();
                    DiscountSumTextbox.Text = discountSum.ToString("C");
                    DiscountAmountTextbox.Text = DiscountedPriceSum.ToString("C");
                    AverageDiscountTextbox.Text = discountAverage.ToString("C");

                }
                catch (FormatException priceException)
                {
                    MessageBox.Show("Price must be numeric.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (FormatException QuantityException)
            {
                MessageBox.Show("Quantity must be numeric", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
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
