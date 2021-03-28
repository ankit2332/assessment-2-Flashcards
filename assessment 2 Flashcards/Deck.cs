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

        // getting the file name.
        public Deck(string filename)
        {
            this.filename = filename;
            
            loadfile();
        }
        /// <summary>
        /// get decks length.
        /// </summary>
        /// <returns>Length of the deck</returns>
        public int getdecklength()
        {
            return length;
        }

        // loads in the file and splits the text's in the file
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

        //returning me the card but not the text.
        public Card getcard(int topcard)
        {
            return cards[topcard];
        }

        //overloading getcard.
        public Card getcard()
        {
            return cards[topcard];
        }
        //this is checking if the top card is the last card of the deck, 
        //if it is then it will set the top card to zero when the next button is clicked again.
        //if it's not the last card then it will just go to the next card.
        public void nextbutton()
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

        //same as the next button but instand of the last card it checks if its the first card and if it is then it will set it to the last card
        //if not then it will just go back a card.
        public void backbutton()
        {
            if (topcard == 0)
            {
                topcard = length - 1;

            }
            else
            {
                topcard--;
            }

        }

        //this is getting a random card from the deck.
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

        //this is returning me the topcard.
        public int gettopcard()
        {
            return topcard;
        }

        //shuffling the deck
        public void shufflecardbutton()
        {
            Random rnd = new Random();
            int randomnum;
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                randomnum = rnd.Next(0, cards.Length);
                Card temp = cards[i];
                cards[i] = cards[randomnum];
                cards[randomnum] = temp;
                topcard = randomnum;
                count++;
                
            }
            
        }
    }
}
