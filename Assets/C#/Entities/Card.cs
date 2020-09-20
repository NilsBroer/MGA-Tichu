namespace Entities
{
    public class Card
    {
        public string Name;
        public int Value;
        public string Suit;
        public int Points;

        public Card(string name, int value, string suit, int points)
        {
            Name = name;
            Value = value;
            Suit = suit;
            Points = points;
        }
    }
}