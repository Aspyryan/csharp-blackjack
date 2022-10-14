namespace Domain;

public class BlackJack
{
    private Deck _deck;
    public Hand PlayerHand { get; }
    public Hand DealerHand { get; }
    public bool FaceDown;
    public bool FaceUp;
    public GameState GameState { get; private set; }

    public BlackJack()
    {
        GameState = GameState.PlayerPlays;
    }

    public BlackJack(Deck deck)
    {
        throw new NotImplementedException();
    }

    private void Deal()
    {
        throw new NotImplementedException();
    }

    public void PassToDealer() { throw new NotImplementedException(); }
    public string GameSummary()
    {
        throw new NotImplementedException();
    }

    public void GivePlayerAnotherCard()
    {
        throw new NotImplementedException();
    }

    private void AddCardToHand(Hand hand, bool faceUp)
    {
        throw new NotImplementedException();
    }

    private void AdjustGameState(GameState? gameState = null)
    {
        throw new NotImplementedException();
    }

    private void LetDealerFinalize()
    {
        throw new NotImplementedException();
    }
}