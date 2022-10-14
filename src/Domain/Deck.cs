namespace Domain;

public class Deck
{
    protected IList<BlackJackCard> _cards { get; set; }
    private Random _random;
    
    public Deck()
    {
        
    }

    public BlackJackCard Draw()
    {
        throw new NotImplementedException();
    }
    
    private void Shuffle()
    {
        throw new NotImplementedException();
    }
}