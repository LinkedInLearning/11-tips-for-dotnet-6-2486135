using DataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsConsole {
	internal class Examples {
		public void RunExample() {
			// GroupBy and ToLookup return a sequence that
			// has a key (the group) and an inner sequence based on a key field value.

			var cardSource = new CardSource();
			var collectibles = cardSource.CollectibleCards;
			
			// ILookup vs Dictionary, both hold key and value items
			// ILookup is a IEnumerable<Key, IEnumerable>,
			// think of it as a dictionary with IEnumerable<T> values

			// ILookup is immutable, no .Add method for example
			// ILookup supports null keys
			// Lookup by null key returns an empty sequence (not an exception!)
			ILookup<CardFamily, CollectableCard> lookupByCardFamily;
			lookupByCardFamily = collectibles.ToLookup(c => c.CardFamily);
			var lookupByPrice = collectibles.ToLookup(c => c.IsDiscounted);
			var grouped = collectibles.GroupBy(x => x.CardFamily);

			// Lookup by null key returns an empty sequence (not an exception!)
			var animals = lookupByCardFamily[CardFamily.Animals];

			// 
			foreach (var family in lookupByCardFamily)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine(family.Key);
				// show by CardFamily
				Console.ForegroundColor = ConsoleColor.Green;
				foreach (var card in family)
				{
					Console.WriteLine($"  { card.Name}");
				}
			}

		}
	}


}
