using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Test
{
    [TestClass]
    public class IsValidHandTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsValidHandShouldThrowIfHandIsNull()
        {
            var checker = new PokerHandsChecker();
            IHand hand = null;
            checker.IsValidHand(hand);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsValidHandShouldThrowIfNotValidHandCardsCountLow()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>
                {
                    new Card(CardFace.Queen,CardSuit.Hearts),
                    new Card(CardFace.Jack,CardSuit.Hearts),
                    new Card(CardFace.King,CardSuit.Clubs),
                });

            checker.IsValidHand(hand);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsValidHandShouldThrowIfNotValidHandCardsCountHigh()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>
                {
                    new Card(CardFace.Queen,CardSuit.Hearts),
                    new Card(CardFace.Jack,CardSuit.Hearts),
                    new Card(CardFace.King,CardSuit.Clubs),
                    new Card(CardFace.Queen,CardSuit.Diamonds),
                    new Card(CardFace.Four,CardSuit.Hearts),
                    new Card(CardFace.Two,CardSuit.Clubs)
                });

            checker.IsValidHand(hand);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsValidHandShouldThrowIfDuplicateCard()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>
                {
                    new Card(CardFace.Queen,CardSuit.Hearts),
                    new Card(CardFace.Jack,CardSuit.Hearts),
                    new Card(CardFace.King,CardSuit.Clubs),
                    new Card(CardFace.Queen,CardSuit.Hearts),
                    new Card(CardFace.Four,CardSuit.Hearts),
                    new Card(CardFace.Two,CardSuit.Clubs)
                });

            checker.IsValidHand(hand);
        }

        [TestMethod]
        public void IsValidHandShouldNotThrowIfValidHand()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>
                {
                    new Card(CardFace.Queen,CardSuit.Hearts),
                    new Card(CardFace.Jack,CardSuit.Hearts),
                    new Card(CardFace.King,CardSuit.Clubs),
                    new Card(CardFace.Two,CardSuit.Spades),
                    new Card(CardFace.Six,CardSuit.Diamonds)
                });

            Assert.IsTrue(checker.IsValidHand(hand));
        }
    }
}
