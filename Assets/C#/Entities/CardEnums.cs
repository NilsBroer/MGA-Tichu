namespace Entities
{
    public static class CardEnums
    {
        public static class Tichu
        {
            public enum Names
            {
                Mahjong,
                Two,
                Three,
                Four,
                Five,
                Six,
                Seven,
                Eight,
                Nine,
                Ten,
                Jack,
                Queen,
                King,
                Ace,
                Phoenix,
                Dragon,
                Dog
            }
            
            public enum Suits
            {
                Red,
                Green,
                Blue,
                Black
            }
            
            public enum Values
            {
                Mahjong = 1,
                Two = 2,
                Three = 3,
                Four = 4,
                Five = 5,
                Six = 6,
                Seven = 7,
                Eight = 8,
                Nine = 9,
                Ten = 10,
                Jack = 11,
                Queen = 12,
                King = 13,
                Ace = 14
            }

            public enum Points
            {
                Five = 5,
                Ten = 10,
                King = 10,
                Phoenix = -25,
                Dragon = 25
            }
        }
    }
}