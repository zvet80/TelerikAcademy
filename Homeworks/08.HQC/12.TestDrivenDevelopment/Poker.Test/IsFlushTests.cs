using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Test
{
    [TestClass]
    public class IsFlushTests
    {
        [TestMethod]
        public void IsFlushShouldReturnFalseIfDiffSuit()
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

            Assert.IsFalse(checker.IsFlush(hand));
        }

        [TestMethod]
        public void IsFlushShouldReturnTrueIfValidFlush()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>
                {
                    new Card(CardFace.Two,CardSuit.Hearts),
                    new Card(CardFace.Jack,CardSuit.Hearts),
                    new Card(CardFace.Eight,CardSuit.Hearts),
                    new Card(CardFace.Ace,CardSuit.Hearts),
                    new Card(CardFace.Ten,CardSuit.Hearts)
                });

            Assert.IsTrue(checker.IsFlush(hand));
        }
    }
}

