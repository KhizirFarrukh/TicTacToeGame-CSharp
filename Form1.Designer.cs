namespace TicTacToe
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
            this.TicTacToeBoard = new System.Windows.Forms.Panel();
            this.BtnLoc9 = new System.Windows.Forms.Button();
            this.BtnLoc8 = new System.Windows.Forms.Button();
            this.BtnLoc7 = new System.Windows.Forms.Button();
            this.BtnLoc6 = new System.Windows.Forms.Button();
            this.BtnLoc5 = new System.Windows.Forms.Button();
            this.BtnLoc4 = new System.Windows.Forms.Button();
            this.BtnLoc3 = new System.Windows.Forms.Button();
            this.BtnLoc2 = new System.Windows.Forms.Button();
            this.BtnLoc1 = new System.Windows.Forms.Button();
            this.WinnerText = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.TurnText = new System.Windows.Forms.Label();
            this.PlayWithAI = new System.Windows.Forms.CheckBox();
            this.TicTacToeBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicTacToeBoard
            // 
            this.TicTacToeBoard.BackColor = System.Drawing.Color.White;
            this.TicTacToeBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TicTacToeBoard.Controls.Add(this.BtnLoc9);
            this.TicTacToeBoard.Controls.Add(this.BtnLoc8);
            this.TicTacToeBoard.Controls.Add(this.BtnLoc7);
            this.TicTacToeBoard.Controls.Add(this.BtnLoc6);
            this.TicTacToeBoard.Controls.Add(this.BtnLoc5);
            this.TicTacToeBoard.Controls.Add(this.BtnLoc4);
            this.TicTacToeBoard.Controls.Add(this.BtnLoc3);
            this.TicTacToeBoard.Controls.Add(this.BtnLoc2);
            this.TicTacToeBoard.Controls.Add(this.BtnLoc1);
            this.TicTacToeBoard.Location = new System.Drawing.Point(12, 12);
            this.TicTacToeBoard.Name = "TicTacToeBoard";
            this.TicTacToeBoard.Size = new System.Drawing.Size(300, 300);
            this.TicTacToeBoard.TabIndex = 0;
            // 
            // BtnLoc9
            // 
            this.BtnLoc9.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoc9.Location = new System.Drawing.Point(200, 200);
            this.BtnLoc9.Name = "BtnLoc9";
            this.BtnLoc9.Size = new System.Drawing.Size(100, 100);
            this.BtnLoc9.TabIndex = 7;
            this.BtnLoc9.UseVisualStyleBackColor = true;
            this.BtnLoc9.Click += new System.EventHandler(this.BtnLoc9_Click);
            // 
            // BtnLoc8
            // 
            this.BtnLoc8.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoc8.Location = new System.Drawing.Point(100, 200);
            this.BtnLoc8.Name = "BtnLoc8";
            this.BtnLoc8.Size = new System.Drawing.Size(100, 100);
            this.BtnLoc8.TabIndex = 6;
            this.BtnLoc8.UseVisualStyleBackColor = true;
            this.BtnLoc8.Click += new System.EventHandler(this.BtnLoc8_Click);
            // 
            // BtnLoc7
            // 
            this.BtnLoc7.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoc7.Location = new System.Drawing.Point(0, 200);
            this.BtnLoc7.Name = "BtnLoc7";
            this.BtnLoc7.Size = new System.Drawing.Size(100, 100);
            this.BtnLoc7.TabIndex = 5;
            this.BtnLoc7.UseVisualStyleBackColor = true;
            this.BtnLoc7.Click += new System.EventHandler(this.BtnLoc7_Click);
            // 
            // BtnLoc6
            // 
            this.BtnLoc6.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoc6.Location = new System.Drawing.Point(200, 100);
            this.BtnLoc6.Name = "BtnLoc6";
            this.BtnLoc6.Size = new System.Drawing.Size(100, 100);
            this.BtnLoc6.TabIndex = 5;
            this.BtnLoc6.UseVisualStyleBackColor = true;
            this.BtnLoc6.Click += new System.EventHandler(this.BtnLoc6_Click);
            // 
            // BtnLoc5
            // 
            this.BtnLoc5.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoc5.Location = new System.Drawing.Point(100, 100);
            this.BtnLoc5.Name = "BtnLoc5";
            this.BtnLoc5.Size = new System.Drawing.Size(100, 100);
            this.BtnLoc5.TabIndex = 4;
            this.BtnLoc5.UseVisualStyleBackColor = true;
            this.BtnLoc5.Click += new System.EventHandler(this.BtnLoc5_Click);
            // 
            // BtnLoc4
            // 
            this.BtnLoc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoc4.Location = new System.Drawing.Point(0, 100);
            this.BtnLoc4.Name = "BtnLoc4";
            this.BtnLoc4.Size = new System.Drawing.Size(100, 100);
            this.BtnLoc4.TabIndex = 3;
            this.BtnLoc4.UseVisualStyleBackColor = true;
            this.BtnLoc4.Click += new System.EventHandler(this.BtnLoc4_Click);
            // 
            // BtnLoc3
            // 
            this.BtnLoc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoc3.Location = new System.Drawing.Point(200, 0);
            this.BtnLoc3.Name = "BtnLoc3";
            this.BtnLoc3.Size = new System.Drawing.Size(100, 100);
            this.BtnLoc3.TabIndex = 2;
            this.BtnLoc3.UseVisualStyleBackColor = true;
            this.BtnLoc3.Click += new System.EventHandler(this.BtnLoc3_Click);
            // 
            // BtnLoc2
            // 
            this.BtnLoc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoc2.Location = new System.Drawing.Point(100, 0);
            this.BtnLoc2.Name = "BtnLoc2";
            this.BtnLoc2.Size = new System.Drawing.Size(100, 100);
            this.BtnLoc2.TabIndex = 1;
            this.BtnLoc2.UseVisualStyleBackColor = true;
            this.BtnLoc2.Click += new System.EventHandler(this.BtnLoc2_Click);
            // 
            // BtnLoc1
            // 
            this.BtnLoc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoc1.Location = new System.Drawing.Point(0, 0);
            this.BtnLoc1.Name = "BtnLoc1";
            this.BtnLoc1.Size = new System.Drawing.Size(100, 100);
            this.BtnLoc1.TabIndex = 0;
            this.BtnLoc1.UseVisualStyleBackColor = true;
            this.BtnLoc1.Click += new System.EventHandler(this.BtnLoc1_Click);
            // 
            // WinnerText
            // 
            this.WinnerText.AutoSize = true;
            this.WinnerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerText.Location = new System.Drawing.Point(12, 374);
            this.WinnerText.Name = "WinnerText";
            this.WinnerText.Size = new System.Drawing.Size(114, 31);
            this.WinnerText.TabIndex = 1;
            this.WinnerText.Text = "Winner: ";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(237, 382);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 2;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // TurnText
            // 
            this.TurnText.AutoSize = true;
            this.TurnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnText.Location = new System.Drawing.Point(12, 334);
            this.TurnText.Name = "TurnText";
            this.TurnText.Size = new System.Drawing.Size(85, 31);
            this.TurnText.TabIndex = 3;
            this.TurnText.Text = "Turn: ";
            // 
            // PlayWithAI
            // 
            this.PlayWithAI.Location = new System.Drawing.Point(255, 347);
            this.PlayWithAI.Name = "PlayWithAI";
            this.PlayWithAI.Size = new System.Drawing.Size(59, 18);
            this.PlayWithAI.TabIndex = 0;
            this.PlayWithAI.Text = "with AI";
            this.PlayWithAI.UseVisualStyleBackColor = true;
            this.PlayWithAI.CheckedChanged += new System.EventHandler(this.PlayWithAI_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 423);
            this.Controls.Add(this.PlayWithAI);
            this.Controls.Add(this.TurnText);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.WinnerText);
            this.Controls.Add(this.TicTacToeBoard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TicTacToeBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TicTacToeBoard;
        private System.Windows.Forms.Button BtnLoc5;
        private System.Windows.Forms.Button BtnLoc4;
        private System.Windows.Forms.Button BtnLoc3;
        private System.Windows.Forms.Button BtnLoc2;
        private System.Windows.Forms.Button BtnLoc1;
        private System.Windows.Forms.Button BtnLoc9;
        private System.Windows.Forms.Button BtnLoc8;
        private System.Windows.Forms.Button BtnLoc7;
        private System.Windows.Forms.Button BtnLoc6;
        private System.Windows.Forms.Label WinnerText;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label TurnText;
        private System.Windows.Forms.CheckBox PlayWithAI;
    }
}

