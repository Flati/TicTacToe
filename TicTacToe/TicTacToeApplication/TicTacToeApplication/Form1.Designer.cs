namespace TicTacToeApplication
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopLeft = new System.Windows.Forms.Button();
            this.BottomCenter = new System.Windows.Forms.Button();
            this.MiddleRight = new System.Windows.Forms.Button();
            this.MiddleCenter = new System.Windows.Forms.Button();
            this.BottomRight = new System.Windows.Forms.Button();
            this.BottomLeft = new System.Windows.Forms.Button();
            this.MiddleLeft = new System.Windows.Forms.Button();
            this.TopCenter = new System.Windows.Forms.Button();
            this.TopRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicTacToeApplication.Properties.Resources.bord;
            this.pictureBox1.InitialImage = global::TicTacToeApplication.Properties.Resources.bord;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TopLeft
            // 
            this.TopLeft.Location = new System.Drawing.Point(0, 0);
            this.TopLeft.Name = "TopLeft";
            this.TopLeft.Size = new System.Drawing.Size(145, 145);
            this.TopLeft.TabIndex = 2;
            this.TopLeft.UseVisualStyleBackColor = true;
            this.TopLeft.Click += new System.EventHandler(this.TopLeft_Click);
            // 
            // BottomCenter
            // 
            this.BottomCenter.Location = new System.Drawing.Point(153, 305);
            this.BottomCenter.Name = "BottomCenter";
            this.BottomCenter.Size = new System.Drawing.Size(145, 145);
            this.BottomCenter.TabIndex = 3;
            this.BottomCenter.UseVisualStyleBackColor = true;
            this.BottomCenter.Click += new System.EventHandler(this.BottomCenter_Click);
            // 
            // MiddleRight
            // 
            this.MiddleRight.Location = new System.Drawing.Point(303, 153);
            this.MiddleRight.Name = "MiddleRight";
            this.MiddleRight.Size = new System.Drawing.Size(145, 145);
            this.MiddleRight.TabIndex = 4;
            this.MiddleRight.UseVisualStyleBackColor = true;
            this.MiddleRight.Click += new System.EventHandler(this.MiddleRight_Click);
            // 
            // MiddleCenter
            // 
            this.MiddleCenter.Location = new System.Drawing.Point(152, 153);
            this.MiddleCenter.Name = "MiddleCenter";
            this.MiddleCenter.Size = new System.Drawing.Size(145, 145);
            this.MiddleCenter.TabIndex = 5;
            this.MiddleCenter.UseVisualStyleBackColor = true;
            this.MiddleCenter.Click += new System.EventHandler(this.MiddleCenter_Click);
            // 
            // BottomRight
            // 
            this.BottomRight.Location = new System.Drawing.Point(303, 304);
            this.BottomRight.Name = "BottomRight";
            this.BottomRight.Size = new System.Drawing.Size(145, 145);
            this.BottomRight.TabIndex = 6;
            this.BottomRight.UseVisualStyleBackColor = true;
            this.BottomRight.Click += new System.EventHandler(this.BottomRight_Click);
            // 
            // BottomLeft
            // 
            this.BottomLeft.Location = new System.Drawing.Point(2, 305);
            this.BottomLeft.Name = "BottomLeft";
            this.BottomLeft.Size = new System.Drawing.Size(145, 145);
            this.BottomLeft.TabIndex = 7;
            this.BottomLeft.UseVisualStyleBackColor = true;
            this.BottomLeft.Click += new System.EventHandler(this.BottomLeft_Click);
            // 
            // MiddleLeft
            // 
            this.MiddleLeft.Location = new System.Drawing.Point(2, 153);
            this.MiddleLeft.Name = "MiddleLeft";
            this.MiddleLeft.Size = new System.Drawing.Size(145, 145);
            this.MiddleLeft.TabIndex = 8;
            this.MiddleLeft.UseVisualStyleBackColor = true;
            this.MiddleLeft.Click += new System.EventHandler(this.MiddleLeft_Click);
            // 
            // TopCenter
            // 
            this.TopCenter.Location = new System.Drawing.Point(151, 0);
            this.TopCenter.Name = "TopCenter";
            this.TopCenter.Size = new System.Drawing.Size(145, 145);
            this.TopCenter.TabIndex = 9;
            this.TopCenter.UseVisualStyleBackColor = true;
            this.TopCenter.Click += new System.EventHandler(this.TopCenter_Click);
            // 
            // TopRight
            // 
            this.TopRight.Location = new System.Drawing.Point(302, 0);
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(145, 145);
            this.TopRight.TabIndex = 10;
            this.TopRight.UseVisualStyleBackColor = true;
            this.TopRight.Click += new System.EventHandler(this.TopRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.TopRight);
            this.Controls.Add(this.TopCenter);
            this.Controls.Add(this.MiddleLeft);
            this.Controls.Add(this.BottomLeft);
            this.Controls.Add(this.BottomRight);
            this.Controls.Add(this.MiddleCenter);
            this.Controls.Add(this.MiddleRight);
            this.Controls.Add(this.BottomCenter);
            this.Controls.Add(this.TopLeft);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button TopLeft;
        private System.Windows.Forms.Button BottomCenter;
        private System.Windows.Forms.Button MiddleRight;
        private System.Windows.Forms.Button MiddleCenter;
        private System.Windows.Forms.Button BottomRight;
        private System.Windows.Forms.Button BottomLeft;
        private System.Windows.Forms.Button MiddleLeft;
        private System.Windows.Forms.Button TopCenter;
        private System.Windows.Forms.Button TopRight;
    }
}

