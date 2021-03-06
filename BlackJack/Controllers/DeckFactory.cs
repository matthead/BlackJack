﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackJack.Controllers
{
    public static class DeckFactory
    {

        public static List<Models.Card> BuildDeck()
        {
            if (deck == null)
            {
                deck = new List<Models.Card>();
            }
            foreach (Models.Suit suit in Enum.GetValues(typeof(Models.Suit)))
            {
                foreach (Models.FaceValue faceValue in Enum.GetValues(typeof(Models.FaceValue)))
                {
                    deck.Add(new Models.Card(suit, faceValue));
                }
            }
            return deck;
        }
        private static List<Models.Card> deck;
    }
}