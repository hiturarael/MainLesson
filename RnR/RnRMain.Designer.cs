namespace RnR
{
    partial class MainForm
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
            this.BooksButton = new System.Windows.Forms.Button();
            this.MusicButton = new System.Windows.Forms.Button();
            this.PeriodicalsButton = new System.Windows.Forms.Button();
            this.CoffeeBarButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PromotionalLabel = new System.Windows.Forms.Label();
            this.PromotionCodeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BooksButton
            // 
            this.BooksButton.Location = new System.Drawing.Point(22, 66);
            this.BooksButton.Name = "BooksButton";
            this.BooksButton.Size = new System.Drawing.Size(75, 23);
            this.BooksButton.TabIndex = 0;
            this.BooksButton.Text = "Books";
            this.BooksButton.UseVisualStyleBackColor = true;
            this.BooksButton.Click += new System.EventHandler(this.BooksButton_Click);
            // 
            // MusicButton
            // 
            this.MusicButton.Location = new System.Drawing.Point(22, 95);
            this.MusicButton.Name = "MusicButton";
            this.MusicButton.Size = new System.Drawing.Size(75, 23);
            this.MusicButton.TabIndex = 1;
            this.MusicButton.Text = "Music";
            this.MusicButton.UseVisualStyleBackColor = true;
            this.MusicButton.Click += new System.EventHandler(this.MusicButton_Click);
            // 
            // PeriodicalsButton
            // 
            this.PeriodicalsButton.Location = new System.Drawing.Point(22, 124);
            this.PeriodicalsButton.Name = "PeriodicalsButton";
            this.PeriodicalsButton.Size = new System.Drawing.Size(75, 23);
            this.PeriodicalsButton.TabIndex = 2;
            this.PeriodicalsButton.Text = "Periodicals";
            this.PeriodicalsButton.UseVisualStyleBackColor = true;
            this.PeriodicalsButton.Click += new System.EventHandler(this.PeriodicalsButton_Click);
            // 
            // CoffeeBarButton
            // 
            this.CoffeeBarButton.Location = new System.Drawing.Point(22, 153);
            this.CoffeeBarButton.Name = "CoffeeBarButton";
            this.CoffeeBarButton.Size = new System.Drawing.Size(75, 23);
            this.CoffeeBarButton.TabIndex = 3;
            this.CoffeeBarButton.Text = "Coffee Bar";
            this.CoffeeBarButton.UseVisualStyleBackColor = true;
            this.CoffeeBarButton.Click += new System.EventHandler(this.CoffeeBarButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(22, 208);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Promotion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Promotion Code";
            // 
            // PromotionalLabel
            // 
            this.PromotionalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PromotionalLabel.Location = new System.Drawing.Point(267, 71);
            this.PromotionalLabel.Name = "PromotionalLabel";
            this.PromotionalLabel.Size = new System.Drawing.Size(304, 23);
            this.PromotionalLabel.TabIndex = 7;
            this.PromotionalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PromotionCodeLabel
            // 
            this.PromotionCodeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PromotionCodeLabel.Location = new System.Drawing.Point(267, 100);
            this.PromotionCodeLabel.Name = "PromotionCodeLabel";
            this.PromotionCodeLabel.Size = new System.Drawing.Size(304, 23);
            this.PromotionCodeLabel.TabIndex = 8;
            this.PromotionCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Programmed by Hitura Rael";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 281);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PromotionCodeLabel);
            this.Controls.Add(this.PromotionalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CoffeeBarButton);
            this.Controls.Add(this.PeriodicalsButton);
            this.Controls.Add(this.MusicButton);
            this.Controls.Add(this.BooksButton);
            this.Name = "MainForm";
            this.Text = "R \'n R -- For Reading and Refreshment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BooksButton;
        private System.Windows.Forms.Button MusicButton;
        private System.Windows.Forms.Button PeriodicalsButton;
        private System.Windows.Forms.Button CoffeeBarButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PromotionalLabel;
        private System.Windows.Forms.Label PromotionCodeLabel;
        private System.Windows.Forms.Label label3;
    }
}

