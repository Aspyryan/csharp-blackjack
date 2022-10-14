namespace Domain;

public class BlackJackCard : Card
{
    public bool FaceUp { get; set; }
    public int Value { get {
            if (FaceUp == false)
                return 0;
            switch (FaceValue)
            {
                case FaceValue.Ace:
                    return 1;
                case FaceValue.Two:
                    return 2;
                case FaceValue.Three:
                    return 3;
                case FaceValue.Four:
                    return 4;
                case FaceValue.Five:
                    return 5;
                case FaceValue.Six:
                    return 6;
                case FaceValue.Seven:
                    return 7;
                case FaceValue.Eight:
                    return 8;
                case FaceValue.Nine:
                    return 9;
                case FaceValue.Ten:
                    return 10;
                case FaceValue.Jack:
                    return 10;
                case FaceValue.Queen:
                    return 10;
                case FaceValue.King:
                    return 10;
                default:
                    return 0;
            }
        } }
    public BlackJackCard(Suit suit, FaceValue faceValue) : base(suit, faceValue)
    {
        FaceUp = false;
    }

    public void TurnCard()
    {
        FaceUp = !FaceUp;
    }
}