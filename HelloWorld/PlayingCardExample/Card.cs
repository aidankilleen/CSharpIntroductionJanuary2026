using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardExample
{
    internal class Card
    {
        // 1=A, 2=2, ... 10=10, 11=J, 12=Q, 13=K
        public int Value { get; set; }

        // 1=H, 2=S, 3=D, 4=C
        public int Suit { get; set; }

        public void Display()
        {
            string card = "";

            if (Value ==1)
            {
                card += " A";
            } else if (Value >=2 && Value <= 10)
            {
                // leave out space for 10 
                // "" is an empty string " " is a space
                card += $"{(Value==10? "" : " ")}{Value}";
            } else if (Value == 11)
            {
                card += " J";
            } else if (Value == 12)
            {
                card += " Q";
            } else if (Value == 13)
            {
                card += " K";
            } else
            {
                card += " ?";
            }

            if (Suit == 1)
            {
                card += "H ";
            }
            else if(Suit == 2) 
            {
                card += "S ";
            }
            else if (Suit == 3)
            {
                card += "D ";
            } else if (Suit == 4)
            {
                card += "C ";
            } else
            {
                card += "? ";
            }
            Console.Write(card);
        }
    }
}
