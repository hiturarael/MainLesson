using System;
using System.Windows.Forms;

/* Project:     Lesson 1 Hands on
 * Programmer:  Hitura Rael
 * Date:        1/18/2020
 * Description: This project displays current promotions for each department
*/

namespace RnR
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Executes books button click
        private void BooksButton_Click(object sender, EventArgs e)
        {
            PromotionalLabel.Text = "Buy two, get the second one for half price";
            PromotionCodeLabel.Text = "B608";
        }

        //Executes music button click
        private void MusicButton_Click(object sender, EventArgs e)
        {
            PromotionalLabel.Text = "Get a free MP3 download with purchase of a CD";
            PromotionCodeLabel.Text = "M608";
        }

        //Executes periodicals button click
        private void PeriodicalsButton_Click(object sender, EventArgs e)
        {
            PromotionalLabel.Text = "Elite members recieve 10% off every purchase";
            PromotionCodeLabel.Text = "P608";
        }

        //Executes coffee bar button click
        private void CoffeeBarButton_Click(object sender, EventArgs e)
        {
            PromotionalLabel.Text = "Celebrate the season with 20% off specialty drinks";
            PromotionCodeLabel.Text = "C608";
        }

        //Exits the program
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
