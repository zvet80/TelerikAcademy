using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Test
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void CardShouldReturnCorrectToString()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
            var expected = "Ace of Clubs";

            Assert.AreEqual(expected, card.ToString());
        }
    }
}
