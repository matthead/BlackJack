using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackJack.Models
{
    public class Hand
    {
        public Hand()
        {
            if (hand == null)
            {
                hand = new List<Card>();
            }
        }
        public List<Card> hand { get; private set; }
    }
}