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
        int decklength;
        int browse = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        // when 'browse' button is clicked it will open the user files to let the user pick a file.
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            browse++;
        }

        // when 'load' button is clicked it will load in the file the user picked.
        private void Loadfile_Click(object sender, EventArgs e)
        {
            if (browse == 0)
            {
                MessageBox.Show("you have to pick a file first!");
            }
            else
            {
                deck = new Deck(openFileDialog1.FileName);
                textBox1.Text = deck.getcard(0).getcardtext();
                progressBar1.Value = 1;
                progressBar1.Maximum = deck.getdecklength();
                decklength = deck.getdecklength();
            }
        }

        // when 'Flip' button is click it will flip the card.
        private void Flipcard_Click(object sender, EventArgs e)
        {
            if (decklength == 0)
            {
                MessageBox.Show("you have to load in the file first!");
            }
            else
            {
                deck.getcard().flip();
                textBox1.Text = deck.getcard().getcardtext();
            }
        }
        //when next button is clicked it will go to the next card. 
        //when the last card is on top and when clicked next it will go back to the first card
        private void Nextbutton_Click(object sender, EventArgs e)
        {
            if(decklength == 0)
            {
                MessageBox.Show("you have to load in the file first!");
            }
            else
            {
                deck.nextbutton();
                textBox1.Text = deck.getcard().getcardtext();
                if (progressBar1.Value == decklength)
                {
                    progressBar1.Value = 1;
                }
                else
                {
                    progressBar1.Value += 1;
                }
            }
            
        }

        //when back button is clicked it will go back one card. 
        //when the the top card is this first card in the deck and the back button is click it will go to the lass card in the deck.
        private void Backbutton_Click(object sender, EventArgs e)
        {
            if (decklength == 0)
            {
                MessageBox.Show("you have to load in the file first!");
            }
            else
            {
                deck.backbutton();
                textBox1.Text = deck.getcard().getcardtext();

                if (progressBar1.Value == 1)
                {
                    progressBar1.Value = decklength;
                }
                else
                {
                    progressBar1.Value -= 1;
                }
            }
        }

        //when 'random card' button is clicked it will get a random card from the deck.
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (decklength == 0)
            {
                MessageBox.Show("you have to load in the file first!");
            }
            else
            {
                deck.Randomcardbutton();
                textBox1.Text = deck.getcard().getcardtext();
                int position = deck.gettopcard();
                position += 1;
                progressBar1.Value = 1 * position;
            }
        }

        // when 'shuffle' button is clicked it will shuffle the whole deck.
        private void Shufflebutton_Click(object sender, EventArgs e)
        {
            if (decklength == 0)
            {
                MessageBox.Show("you have to load in the file first!");
            }
            else
            {
                deck.shufflecardbutton();
                textBox1.Text = deck.getcard().getcardtext();
            }
        }


    }
}
