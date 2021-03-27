using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assessment_2_Flashcards
{
    public partial class Form1 : Form
    {
        
        Deck deck;
        int addprogress = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
        }

        private void Loadfile_Click(object sender, EventArgs e)
        {
            deck = new Deck(openFileDialog1.FileName);
            textBox1.Text = deck.getcard(0).getcardtext();
            int temp = deck.getdecklength();
            addprogress = 100 / temp;
            progressBar1.Value = addprogress;

        }

        private void Flipcard_Click(object sender, EventArgs e)
        {
            deck.getcard().flip();
            textBox1.Text = deck.getcard().getcardtext();
        }
        //when next button is clicked it will go to the next card. 
        //when the last card is on top and when clicked next it will go back to the first card
        private void Nextbutton_Click(object sender, EventArgs e)
        {
            deck.nextbutton();
            textBox1.Text = deck.getcard().getcardtext();
            int temp = deck.getdecklength();
            addprogress = 100 / temp;
            if (progressBar1.Value >= 90)
            {
                progressBar1.Value = addprogress;
            }
            else
            {
                progressBar1.Value += addprogress;
            }

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            deck.backbutton();
            textBox1.Text = deck.getcard().getcardtext();
            int temp = deck.getdecklength();
            addprogress = 100 / temp;
            if (progressBar1.Value <= addprogress)
            {
                progressBar1.Value = 100;
            }
            else
            {
                progressBar1.Value -= addprogress;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            deck.Randomcardbutton();
            textBox1.Text = deck.getcard().getcardtext();
            int temp = deck.getdecklength();
            addprogress = 100 / temp;
            int position = deck.gettopcard();
            position += 1;
            progressBar1.Value = addprogress * position;
        }

        private void Shufflebutton_Click(object sender, EventArgs e)
        {
            deck.shufflecardbutton();
            textBox1.Text = deck.getcard().getcardtext();
        }


    }
}
