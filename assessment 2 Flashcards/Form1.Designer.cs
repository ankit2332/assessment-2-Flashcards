
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Browsefile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Flipcard = new System.Windows.Forms.Button();
            this.Loadfile = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Randomcardbutton = new System.Windows.Forms.Button();
            this.Shufflebutton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Browsefile
            // 
            this.Browsefile.Location = new System.Drawing.Point(644, 12);
            this.Browsefile.Name = "Browsefile";
            this.Browsefile.Size = new System.Drawing.Size(97, 26);
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
            this.Flipcard.Location = new System.Drawing.Point(387, 255);
            this.Flipcard.Name = "Flipcard";
            this.Flipcard.Size = new System.Drawing.Size(110, 36);
            this.Flipcard.TabIndex = 2;
            this.Flipcard.Text = "Flip";
            this.Flipcard.UseVisualStyleBackColor = true;
            this.Flipcard.Click += new System.EventHandler(this.Flipcard_Click);
            // 
            // Loadfile
            // 
            this.Loadfile.Location = new System.Drawing.Point(761, 12);
            this.Loadfile.Name = "Loadfile";
            this.Loadfile.Size = new System.Drawing.Size(97, 26);
            this.Loadfile.TabIndex = 4;
            this.Loadfile.Text = "Load";
            this.Loadfile.UseVisualStyleBackColor = true;
            this.Loadfile.Click += new System.EventHandler(this.Loadfile_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.Location = new System.Drawing.Point(545, 255);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(110, 36);
            this.Nextbutton.TabIndex = 6;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(231, 255);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(110, 36);
            this.Backbutton.TabIndex = 7;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Randomcardbutton
            // 
            this.Randomcardbutton.Location = new System.Drawing.Point(303, 309);
            this.Randomcardbutton.Name = "Randomcardbutton";
            this.Randomcardbutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Randomcardbutton.Size = new System.Drawing.Size(110, 36);
            this.Randomcardbutton.TabIndex = 9;
            this.Randomcardbutton.Text = "Random Card";
            this.Randomcardbutton.UseVisualStyleBackColor = true;
            this.Randomcardbutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Shufflebutton
            // 
            this.Shufflebutton.Location = new System.Drawing.Point(472, 309);
            this.Shufflebutton.Name = "Shufflebutton";
            this.Shufflebutton.Size = new System.Drawing.Size(110, 36);
            this.Shufflebutton.TabIndex = 10;
            this.Shufflebutton.Text = "Shuffle";
            this.Shufflebutton.UseVisualStyleBackColor = true;
            this.Shufflebutton.Click += new System.EventHandler(this.Shufflebutton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(611, 26);
            this.progressBar1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 401);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Shufflebutton);
            this.Controls.Add(this.Randomcardbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Loadfile);
            this.Controls.Add(this.Flipcard);
            this.Controls.Add(this.Browsefile);
            this.Name = "Form1";
            this.Text = "Flash Cards";
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
        private System.Windows.Forms.Button Randomcardbutton;
        private System.Windows.Forms.Button Shufflebutton;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

