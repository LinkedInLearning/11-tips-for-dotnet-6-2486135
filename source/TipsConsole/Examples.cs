using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsConsole {
  internal class Examples {
    public void RunExample() {
      var top = new TopThreeHourly();
      foreach (var sensor in top.FlowersSold)
      {
        Console.WriteLine(sensor);
      }

      ((List<string>)top.FlowersSold).Add("Zinnia");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("--------");
      foreach (var sensor in top.FlowersSold)
      {
        Console.WriteLine(sensor);
      }

      Console.ForegroundColor = ConsoleColor.White;
    }
  }

}
