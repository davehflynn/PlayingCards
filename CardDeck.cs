using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
	public abstract class CardDeck
	{
		protected List<ICard> cards = new List<ICard>();
		protected int currentCard = 0;
		public CardDeck()
		{
			this.Init();
		}

		public virtual void Init() { }
		public virtual void PrintCard(ICard card) { }

		public void Shuffle()
		{
			var tempCards = new List<ICard>();
			var random = new Random();
			while (cards.Count > 0)
			{
				var shuffledCard = random.Next(0, cards.Count);
				tempCards.Add(cards[shuffledCard]);
				cards.Remove(cards[shuffledCard]);
			}
			cards = tempCards;
		}

		public ICard DealOneCard()
		{
			if (currentCard >= cards.Count)
				throw new InvalidCardException();

			return cards[currentCard++];
		}
	}

}
