using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3_Flash_Card
{
    class Deck
    {
        private int cardIndex = 0;
        private int deckIndex = 0;
        private Card[] CardsArray;
        private string FileName;

        public Deck(string FileName)
        {
            this.FileName = FileName;

        }

        public int GetCardIndex()
        {
            return cardIndex;
        }

        public int GetDeckIndex()
        {
            return deckIndex;
        }

        public int GetArrayLength()
        {
            return CardsArray.Length;
        }

          



        

      

   }
}
