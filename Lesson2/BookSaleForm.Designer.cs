﻿namespace Lesson2
{
    partial class BookSaleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DiscountedPriceTextBox = new System.Windows.Forms.TextBox();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.ExtendedPriceTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.QuantitySumTextBox = new System.Windows.Forms.TextBox();
            this.DiscountSumTextbox = new System.Windows.Forms.TextBox();
            this.DiscountAmountTextbox = new System.Windows.Forms.TextBox();
            this.AverageDiscountTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Sales";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PriceTextBox);
            this.groupBox1.Controls.Add(this.TitleTextBox);
            this.groupBox1.Controls.Add(this.QuantityTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(34, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(64, 81);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(58, 20);
            this.PriceTextBox.TabIndex = 2;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(64, 50);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(226, 20);
            this.TitleTextBox.TabIndex = 1;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(64, 19);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(58, 20);
            this.QuantityTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "&Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Quantity";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.DiscountedPriceTextBox);
            this.groupBox2.Controls.Add(this.DiscountTextBox);
            this.groupBox2.Controls.Add(this.ExtendedPriceTextBox);
            this.groupBox2.Location = new System.Drawing.Point(34, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 106);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Discounted Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "15% Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Extended Price";
            // 
            // DiscountedPriceTextBox
            // 
            this.DiscountedPriceTextBox.Location = new System.Drawing.Point(197, 71);
            this.DiscountedPriceTextBox.Name = "DiscountedPriceTextBox";
            this.DiscountedPriceTextBox.ReadOnly = true;
            this.DiscountedPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiscountedPriceTextBox.TabIndex = 2;
            this.DiscountedPriceTextBox.TabStop = false;
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Location = new System.Drawing.Point(197, 45);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.ReadOnly = true;
            this.DiscountTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiscountTextBox.TabIndex = 1;
            this.DiscountTextBox.TabStop = false;
            // 
            // ExtendedPriceTextBox
            // 
            this.ExtendedPriceTextBox.Location = new System.Drawing.Point(197, 19);
            this.ExtendedPriceTextBox.Name = "ExtendedPriceTextBox";
            this.ExtendedPriceTextBox.ReadOnly = true;
            this.ExtendedPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.ExtendedPriceTextBox.TabIndex = 0;
            this.ExtendedPriceTextBox.TabStop = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(67, 423);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "&Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(150, 423);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear &Sale";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(231, 423);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AverageDiscountTextbox);
            this.groupBox3.Controls.Add(this.DiscountAmountTextbox);
            this.groupBox3.Controls.Add(this.DiscountSumTextbox);
            this.groupBox3.Controls.Add(this.QuantitySumTextBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(34, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 137);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Summary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Number of Books";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Total Discounts Given";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total Discounted Amounts";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Average Discount";
            // 
            // QuantitySumTextBox
            // 
            this.QuantitySumTextBox.Location = new System.Drawing.Point(197, 25);
            this.QuantitySumTextBox.Name = "QuantitySumTextBox";
            this.QuantitySumTextBox.ReadOnly = true;
            this.QuantitySumTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantitySumTextBox.TabIndex = 4;
            this.QuantitySumTextBox.TabStop = false;
            // 
            // DiscountSumTextbox
            // 
            this.DiscountSumTextbox.Location = new System.Drawing.Point(197, 51);
            this.DiscountSumTextbox.Name = "DiscountSumTextbox";
            this.DiscountSumTextbox.ReadOnly = true;
            this.DiscountSumTextbox.Size = new System.Drawing.Size(100, 20);
            this.DiscountSumTextbox.TabIndex = 5;
            this.DiscountSumTextbox.TabStop = false;
            // 
            // DiscountAmountTextbox
            // 
            this.DiscountAmountTextbox.Location = new System.Drawing.Point(197, 77);
            this.DiscountAmountTextbox.Name = "DiscountAmountTextbox";
            this.DiscountAmountTextbox.ReadOnly = true;
            this.DiscountAmountTextbox.Size = new System.Drawing.Size(100, 20);
            this.DiscountAmountTextbox.TabIndex = 6;
            this.DiscountAmountTextbox.TabStop = false;
            // 
            // AverageDiscountTextbox
            // 
            this.AverageDiscountTextbox.Location = new System.Drawing.Point(197, 103);
            this.AverageDiscountTextbox.Name = "AverageDiscountTextbox";
            this.AverageDiscountTextbox.ReadOnly = true;
            this.AverageDiscountTextbox.Size = new System.Drawing.Size(100, 20);
            this.AverageDiscountTextbox.TabIndex = 7;
            this.AverageDiscountTextbox.TabStop = false;
            // 
            // BookSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 457);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "BookSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R \'n R for Reading and Refreshment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DiscountedPriceTextBox;
        private System.Windows.Forms.TextBox DiscountTextBox;
        private System.Windows.Forms.TextBox ExtendedPriceTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox AverageDiscountTextbox;
        private System.Windows.Forms.TextBox DiscountAmountTextbox;
        private System.Windows.Forms.TextBox DiscountSumTextbox;
        private System.Windows.Forms.TextBox QuantitySumTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

