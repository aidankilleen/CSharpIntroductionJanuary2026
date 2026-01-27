using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardExample
{
    internal class Deck
    {
        private Card[] cards = new Card[52];
        public Deck()
        {
            //cards[0] = new Card { Value = 1, Suit = 1 };
            //cards[1] = new Card { Value = 2, Suit = 1 };
            int count = 0;
            for (int suit=1; suit<=4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards[count++] = new Card { 
                        Suit = suit, 
                        Value = value 
                    };
                }
            }
        }
        public void Display()
        {
            int count = 0;
            foreach (Card card in cards)
            {
                card.Display();
                count++;
                if (count == 13 || count == 26 || count == 39)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n");
        }
        public void Shuffle(int count)
        {
            Random rg = new Random();

            for (int i=0; i<count; i++)
            {
                int r1 = rg.Next(52);
                int r2 = rg.Next(52);

                // swap cards at r1 and r2
                Card t = cards[r1];
                cards[r1] = cards[r2];
                cards[r2] = t;
            }
        }
    }
}
