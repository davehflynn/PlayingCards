using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
	public class CardFactory
	{
		public IDeck GetDeck()
		{
			return new PlayingCardDeck();
		}
	}
}
