using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3_Flash_Card
{
    class Card
    {
        private bool flipped;
        private string cardTitle;
        private string cardDefinition;
        private int topCard;

        public Card(string cardTitle, string cardDefinition)
        {
            this.cardTitle = cardTitle;
            this.cardDefinition = cardDefinition;
        }

        public string GetDefinition()
        {
            return cardDefinition;
        }

        public string ReadCard()
        {
            if(flipped ==true )
            {
                return cardDefinition;
            }
            else
            {
                return cardTitle;
            }
        }

        public bool isFlipped()
        {
            return flipped;
        }



    }
}
