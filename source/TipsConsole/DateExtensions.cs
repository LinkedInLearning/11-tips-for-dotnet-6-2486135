using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsConsole {
  public static class DateExtensions {

    public static DateOnly LastDayOfMonth(this DateOnly candidate) {
      var days = DateTime.DaysInMonth(candidate.Year, candidate.Month);
      return new DateOnly(candidate.Year, candidate.Month, days);
    }

    public static DateOnly LastDayOfMonth2(this DateOnly candidate) {

      return new DateOnly(candidate.Year, candidate.Month, 1).AddMonths(1).AddDays(-1);
    }
    public static bool IsLastDayOfMonth(this DateOnly candidate) {

      return candidate == candidate.LastDayOfMonth();
    }

    public static bool RangeIntersects(this DateOnly rangeStart, DateOnly rangeEnd, DateOnly otherRangeStart, DateOnly otherRangeEnd) {

      return rangeStart < otherRangeEnd && otherRangeStart < rangeEnd;
    }
  }
}
