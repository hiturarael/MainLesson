﻿namespace Lesson3
{
    partial class BillingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ItemAmountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.TaxCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IcedCappuccinoRadioButton = new System.Windows.Forms.RadioButton();
            this.IcedLatteRadioButton = new System.Windows.Forms.RadioButton();
            this.LatteRadioButton = new System.Windows.Forms.RadioButton();
            this.EspressoRadioButton = new System.Windows.Forms.RadioButton();
            this.CappuccinoRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ItemAmountTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.CalculateButton);
            this.groupBox1.Controls.Add(this.QuantityTextBox);
            this.groupBox1.Controls.Add(this.TaxCheckBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(23, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            // 
            // ItemAmountTextBox
            // 
            this.ItemAmountTextBox.Enabled = false;
            this.ItemAmountTextBox.Location = new System.Drawing.Point(78, 131);
            this.ItemAmountTextBox.Name = "ItemAmountTextBox";
            this.ItemAmountTextBox.Size = new System.Drawing.Size(84, 20);
            this.ItemAmountTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Amount";
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.Location = new System.Drawing.Point(87, 84);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 40);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "C&lear for Next Item";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(6, 84);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 40);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "&Calculate Selection";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(58, 35);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantityTextBox.TabIndex = 3;
            // 
            // TaxCheckBox
            // 
            this.TaxCheckBox.AutoSize = true;
            this.TaxCheckBox.Location = new System.Drawing.Point(6, 61);
            this.TaxCheckBox.Name = "TaxCheckBox";
            this.TaxCheckBox.Size = new System.Drawing.Size(72, 17);
            this.TaxCheckBox.TabIndex = 2;
            this.TaxCheckBox.Text = "Ta&keout?";
            this.TaxCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Quantity";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IcedCappuccinoRadioButton);
            this.groupBox2.Controls.Add(this.IcedLatteRadioButton);
            this.groupBox2.Controls.Add(this.LatteRadioButton);
            this.groupBox2.Controls.Add(this.EspressoRadioButton);
            this.groupBox2.Controls.Add(this.CappuccinoRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(193, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coffee Selections";
            // 
            // IcedCappuccinoRadioButton
            // 
            this.IcedCappuccinoRadioButton.AutoSize = true;
            this.IcedCappuccinoRadioButton.Location = new System.Drawing.Point(6, 111);
            this.IcedCappuccinoRadioButton.Name = "IcedCappuccinoRadioButton";
            this.IcedCappuccinoRadioButton.Size = new System.Drawing.Size(106, 17);
            this.IcedCappuccinoRadioButton.TabIndex = 4;
            this.IcedCappuccinoRadioButton.TabStop = true;
            this.IcedCappuccinoRadioButton.Text = "Iced Ca&ppuccino";
            this.IcedCappuccinoRadioButton.UseVisualStyleBackColor = true;
            // 
            // IcedLatteRadioButton
            // 
            this.IcedLatteRadioButton.AutoSize = true;
            this.IcedLatteRadioButton.Location = new System.Drawing.Point(6, 88);
            this.IcedLatteRadioButton.Name = "IcedLatteRadioButton";
            this.IcedLatteRadioButton.Size = new System.Drawing.Size(73, 17);
            this.IcedLatteRadioButton.TabIndex = 3;
            this.IcedLatteRadioButton.TabStop = true;
            this.IcedLatteRadioButton.Text = "&Iced Latte";
            this.IcedLatteRadioButton.UseVisualStyleBackColor = true;
            // 
            // LatteRadioButton
            // 
            this.LatteRadioButton.AutoSize = true;
            this.LatteRadioButton.Location = new System.Drawing.Point(6, 65);
            this.LatteRadioButton.Name = "LatteRadioButton";
            this.LatteRadioButton.Size = new System.Drawing.Size(49, 17);
            this.LatteRadioButton.TabIndex = 2;
            this.LatteRadioButton.TabStop = true;
            this.LatteRadioButton.Text = "La&tte";
            this.LatteRadioButton.UseVisualStyleBackColor = true;
            // 
            // EspressoRadioButton
            // 
            this.EspressoRadioButton.AutoSize = true;
            this.EspressoRadioButton.Location = new System.Drawing.Point(6, 42);
            this.EspressoRadioButton.Name = "EspressoRadioButton";
            this.EspressoRadioButton.Size = new System.Drawing.Size(68, 17);
            this.EspressoRadioButton.TabIndex = 1;
            this.EspressoRadioButton.TabStop = true;
            this.EspressoRadioButton.Text = "Espress&o";
            this.EspressoRadioButton.UseVisualStyleBackColor = true;
            // 
            // CappuccinoRadioButton
            // 
            this.CappuccinoRadioButton.AutoSize = true;
            this.CappuccinoRadioButton.Location = new System.Drawing.Point(6, 19);
            this.CappuccinoRadioButton.Name = "CappuccinoRadioButton";
            this.CappuccinoRadioButton.Size = new System.Drawing.Size(82, 17);
            this.CappuccinoRadioButton.TabIndex = 0;
            this.CappuccinoRadioButton.TabStop = true;
            this.CappuccinoRadioButton.Text = "C&appuccino";
            this.CappuccinoRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TotalTextBox);
            this.groupBox3.Controls.Add(this.SubtotalTextBox);
            this.groupBox3.Controls.Add(this.TaxTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(22, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 112);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Enabled = false;
            this.TotalTextBox.Location = new System.Drawing.Point(111, 74);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(79, 20);
            this.TotalTextBox.TabIndex = 5;
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.Enabled = false;
            this.SubtotalTextBox.Location = new System.Drawing.Point(111, 13);
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.Size = new System.Drawing.Size(79, 20);
            this.SubtotalTextBox.TabIndex = 4;
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.Enabled = false;
            this.TaxTextBox.Location = new System.Drawing.Point(111, 43);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.Size = new System.Drawing.Size(79, 20);
            this.TaxTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Due";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tax (If Takeout)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subtotal";
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Enabled = false;
            this.NewOrderButton.Location = new System.Drawing.Point(23, 314);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(75, 23);
            this.NewOrderButton.TabIndex = 3;
            this.NewOrderButton.Text = "&New Order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(302, 314);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(160, 314);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(75, 23);
            this.SummaryButton.TabIndex = 5;
            this.SummaryButton.Text = "&Summary";
            this.SummaryButton.UseVisualStyleBackColor = true;
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 360);
            this.Controls.Add(this.SummaryButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "BillingForm";
            this.Text = "R \'n R -- for Reading \'n Refreshment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ItemAmountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.CheckBox TaxCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton IcedCappuccinoRadioButton;
        private System.Windows.Forms.RadioButton IcedLatteRadioButton;
        private System.Windows.Forms.RadioButton LatteRadioButton;
        private System.Windows.Forms.RadioButton EspressoRadioButton;
        private System.Windows.Forms.RadioButton CappuccinoRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox SubtotalTextBox;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SummaryButton;
    }
}

