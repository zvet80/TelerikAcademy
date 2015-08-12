using NUnit.Framework;
using Santase.Logic.Cards;

namespace Santase.Test
{
    [TestFixture]
    public class DeckTests
    {
        [Test]
        [ExpectedException(typeof(Santase.Logic.InternalGameException))]
        public void DrawNextCardOnEmptyDeckShouldThrow()
        {
            var deck = new Deck();

            for (int card = 0; card <= 24; card++)
            {
                deck.GetNextCard();
            }
        }
    }
}
