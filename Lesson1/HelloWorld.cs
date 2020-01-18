using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PushButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "Hello World!";
        }


        private void SpanishButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "Hola Mundo";
        }
    }
}
