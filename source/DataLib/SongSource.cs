using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib {
  public class SongSource {

    public List<Song> Songs
    {
      get

      {
        var labelNames = new[] { "Tune Crooners", "Skyheart", "Green Denim Records", "Whispertime Studios"};
        var fakerList = new List<Song>();
        var songFaker = new Bogus.Faker<DataLib.Song>();

        songFaker.RuleFor(x => x.SongTitle, x => Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(x.Lorem.Slug(3)));
        songFaker.RuleFor(x => x.Genre, x => x.Music.Genre());
        songFaker.RuleFor(x => x.Artist, x => x.Person.UserName);
        songFaker.RuleFor(x => x.Label,  x => x.PickRandom(labelNames));
        //songFaker.RuleFor(x => x.Review, x => x.Rant.Review());

        for (int counter = 0; counter < 18; counter++)
        {
          fakerList.Add(songFaker.Generate());
        }

        return fakerList;
      }
    }

  }
}