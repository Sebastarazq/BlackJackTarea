using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Modelos
{
    class Dealer
    {
        List<Card> deck;

        public void Generate()
        {
            deck = new List<Card>();

            char[] suits = { '♥','♦','♠','♣'};
            string[] symbols = {"A","2","3","4",
                                "5","6","7","8",
                                "9","10","J","Q","K"};

            foreach (char s in suits){
                foreach (string sy in symbols)
                {
                    deck.Add(new Card(s, sy) );
                }

            }
            Randomize();

        }
        public List<Card> GetDeck()
        {
            return deck;
        }
        
        private void Randomize()
        {
            Random rnd = new Random();
            this.deck = this.deck.OrderBy(x => rnd.Next()).ToList();
        }
        public Card Deal()
        {
            Card c = this.deck.Last();
            this.deck.RemoveAt(this.deck.Count - 1);

            return c;
        }
    }
}
