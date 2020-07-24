using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
	public class PlayingCardDeck : CardDeck, IDeck
	{
		public override void PrintCard(ICard card)
		{
			Console.WriteLine(card.PlayingCardValue + " Of " + card.PlayingCardSuit);
		}

		public override void Init()
		{
			var numOfSuits = (int)Enum.GetValues(typeof(PlayingCardSuit)).Length;
			var numOfValues = (int)Enum.GetValues(typeof(PlayingCardValue)).Length;

			for (int i = 0; i < numOfSuits; i++)
			{
				for (int j = 0; j < numOfValues; j++)
				{
					var card = new PlayingCard();
					card.PlayingCardSuit = (PlayingCardSuit)i;
					card.PlayingCardValue = (PlayingCardValue)j;
					cards.Add(card);
				}
			}
		}
	}
}
