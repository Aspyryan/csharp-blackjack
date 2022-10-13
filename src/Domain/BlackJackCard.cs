namespace Domain;

class BlackJackCard : Card
{
    bool FaceUp { get; set; }
    int Value { get; }
    public BlackJackCard(Suit suit, FaceValue faceValue) : base(suit, faceValue)
    {
        FaceUp = false;
        Value = (int)faceValue;
    }

    public void TurnCard()
    {
        throw new NotImplementedException();
    }
}