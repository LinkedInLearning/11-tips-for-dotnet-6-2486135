using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsConsole {
  internal class TopThreeHourly {
    private List<string> _flowersSold;
    private List<string> _treesSold;
    public TopThreeHourly() {
      _flowersSold = new List<string>(capacity:3);
      _treesSold = new List<string>(capacity: 3);
      _flowersSold.Add("Amber Rose");
      _flowersSold.Add("Bluebell");

      _flowersSold.Add("Calla Lily");

      _treesSold.Add("Alder");
      _treesSold.Add("Birch");
      _treesSold.Add("Cedar");


    }

    public IEnumerable<string> FlowersSold
    {
      get
      {

        return _flowersSold.AsEnumerable();
      }
    }

    public IReadOnlyCollection<string> TreesSold
    {
      get
      {

        return new ReadOnlyCollection<string>(_treesSold);
      }
    }
  }
}
