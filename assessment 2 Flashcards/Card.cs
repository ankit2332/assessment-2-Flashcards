using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment_2_Flashcards
{
    class Card
    {
        private string word;
        private string def;
        private bool flipped;

        public Card(string word, string def)
        {
            this.word = word;
            this.def = def;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Gets the word on the card.</returns>
        public string getword()
        {
            return word;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Gets the definision of the word.</returns>
        public string getdef()
        {
            return def;
        }

        /// <summary>
        /// checks if the card has been flipped yet.
        /// </summary>
        /// <returns>Prints True or false. if it have been flipped then it will print true, If not then false.</returns>
        public bool isflipped()
        {
            return flipped;
        }

        /// <summary>
        /// This flips the card around.
        /// </summary>
        public void flip()
        {
            if(flipped == false)
            {
                flipped = true;
            }
            else
            {
                flipped = false;
            }
        }
    }
}
