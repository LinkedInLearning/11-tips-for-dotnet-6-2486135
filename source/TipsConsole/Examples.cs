using TipsConsole.Extensions;
namespace TipsConsole {
  internal class Examples {
    public void RunExample() {

      // Characters can consist of multiple code points
      // It's common to think of a string as a sequence of characters
      // However, what the user perceives as a character may be represented as multiple
      // characters in Unicode
      // In most cases it is better to deal with substrings rather than with individual characters.
      // Here is the correct way to get char count when needed.


      var simpleString = "hello";
      // cannot tell from look that the ё character is different in 
      // these two examples
      var cyrillicString1 = "hёllo"; // one Unicode code-point ё
      var cyrillicString2 = "hёllo"; // two Unicode code-points ё
      var stringWithCodePoints = "ha𐐀llo"; // another two point example a𐐀
      bool areEqual = cyrillicString1 == cyrillicString2;
      bool areCultureEqual = string.Compare(cyrillicString1, cyrillicString2) == 0;
           
      var helloCount1 = simpleString.Length;
      var cyCount1 = cyrillicString1.Length;
      var cyCount2 = cyrillicString2.Length;
      var anotherCount1 = stringWithCodePoints.Length;

      var helloCount2 =  simpleString.CountCharacters();
      var cyCount3 = cyrillicString1.CountCharacters();
      var cyCount4 = cyrillicString2.CountCharacters();
      var anotherCount2 = stringWithCodePoints.CountCharacters();

    }

   
  }

}
