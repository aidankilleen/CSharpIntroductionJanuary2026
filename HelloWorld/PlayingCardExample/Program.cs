using PlayingCardExample;

Console.WriteLine("Playing Card Example");


Deck d = new Deck();

d.Display();

d.Shuffle(1);
d.Display();

d.Shuffle(10);
d.Display();

d.Shuffle(100);
d.Display();

d.Shuffle(1000);
d.Display();








/*

Card c = new Card { 
    Value=2, 
    Suit=1
}; // AH


c.Display();
Console.WriteLine("==================");

for (int suit=1; suit<=4; suit++)
{
    for (int value=1; value<=13; value++)
    {
        c = new Card { 
            Value = value, 
            Suit = suit 
        };
        c.Display();
    }
    Console.WriteLine();
}

*/


