﻿namespace HumansVsZombies
{
    partial class EndGameScreen
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
            this.nameEntry = new System.Windows.Forms.TextBox();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.saveScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Over!";
            // 
            // nameEntry
            // 
            this.nameEntry.Location = new System.Drawing.Point(149, 205);
            this.nameEntry.Name = "nameEntry";
            this.nameEntry.Size = new System.Drawing.Size(162, 20);
            this.nameEntry.TabIndex = 1;
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(274, 304);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(91, 42);
            this.playAgainButton.TabIndex = 2;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // saveScore
            // 
            this.saveScore.Location = new System.Drawing.Point(98, 304);
            this.saveScore.Name = "saveScore";
            this.saveScore.Size = new System.Drawing.Size(91, 42);
            this.saveScore.TabIndex = 3;
            this.saveScore.Text = "Save Score";
            this.saveScore.UseVisualStyleBackColor = true;
            // 
            // EndGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 435);
            this.Controls.Add(this.saveScore);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.nameEntry);
            this.Controls.Add(this.label1);
            this.Name = "EndGameScreen";
            this.Text = "EndGameScreen";
            this.Load += new System.EventHandler(this.EndGameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameEntry;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Button saveScore;
    }
}