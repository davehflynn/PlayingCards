using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
	public interface IDeck
	{
		void Shuffle();
		ICard DealOneCard();
		void Init();
		void PrintCard(ICard card);
	}
}
