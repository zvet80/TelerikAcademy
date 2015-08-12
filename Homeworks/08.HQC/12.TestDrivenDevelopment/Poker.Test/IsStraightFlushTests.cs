using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Test
{
    [TestClass]
    public class IsStraightFlushTests
    {
        [TestMethod]
        public void IsStraightFlushShouldReturnFalseIfDiffSuit()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>
                {
                    new Card(CardFace.Queen,CardSuit.Hearts),
                    new Card(CardFace.Jack,CardSuit.Hearts),
                    new Card(CardFace.King,CardSuit.Clubs),
                    new Card(CardFace.Ace,CardSuit.Spades),
                    new Card(CardFace.Ten,CardSuit.Diamonds)
                });

            Assert.IsFalse(checker.IsStraightFlush(hand));
        }

        [TestMethod]
        public void IsStraightFlushShouldReturnFalseIfNotConsequitiveFace()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>
                {
                    new Card(CardFace.Queen,CardSuit.Hearts),
                    new Card(CardFace.Jack,CardSuit.Hearts),
                    new Card(CardFace.King,CardSuit.Hearts),
                    new Card(CardFace.Ace,CardSuit.Hearts),
                    new Card(CardFace.Two,CardSuit.Hearts)
                });

            Assert.IsFalse(checker.IsStraightFlush(hand));
        }

        [TestMethod]
        public void IsStraightFlushShouldReturnTrueIfValidStraightFlush()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>
                {
                    new Card(CardFace.Queen,CardSuit.Hearts),
                    new Card(CardFace.Jack,CardSuit.Hearts),
                    new Card(CardFace.King,CardSuit.Hearts),
                    new Card(CardFace.Ace,CardSuit.Hearts),
                    new Card(CardFace.Ten,CardSuit.Hearts)
                });

            Assert.IsTrue(checker.IsStraightFlush(hand));
        }
    }
}
