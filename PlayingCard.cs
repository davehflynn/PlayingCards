using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
    public class PlayingCard : ICard
    {
        protected PlayingCardValue playingCardValue;
        protected PlayingCardSuit playingCardSuit;

        public PlayingCardValue PlayingCardValue
        {
            get { return playingCardValue; }
            set { playingCardValue = value; }
        }

        public PlayingCardSuit PlayingCardSuit
        {
            get { return playingCardSuit; }
            set { playingCardSuit = value; }
        }
    }
}
