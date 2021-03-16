using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment_2_Flashcards
{
    class Deck
    {
        Card[] cards;
        private string filename;
        private int topcard = 0;

        public Deck(string filename)
        {
            this.filename = filename;
            cards = new Card[4];
        }
        c
        public void loadfile()
        {
            int count = 0;
            string line;
            StreamReader fileReader = new StreamReader(filename);
            while((line = fileReader.ReadLine()) != null)
            {
                string[] cell = line.Split(',');
                string word = cell[0];
                string def = cell[1];
                cards[count] = new Card(word, def);
                count++;
            }
        }

    }
}
