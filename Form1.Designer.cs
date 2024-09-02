namespace CSC240GuessTheNumber
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtEnterNumber = new System.Windows.Forms.TextBox();
            this.lblWhatnumber = new System.Windows.Forms.Label();
            this.lblGuesses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(292, 237);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(197, 65);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Guess";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtEnterNumber
            // 
            this.txtEnterNumber.Location = new System.Drawing.Point(189, 176);
            this.txtEnterNumber.Name = "txtEnterNumber";
            this.txtEnterNumber.Size = new System.Drawing.Size(405, 20);
            this.txtEnterNumber.TabIndex = 1;
            // 
            // lblWhatnumber
            // 
            this.lblWhatnumber.AutoSize = true;
            this.lblWhatnumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatnumber.Location = new System.Drawing.Point(64, 22);
            this.lblWhatnumber.Name = "lblWhatnumber";
            this.lblWhatnumber.Size = new System.Drawing.Size(710, 79);
            this.lblWhatnumber.TabIndex = 2;
            this.lblWhatnumber.Text = "What\'s the Number?";
            // 
            // lblGuesses
            // 
            this.lblGuesses.AutoSize = true;
            this.lblGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuesses.Location = new System.Drawing.Point(324, 396);
            this.lblGuesses.Name = "lblGuesses";
            this.lblGuesses.Size = new System.Drawing.Size(165, 18);
            this.lblGuesses.TabIndex = 3;
            this.lblGuesses.Text = "You guessed 0 times";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGuesses);
            this.Controls.Add(this.lblWhatnumber);
            this.Controls.Add(this.txtEnterNumber);
            this.Controls.Add(this.btnCheck);
            this.Name = "Form1";
            this.Text = "Whats the Number Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtEnterNumber;
        private System.Windows.Forms.Label lblWhatnumber;
        private System.Windows.Forms.Label lblGuesses;
    }
}

