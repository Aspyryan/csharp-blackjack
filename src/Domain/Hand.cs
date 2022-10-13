namespace Domain;

class Hand
{
    private IList<BlackJackCard> _cards;
    IEnumerable<BlackJackCard> Cards { get; };
    int NrOfCards { get; }
    int Value { get; }

    public Hand()
    {
        
    }

    public void AddCard(BlackJackCard card)
    {
        throw new NotImplementedException();
    }

    public void TurnAllCardsFaceUp()
    {
        throw new NotImplementedException();
    }

    private int CalculateValue()
    {
        throw new NotImplementedException();
    }
}
