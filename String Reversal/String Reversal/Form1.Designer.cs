namespace String_Reversal
{
    partial class Form1
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
            this.ReversableString = new System.Windows.Forms.TextBox();
            this.labelForTextBox = new System.Windows.Forms.Label();
            this.Reverse = new System.Windows.Forms.Button();
            this.DisplayRevrseString = new System.Windows.Forms.Label();
            this.DisplayOfReverse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReversableString
            // 
            this.ReversableString.Location = new System.Drawing.Point(131, 77);
            this.ReversableString.Name = "ReversableString";
            this.ReversableString.Size = new System.Drawing.Size(168, 22);
            this.ReversableString.TabIndex = 0;
            this.ReversableString.TextChanged += new System.EventHandler(this.ReversableString_TextChanged);
            // 
            // labelForTextBox
            // 
            this.labelForTextBox.AutoSize = true;
            this.labelForTextBox.Location = new System.Drawing.Point(128, 58);
            this.labelForTextBox.Name = "labelForTextBox";
            this.labelForTextBox.Size = new System.Drawing.Size(162, 16);
            this.labelForTextBox.TabIndex = 1;
            this.labelForTextBox.Text = "Enter Joke to Be reversed";
            this.labelForTextBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // Reverse
            // 
            this.Reverse.Location = new System.Drawing.Point(172, 116);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(75, 23);
            this.Reverse.TabIndex = 2;
            this.Reverse.Text = "reverse";
            this.Reverse.UseVisualStyleBackColor = true;
            this.Reverse.Click += new System.EventHandler(this.Reverse_Click);
            // 
            // DisplayRevrseString
            // 
            this.DisplayRevrseString.AutoSize = true;
            this.DisplayRevrseString.Location = new System.Drawing.Point(188, 210);
            this.DisplayRevrseString.Name = "DisplayRevrseString";
            this.DisplayRevrseString.Size = new System.Drawing.Size(0, 16);
            this.DisplayRevrseString.TabIndex = 4;
            // 
            // DisplayOfReverse
            // 
            this.DisplayOfReverse.AutoSize = true;
            this.DisplayOfReverse.Location = new System.Drawing.Point(148, 194);
            this.DisplayOfReverse.Name = "DisplayOfReverse";
            this.DisplayOfReverse.Size = new System.Drawing.Size(136, 16);
            this.DisplayOfReverse.TabIndex = 5;
            this.DisplayOfReverse.Text = "String Displayed here";
            this.DisplayOfReverse.Click += new System.EventHandler(this.DisplayOfReverse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.DisplayOfReverse);
            this.Controls.Add(this.DisplayRevrseString);
            this.Controls.Add(this.Reverse);
            this.Controls.Add(this.labelForTextBox);
            this.Controls.Add(this.ReversableString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReversableString;
        private System.Windows.Forms.Label labelForTextBox;
        private System.Windows.Forms.Button Reverse;
        private System.Windows.Forms.Label DisplayRevrseString;
        private System.Windows.Forms.Label DisplayOfReverse;
    }
}

