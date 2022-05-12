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

      var EndOfJuly = MidJuly.LastDayOfMonth();

      Console.WriteLine(EndOfJuly.ToLongDateString());
    }
  }

}
