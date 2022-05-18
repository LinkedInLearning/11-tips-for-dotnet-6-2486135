using DataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsConsole {
  internal class Examples {
    public void RunExample() {
      // GroupBy and ToLookup return a collection that
      // has a key and an inner collection based on a key field value.

      // GroupBy is an IQueryable, with deferred execution
      // ToLookup is an IEnumerable with immediate execution

      var cardSource = new CardSource();
      var collectibles = cardSource.CollectibleCards;

      // ILookup vs Dictionary, both hold key and value items
      // Ilookup value is a IEnumerable
      // ILookup is immutable, no .Add method for example
      // ILookup supports null keys
      ILookup<CardFamily, CollectableCard> lookupByCardFamily = collectibles.ToLookup(c => c.CardFamily);
      var lookupByPrice = collectibles.ToLookup(c => c.IsDiscounted);
   

      // 
      foreach (var family in lookupByCardFamily)
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(family.Key);
        // full price cards
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var card in family)
        {
          Console.WriteLine($"  { card.Name}");
        }
      }
    }
  }


}
