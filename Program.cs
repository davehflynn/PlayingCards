using System;

namespace PlayingCards
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				IDeck deck = new CardFactory().GetDeck();
				deck.Shuffle();
				Console.WriteLine("Started Dealing -- ");
				for (int i = 0; i < 53; i++)
				{
					var card = deck.DealOneCard();
					deck.PrintCard(card);
				}
			}
			catch (InvalidCardException e)
			{
				Console.WriteLine("Caught Invalid Card Exception - " + e.GetBaseException());
			}
		}
    }
}
