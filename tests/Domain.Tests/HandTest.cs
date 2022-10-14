using Domain;
using Shouldly;
using Xunit;

namespace Domain.Tests
{
    public class HandTest
    {
        private Hand _hand;

        public HandTest()
        {
            _hand = new Hand();
        }

        [Fact]
        public void NewHand_HasNoCards()
        {
            Assert.Equal(0, _hand.NrOfCards);
        }

        [Fact]
        public void AddCard_EmptyHand_ResultsInHandWithOneCard()
        {
            _hand.AddCard(new BlackJackCard(Suit.Hearts, FaceValue.Ace));
            _hand.NrOfCards.ShouldBe(1);
        }

        [Fact]
        public void AddCard_AHandWithCards_AddsACard()
        {
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Eight));
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Eight));
            _hand.NrOfCards.ShouldBe(2);
            foreach (BlackJackCard c in _hand.Cards)
                c.GetType().ShouldBe(typeof(BlackJackCard));
        }

        [Fact]
        public void TurnAllCardsFaceUp_TurnsAllCardsFaceUp()
        {
            BlackJackCard card = new BlackJackCard(Suit.Hearts, FaceValue.Ace);
            card.TurnCard();
            _hand.AddCard(card);
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Two));
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Two));
            _hand.TurnAllCardsFaceUp();
            foreach (BlackJackCard c in _hand.Cards)
                Assert.True(c.FaceUp);
        }

        [Fact]
        public void Value_EmptyHand_IsZero()
        {
            Assert.Equal(0, _hand.Value);
        }

        [Theory]
        [InlineData(FaceValue.Six, FaceValue.Five, 11)]
        [InlineData(FaceValue.Five, FaceValue.King, 15)]
        public void Value_HandWith6and5_Is11(FaceValue v1, FaceValue v2, int result)
        {
            BlackJackCard c1 = new BlackJackCard(Suit.Clubs, v1);
            BlackJackCard c2 = new BlackJackCard(Suit.Clubs, v2);
            
            c1.TurnCard();
            c2.TurnCard();
            _hand.AddCard(c1);
            _hand.AddCard(c2);
            
            _hand.Value.ShouldBe(result);
        }

        [Fact]
        public void Value_HandWithCardsFacingDown_DoesNotAddValuesOfCardsFacingDown()
        {
            BlackJackCard c1 = new BlackJackCard(Suit.Clubs, FaceValue.Ten);
            BlackJackCard c2 = new BlackJackCard(Suit.Clubs, FaceValue.Two);
            
            c1.TurnCard();
            _hand.AddCard(c1);
            _hand.AddCard(c2);

            _hand.Value.ShouldBe(10);
        }

        [Fact]
        public void Value_HandWithAceAndNotExceeding21_TakesAceAs11()
        {
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Seven));
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Ace));
            _hand.TurnAllCardsFaceUp();

            _hand.Value.ShouldBe(18);
        }

        [Fact]
        public void ValueHandWithAceAndExceeding21_TakesAceAs1()
        {
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Seven));
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Eight));
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Ace));
            _hand.TurnAllCardsFaceUp();

            _hand.Value.ShouldBe(16);
        }

        [Fact]
        public void Value_HandWithAceFaceDown_DoesNotCountAce()
        {
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Two));
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Two));
            _hand.TurnAllCardsFaceUp();
            _hand.AddCard(new BlackJackCard(Suit.Clubs, FaceValue.Ace));
            
            _hand.Value.ShouldBe(4);
        }
    }
}
