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
        int length;

        public Deck(string filename)
        {
            this.filename = filename;
            
            loadfile();
        }
        /// <summary>
        /// get decks length.
        /// </summary>
        /// <returns></returns>
        public int getdecklength()
        {
            return length;
        }
        /// <summary>
        /// loads in the file and splits the text's in the file
        /// </summary>
        public void loadfile()
        {
            length = 0;
            StreamReader fileReader = new StreamReader(filename);
            while ((fileReader.ReadLine()) != null)
            {
                length++;
            }
            cards = new Card[length ];
            int count = 0;
            string line;
            fileReader = new StreamReader(filename);
            while((line = fileReader.ReadLine()) != null)
            {
                string[] cell = line.Split(',');
                string word = cell[0];
                string def = cell[1];
                cards[count] = new Card(word, def);
                count++;
            }
        }

        public Card getcard(int topcard)
        {
            return cards[topcard];
        }

        public Card getcard()
        {
            return cards[topcard];
        }
        public void nextbutton()
        {
            if(topcard == 0)
            {
                topcard = length-1;
            }
            else
            {
                topcard--;
            }
            
        }

        public void backbutton()
        {
            if (topcard == length - 1)
            {
                topcard = 0;
            }
            else
            {
                topcard++;
            }

        }
        public void Randomcardbutton()
        {
            Random rnd = new Random();
            int randomnum = rnd.Next(0, cards.Length);
            if(randomnum == topcard)
            {
                randomnum = rnd.Next(0, cards.Length);
            }
            topcard = randomnum;
        }

        public void shufflecardbutton()
        {

        }
    }
}
