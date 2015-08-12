using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Test
{
    [TestClass]
    public class IsFourOfAKindTests
    {
        [TestMethod]
        public void IsFourOfAKindShouldReturnFalseIfNotFourOfAKind()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>
                {
                    new Card(CardFace.Queen,CardSuit.Hearts),
                    new Card(CardFace.Jack,CardSuit.Hearts),
                    new Card(CardFace.King,CardSuit.Clubs),
                    new Card(CardFace.Queen,CardSuit.Spades),
                    new Card(CardFace.Queen,CardSuit.Diamonds)
                });

            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void IsFourOfAKindShouldReturnTrueIfFourOfAKind()
        {
            var checker = new PokerHandsChecker();
            var hand = new Hand(new List<ICard>
                {
                    new Card(CardFace.Jack,CardSuit.Hearts),
                    new Card(CardFace.Queen,CardSuit.Hearts),    
                    new Card(CardFace.Queen,CardSuit.Clubs),
                    new Card(CardFace.Queen,CardSuit.Spades),
                    new Card(CardFace.Queen,CardSuit.Diamonds)
                });

            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }
    }
}
