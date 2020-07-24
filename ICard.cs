using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
    public interface ICard
    {
        PlayingCardValue PlayingCardValue { get; set; }
        PlayingCardSuit PlayingCardSuit { get; set; }
    }
}
