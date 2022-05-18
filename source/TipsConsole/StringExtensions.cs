using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsConsole.Extensions {
  public static class StringExtensions {

    public static int CountCharacters(this string candidateString) {
      if (String.IsNullOrEmpty(candidateString))
        return 0;
      int count = 0;
      var enumerator = System.Globalization.StringInfo.GetTextElementEnumerator(candidateString);
      while (enumerator.MoveNext())
        ++count;
      return count;
    }
  }
}
