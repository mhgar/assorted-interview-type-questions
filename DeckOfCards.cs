using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/* Question: Construct a standard deck of 52 cards. Shuffle this deck and draw two cards at random. Display the two cards. */
public static class Program {
	public static void Main() {
		string[] cards = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
		string[] suits = { "Spades", "Clubs", "Hearts", "Diamonds" };
		
		var deck = from card in cards
			       from suit in suits
			       select $"{card} of {suit}";
		
		var random = new Random();
		var shuffledDeck = deck.OrderBy(card => random.Next()).ToList(); // Use a list to preserve order.
		
		var firstDraw = shuffledDeck[random.Next(0, 51)];
		var secondDraw = shuffledDeck[random.Next(0, 51)];		
		Console.WriteLine(firstDraw);
		Console.WriteLine(secondDraw);
	}
}
