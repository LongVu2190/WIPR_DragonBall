﻿namespace DragonBall
{
    partial class EndGame
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
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Play_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(61, 81);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(49, 37);
            this.Exit_btn.TabIndex = 0;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Play_btn
            // 
            this.Play_btn.Location = new System.Drawing.Point(133, 81);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(71, 37);
            this.Play_btn.TabIndex = 1;
            this.Play_btn.Text = "Play again";
            this.Play_btn.UseVisualStyleBackColor = true;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 248);
            this.Controls.Add(this.Play_btn);
            this.Controls.Add(this.Exit_btn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Play_btn;
    }
}