using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipsConsole;

namespace TipsConsole {
  internal class Examples {
    public void RunExample() {


      var MidJuly = new DateOnly(year: 2024, month: 7, day: 12);
      var EndAugust = new DateOnly(year: 2024, month: 8, day: 31);
      var EndOfJuly = MidJuly.LastDayOfMonth();

      Console.WriteLine(EndOfJuly.ToLongDateString());

      var isLastDay = EndAugust.IsLastDayOfMonth();

      // check for range intersect

      var JuneDate = new DateOnly(year: 2024, month: 6, day: 19);
      var JulyDate = new DateOnly(year: 2024, month: 7, day: 15);
      bool doIntersect = MidJuly.RangeInterects(EndOfJuly, JuneDate, JulyDate);
    }
  }

}
