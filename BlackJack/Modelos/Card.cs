using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Modelos
{
    class Card
    {
        public char Suit { get; set; }
        public string Symbol { get; set; }

        public int Score { get; set; }

        public Color CardColor { get; set; }

        public Card(char suit, string symbol)
        {
            Suit = suit;
            Symbol = symbol;

            if (suit.Equals('♥') || suit == '♦')
            {
                CardColor = Color.RED;
            }
            else
            {
                CardColor = Color.BLACK;
            }

            if (symbol == "A")
                Score = 11;
            else if (symbol == "J" || symbol == "Q" || symbol == "K")          
                Score = 10;
            else
                Score = Convert.ToInt16(symbol);
        }
    }
}

