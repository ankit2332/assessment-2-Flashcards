﻿
namespace assessment_2_Flashcards
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
            this.Browsefile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Flipcard = new System.Windows.Forms.Button();
            this.Loadfile = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Shufflebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Browsefile
            // 
            this.Browsefile.Location = new System.Drawing.Point(173, 13);
            this.Browsefile.Name = "Browsefile";
            this.Browsefile.Size = new System.Drawing.Size(195, 37);
            this.Browsefile.TabIndex = 0;
            this.Browsefile.Text = "Browse";
            this.Browsefile.UseVisualStyleBackColor = true;
            this.Browsefile.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Flipcard
            // 
            this.Flipcard.Location = new System.Drawing.Point(286, 159);
            this.Flipcard.Name = "Flipcard";
            this.Flipcard.Size = new System.Drawing.Size(195, 37);
            this.Flipcard.TabIndex = 2;
            this.Flipcard.Text = "Flip";
            this.Flipcard.UseVisualStyleBackColor = true;
            this.Flipcard.Click += new System.EventHandler(this.Flipcard_Click);
            // 
            // Loadfile
            // 
            this.Loadfile.Location = new System.Drawing.Point(411, 12);
            this.Loadfile.Name = "Loadfile";
            this.Loadfile.Size = new System.Drawing.Size(195, 38);
            this.Loadfile.TabIndex = 4;
            this.Loadfile.Text = "Load";
            this.Loadfile.UseVisualStyleBackColor = true;
            this.Loadfile.Click += new System.EventHandler(this.Loadfile_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.Location = new System.Drawing.Point(498, 159);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(195, 37);
            this.Nextbutton.TabIndex = 6;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(75, 159);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(195, 37);
            this.Backbutton.TabIndex = 7;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 222);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(195, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Random Card";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Shufflebutton
            // 
            this.Shufflebutton.Location = new System.Drawing.Point(411, 222);
            this.Shufflebutton.Name = "Shufflebutton";
            this.Shufflebutton.Size = new System.Drawing.Size(195, 37);
            this.Shufflebutton.TabIndex = 10;
            this.Shufflebutton.Text = "Shuffle";
            this.Shufflebutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 286);
            this.Controls.Add(this.Shufflebutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Loadfile);
            this.Controls.Add(this.Flipcard);
            this.Controls.Add(this.Browsefile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browsefile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Flipcard;
        private System.Windows.Forms.Button Loadfile;
        private System.Windows.Forms.Button Nextbutton;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Shufflebutton;
    }
}

