using System;
using System.Threading;
namespace TipsConsole {
  internal class Program {

    static void Main(string[] args) {
      Console.WriteLine("A simple console application.");
      Console.WriteLine();
      var spinner = new ConsoleSpinner();

      while (true)
      {
        Thread.Sleep(10);
        spinner.Turn();
      }

    }
  }

  public class ConsoleSpinner {
    int counter = 0;
    int colorCounter = 0;
    int rowCounter = 1;
    public ConsoleSpinner() {
     
    }
    public void Turn() {
      counter++;

      switch (counter % 5)
      {
        case 0: Console.Write("-  "); colorCounter++;  break;
        case 1: Console.Write("-"); break;
        case 2: Console.Write("\\"); break;
        case 3: Console.Write("|"); break;
        case 4: Console.Write("/"); break;


      }
      if (counter % 5 == 0)
      {

        Console.ForegroundColor = (ConsoleColor)Enum.ToObject(typeof(ConsoleColor), colorCounter % 16);
      }

      if (counter % 25 == 0)
      {

        Console.SetCursorPosition(0, Console.CursorTop +1);
        rowCounter++;                       
        
      }
      if (rowCounter % 8 == 0)
      {
        rowCounter++;
        Console.SetCursorPosition(0, 2);
      }
    }
  }
}


