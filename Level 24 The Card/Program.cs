{
    //create array variables to hold each enum possiblity
    CardColors[] colors = new CardColors[] { CardColors.red, CardColors.blue, CardColors.green, CardColors.yellow };
    CardRanks[] ranks = new CardRanks[] {CardRanks.One, CardRanks.Two,CardRanks.Three, CardRanks.Four,CardRanks.Five,
        CardRanks.Six,CardRanks.Seven,CardRanks.Eight, CardRanks.Nine, CardRanks.Ten, CardRanks.Ampersand,
        CardRanks.Carrot,CardRanks.Dollar,CardRanks.Percent};

    //loop to print each card in each color to the console
    foreach (CardColors color in colors)
    {
        foreach (CardRanks rank in ranks)
        {
            Card card = new Card(rank, color);
            Console.WriteLine($"The {card._cardColor} {card._cardRank}");
        }
    }
    //holds program open
    Console.ReadKey();
}

class Card
{
    public CardColors _cardColor { get; }
    public CardRanks _cardRank { get; }

    public Card(CardRanks rank, CardColors color)
    {
        _cardRank = rank;
        _cardColor = color;

    }
}

enum CardColors
{
    red, green, blue, yellow,
}
enum CardRanks
{
    One = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, 
    Dollar = 11, Percent = 12, Carrot = 13, Ampersand = 14,
}