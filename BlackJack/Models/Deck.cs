using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackJack.Models
{
    public static class Deck
    {
        private static List<Card> deck { get; set; }
        public static List<Card> BuildDeck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (FaceValue faceValue in Enum.GetValues(typeof(FaceValue)))
                {
                    deck.Add(new Card(suit, faceValue));
                }
            }
            return deck;
        }
    }
}