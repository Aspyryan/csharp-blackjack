namespace Domain;

class Card
{
    FaceValue FaceValue { get; }
    Suit Suit { get; }

    public Card(Suit suit, FaceValue faceValue)
    {
        FaceValue = faceValue;
        Suit = suit;
    }
}