using Humanizer;
namespace TipsConsole {
  internal class Examples {
    public void HumanizeTime() {
      var theTime = DateTime.Now;
      Console.WriteLine(theTime.ToShortTimeString());
      Console.WriteLine(theTime.AddMonths(-5).Humanize());
      Console.WriteLine(theTime.AddMinutes(12).Humanize());

      // use the TimeSpan fluent syntax
      TimeSpan weeks = 3.Weeks() + 2.Weeks();
      Console.WriteLine(weeks.Humanize());
      Console.WriteLine(17.Minutes());

    }
    public void HumanizeFileSize() {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Humanizer.Bytes.ByteSize imageSize = (14).Gigabytes();

      Humanizer.Bytes.ByteSize songSize = (2048).Megabytes();

      Console.WriteLine(imageSize.Humanize());
      Console.WriteLine(songSize.Humanize());

    }
    public void CountThings() {

      Console.ForegroundColor = ConsoleColor.Red;

      Console.WriteLine("cards".ToQuantity(6));
      Console.WriteLine("cards".ToQuantity(6, ShowQuantityAs.Words));
      Console.WriteLine("cards".ToQuantity(1));
      Console.WriteLine("women".ToQuantity(3));
      Console.WriteLine("women".ToQuantity(1));

      Console.WriteLine(14576.ToWords());
      Console.WriteLine(35.ToRoman());

      for (int counter = 0; counter < 10; counter++)
      {
        Console.WriteLine($"{counter}, {counter.ToOrdinalWords()}");
      }
      var numbers = Enumerable.Range(20,6);
      Console.WriteLine(numbers.Humanize());
      Console.ForegroundColor = ConsoleColor.DarkCyan;

      // metric values
      Console.WriteLine(.045d.ToMetric());
      Console.WriteLine( 2654d.ToMetric());
    }
   

    }

}
