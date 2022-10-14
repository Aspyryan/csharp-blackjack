using System.Reflection.Metadata.Ecma335;

namespace Domain;

public class Hand
{
    private IList<BlackJackCard> _cards;
    public IEnumerable<BlackJackCard> Cards { get => _cards.AsEnumerable(); }
    public int NrOfCards { get => _cards.Count; }
    public int Value { get => CalculateValue(); }

    public Hand()
    {
        _cards = new List<BlackJackCard>();
    }

    public void AddCard(BlackJackCard card)
    {
        _cards.Add(card);
    }

    public void TurnAllCardsFaceUp()
    {
        foreach (BlackJackCard card in _cards)
            card.FaceUp = true;
    }

    private int CalculateValue()
    {
        int result = 0;
        foreach (BlackJackCard card in _cards)
        {
            if (card.FaceUp == false) continue;
            if (card.FaceValue == FaceValue.Ace) {
                if (result + 11 > 21)
                    result += 1;
                else
                    result += 11;
            }
            else { 
                result += card.Value;
            }
        }
        return result;
    }
}
