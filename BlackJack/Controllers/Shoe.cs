using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackJack.Controllers
{
    public class Shoe : Models.Interfaces.IShoe
    {
        public Shoe(int numberOfDecks=1)
        {
            this.numberOfDecks = numberOfDecks;
            if (shoe == null)
            {
                shoe = new List<Models.Card>();
            }
            usedCards = new List<Models.Card>();
            SetLengthOfPlayableCards();
        }
        public void  FillShoe()
        {
            foreach(Models.Card card in DeckFactory.BuildDeck())
            {
                for(int numberOfDeckIndex=0; numberOfDeckIndex<numberOfDecks;numberOfDeckIndex++)
                {
                    shoe.Add(card);
                }
            }
        }
        public void Shuffle()
        {
            Random rand = new Random();
            int n = shoe.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                Models.Card  temp= shoe[k];
                shoe[k] = shoe[n];
                shoe[n] = temp;
            }
        }
        public Models.Card GetTopCard()
        {
            usedCards.Add(shoe[0]);
            shoe.RemoveAt(0);
            return usedCards.Last();
        }
        private void SetLengthOfPlayableCards()
        {
            sizeOfPlayableCards = Convert.ToInt32(DeckFactory.BuildDeck().Count * .8);
        }
        public  void AddUsedCardsBackIntoShoe()
        {
            shoe.AddRange(usedCards);
        }
        private List<Models.Card> shoe {get; set; }
        private int numberOfDecks { get; set; }
        private List<Models.Card> usedCards;
        private int sizeOfPlayableCards { get; set; }
    }
}