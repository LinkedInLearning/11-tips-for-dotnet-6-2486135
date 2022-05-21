using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsConsole {
  internal class Examples {
    public void ZipSomeFiles() {
      // the System.IO.Compression namespace
      // contains classes that provide basic compression and decompression services for streams.

      // this tip looks at file compression (Zipped files).
      // assumes windows OS

      var currentPathToFolder = Path.Combine(Environment.CurrentDirectory, "ZipTheseFiles");
      // get desktop location
      var desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      System.IO.Compression.ZipFile.CreateFromDirectory(currentPathToFolder, Path.Combine(desktopFolder, @"cards.zip"));
    }

    public void UnZipSomeFiles() {
      var desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      var zippedFilePath = Path.Combine(desktopFolder, @"cards.zip");
      var destinationFolder = Path.Combine(desktopFolder, @"CardsUnzipped");

      System.IO.Compression.ZipFile.ExtractToDirectory(zippedFilePath, destinationFolder);
    }
  }

}
