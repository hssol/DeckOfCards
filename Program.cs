using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Card 
    {
        public string Suit;
        public int Val;
        public string stringVal;
        public Card(string suit, int val, string sVal)
        {
            Suit = suit;
            Val = val;
            stringVal = sVal;
        }
    }
    class Deck
    {
        public List<Card> newDeck;
        public string[] cardNames = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
        public string[] cardSuits = {"Spade", "Jack", "Heart", "Club"};
        public Deck()
        {
            newDeck = new List<Card>{};
            foreach (string suit in cardSuits)
            {
                for (int x = 0; x <= 12; x++)
                {
                    newDeck.Add(new Card(suit, x+1, cardNames[x]));
                }
            }
        }
        public void Deal(List<Deck> newDeck)
        {
            // newDeck = new List<Deck>();
            // Card draw = newDeck[0];
            // newDeck.Remove(newDeck[0]);
            // Console.WriteLine(draw);
            
        }
    }
       
    
    class Player
    {
        public string Name;
        public List<Card> Hand;
        public Player(List<object>[] hand){
            Name = "Bob";
            Hand = new List<Card>{};
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            foreach (Card card in newDeck.newDeck)
            {
                Console.WriteLine($"{card.Suit}:{card.stringVal}({card.Val})");
            }
            
        }
    }
}
