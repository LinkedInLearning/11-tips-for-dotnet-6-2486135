using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipsConsole;

namespace TipsConsole {
  internal class Examples {
    public void DataChecks() {

      
      var MidJuly = new DateOnly(year: 2024, month: 7, day: 12);
      var EndOfAugust = new DateOnly(year: 2024, month: 8, day: 31);
      var EndOfJuly = MidJuly.LastDayOfMonth();

      Console.WriteLine(EndOfJuly.ToLongDateString());

      var isLastDay = EndOfAugust.IsLastDayOfMonth();


      // check for range intersect
      var JuneFirst = new DateOnly(year: 2024, month: 6, day: 1);
      var MidJune = new DateOnly(year: 2024, month: 6, day: 19);
      var JulyDate = new DateOnly(year: 2024, month: 7, day: 15);

      // Range1 = July 12 to July 31, 
      // Range2 = June 19 to August 31
      bool doIntersect = MidJuly.RangeIntersects(EndOfJuly, MidJune, EndOfAugust);

      bool anotherIntersect = EndOfJuly.RangeIntersects(EndOfAugust, JuneFirst, MidJune);

    }

   

  }

}
