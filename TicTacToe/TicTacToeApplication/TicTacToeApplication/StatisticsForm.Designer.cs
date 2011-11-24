namespace TicTacToeApplication
{
    partial class StatisticsForm
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
            this.StatisticsMessage = new System.Windows.Forms.Label();
            this.PlayAgain = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.WinnerMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatisticsMessage
            // 
            this.StatisticsMessage.AutoSize = true;
            this.StatisticsMessage.Location = new System.Drawing.Point(133, 72);
            this.StatisticsMessage.Name = "StatisticsMessage";
            this.StatisticsMessage.Size = new System.Drawing.Size(44, 13);
            this.StatisticsMessage.TabIndex = 0;
            this.StatisticsMessage.Text = "Nothing";
            this.StatisticsMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlayAgain
            // 
            this.PlayAgain.AutoSize = true;
            this.PlayAgain.Location = new System.Drawing.Point(109, 161);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(136, 13);
            this.PlayAgain.TabIndex = 1;
            this.PlayAgain.Text = "Do you want to play again?";
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(52, 208);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(103, 31);
            this.YesButton.TabIndex = 2;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(193, 208);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(103, 31);
            this.NoButton.TabIndex = 3;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // WinnerMessage
            // 
            this.WinnerMessage.AutoSize = true;
            this.WinnerMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerMessage.Location = new System.Drawing.Point(79, 23);
            this.WinnerMessage.Name = "WinnerMessage";
            this.WinnerMessage.Size = new System.Drawing.Size(76, 24);
            this.WinnerMessage.TabIndex = 4;
            this.WinnerMessage.Text = "Nothing";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 262);
            this.Controls.Add(this.WinnerMessage);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.StatisticsMessage);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatisticsMessage;
        private System.Windows.Forms.Label PlayAgain;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Label WinnerMessage;
    }
}