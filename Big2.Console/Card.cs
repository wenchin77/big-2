using Big2.Console.Enums;

namespace Big2.Console
{
    public class Card
    {
        public Suit suit;
        public Rank rank;
        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }
    }
}