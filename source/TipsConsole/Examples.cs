using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsConsole {
    internal class Examples {
        public void RunExample() {

      Console.WriteLine("Get file path for Linux or Windows.");
      Console.WriteLine();
      string path = @"c:\readme.txt";
      string path2 = @"c:\\files\images\logo.png";
      string path3 = @"c:\\files\images\..\sales.xlsx";

      string path4 = @"files\images\banner.jpg";


      string path5 = @"\files\music\song.wav";
      string path6 = @".\files\playlists\list.mpu";
      Console.WriteLine(path.MakePathString());
      Console.WriteLine(path2.MakePathString());
      Console.WriteLine(path3.MakePathString());
      Console.WriteLine(path4.MakePathString());
      Console.WriteLine(path5.MakePathString());
      Console.WriteLine(path6.MakePathString());

    }
    }

}
