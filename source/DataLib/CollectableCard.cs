using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLib {
  public class CollectableCard {

    public int Id { get; set; }
    public string Name { get; set; }
    public string Slogan { get; set; }
    public int EyeCount { get; set; }

    public Dictionary<string, string> Details { get; set; } = new Dictionary<string, string>();

    public TeamNames TeamName { get; set; }

    public string Description { get; set; }
    public decimal CatalogPrice { get; set; }
    public decimal BidPrice { get; set; }

    public decimal SalePrice
    {
      get
      {
        if (IsDiscounted)
        {
          return BidPrice * .75M;
        }
        else
        {
          return BidPrice;
        }

      }
    }
    public string ImageUri { get; set; }
    public string ShortDescription { get; set; }
    public int PopularityIndex { get; set; }

    public CardFamily CardFamily { get; set; }


    public bool IsDiscounted
    {
      get { return PopularityIndex < 450; }

    }

  }
  public enum CardFamily {
    NotSet = 0,
    Monsters = 1,
    Aliens = 2,
    Robots = 4,
    Animals = 8
  }
  public enum TeamNames {
    BlueShadows,
    ThunderHeads,
    SpookTones,
    Crashmasters,
    Mavericks,
    LaserPhasers,
    Helios,
    Farsiders,
    SuperNovas
  }

}
