using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
    class InvalidCardException : Exception
    {
        public InvalidCardException()
            : base("The deck is empty.")
        {
        }
    }
}
