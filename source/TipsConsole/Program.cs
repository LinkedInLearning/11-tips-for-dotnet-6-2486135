namespace TipsConsole {
  internal class Program {
    static void Main(string[] args) {
      var examples = new Examples();

      examples.HumanizeTime();
      examples.HumanizeFileSize();
      examples.CountThings();

    }
  }
}