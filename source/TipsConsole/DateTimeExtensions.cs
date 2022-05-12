using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsConsole {
  public static class DateTimeExtensions {

    public static DateOnly LastDayOfMonth(this DateOnly dt) {
      var days = DateTime.DaysInMonth(dt.Year, dt.Month);
      return new DateOnly(dt.Year, dt.Month, days);
    }

  }
}
