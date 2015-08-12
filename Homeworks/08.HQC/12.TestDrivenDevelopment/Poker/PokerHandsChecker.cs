namespace Poker
{
    using System;
    using System.Linq;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        public const int ValidHandCardsCount = 5;
        public const int MaxSameFaceCount = 4;

        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("Hand cannot be null");
            }

            if (hand.Cards.Count != ValidHandCardsCount)
            {
                throw new ArgumentException(string.Format("Hand should have {0} cards", ValidHandCardsCount));
            }

            if (hand.Cards.Distinct().Count() != ValidHandCardsCount)
            {
                throw new ArgumentException("Duplicate cards.");
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            if (IsFlush(hand) && IsStraight(hand))
            {
                return true;
            }

            return false;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            int turns = ValidHandCardsCount - MaxSameFaceCount + 1;
            int count = 1;

            for (int i = 0; i < turns; i++)
            {
                for (int j = i+1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        count++;
                    }

                    if (count == MaxSameFaceCount)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            CardSuit handSuit = hand.Cards[0].Suit;

            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[i].Suit != handSuit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            var sorted = hand.Cards
                .Select(card => (int)card.Face)
                .OrderBy(value => value).ToArray();

            for (int i = 0; i < sorted.Length - 1; i++)
            {
                if (sorted[i + 1] != sorted[i] + 1)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
