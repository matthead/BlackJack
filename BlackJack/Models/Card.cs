﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackJack.Models
{
    public enum Suit
    {
        hearts,diamonds,clubs,spades
    };
    public enum FaceValue
    {
        ace,two,three,four,five,six,seven,eight,nine,ten,jack,queen,king
    };
    public class Card
    {
        public Card(Suit suit, FaceValue faceValue)
        {
            this.suit = suit;
            this.faceValue = faceValue;
        }
        private Suit suit {get;set;}
        private FaceValue faceValue { get; set; }
        public override string ToString()
        {
            return this.faceValue.ToString() + " of " + this.suit.ToString();
        }
    }
}