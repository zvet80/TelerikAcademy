using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Test
{
    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void HandToStringShouldItemizeHandCards()
        {
            var hand = new Hand(new List<ICard>
                {
                    new Card(CardFace.Queen,CardSuit.Hearts),
                    new Card(CardFace.Jack,CardSuit.Hearts),
                    new Card(CardFace.King,CardSuit.Clubs),
                });

            var expected = "Queen of Hearts, Jack of Hearts, King of Clubs";
            Assert.AreEqual(expected, hand.ToString());
        }
    }
}
