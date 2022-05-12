using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TipsConsole;

namespace TipsConsole {
  internal class Program {

    static void Main(string[] args) {


      var examples = new Examples();
      examples.RunExample();


    }


  }

}
