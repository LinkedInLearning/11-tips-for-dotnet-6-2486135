namespace TipsConsole {
  internal class Examples {
    public void GetFileContent() {
      var fakeRoot = Environment.CurrentDirectory; // Get a cross platform full path
      var filePath = Path.Join(fakeRoot, "Files", "Readme.txt"); // use Join, not Combine
      Console.WriteLine(filePath);
      Console.WriteLine("-----");
      Console.ForegroundColor = ConsoleColor.Cyan;

      string[] lines = System.IO.File.ReadAllLines(filePath);
      foreach (string line in lines)
      {
        Console.WriteLine(line);
      }

      Console.WriteLine("-----");
      Console.ForegroundColor = ConsoleColor.White;
      Console.ReadLine();
    }

  
    public void PrintToConsole(string path) {
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write($"{path,30},"); Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.WriteLine($"{path.MakePathString(),40}"); Console.ForegroundColor = ConsoleColor.White;
    }
  }

}
