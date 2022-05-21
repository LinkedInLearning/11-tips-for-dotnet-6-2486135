using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsConsole {
  internal static class PathExtensions {

    public static string MakePathString(this string candidatePath) {

      if (candidatePath.IsAbsolutePath())
        return Path.GetFullPath(candidatePath);
      var fakeRoot = Environment.CurrentDirectory; // Get a cross platform full path
      var combined = Path.Combine(fakeRoot, candidatePath);
      combined = Path.GetFullPath(combined);
      return combined.RelativeTo(fakeRoot);
    }

    // For platform consistency it is best to use the Path.DirectorySeparatorChar
    // to determine the proper character to use when deploying apps on different platforms.
    private static bool IsAbsolutePath(this string candidatePath) {
      ArgumentNullException.ThrowIfNull(candidatePath, nameof(candidatePath));

      var isRooted = Path.IsPathRooted(candidatePath);
      var isSomething = !Path.GetPathRoot(candidatePath).Equals(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal);
      var isAnother = !Path.GetPathRoot(candidatePath).Equals(Path.AltDirectorySeparatorChar.ToString(), StringComparison.Ordinal);


      return isRooted && isSomething && isAnother;

    }

    private static string RelativeTo(this string filespec, string folder) {
      var pathUri = new Uri(filespec);

      // Include an end slash on the path
      if (folder.EndsWith(Path.DirectorySeparatorChar.ToString()) == false)
      {
        folder += Path.DirectorySeparatorChar;
      }
      var folderUri = new Uri(folder);
      return Uri.UnescapeDataString(folderUri.MakeRelativeUri(pathUri).ToString()
          .Replace('/', Path.DirectorySeparatorChar));
    }
  }
}
