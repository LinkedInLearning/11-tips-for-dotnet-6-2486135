using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsConsole {
    internal class Examples {
        public void FlattenLists() {
            var brandA = new Brand { Name = "Fancy-Shoes", Colors = new List<string> { "Red", "Orange" } };
            var brandB = new Brand { Name = "Lux-Cars", Colors = new List<string> { "Gold", "Silver" } };
            var brandC = new Brand { Name = "Wow-Electronics", Colors = new List<string> { "Black", "Purple", "Gold" } };

            List<Brand> brands = new List<Brand>();
            brands.Add(brandA);
            brands.Add(brandB);
            brands.Add(brandC);

            // there are seven colors in the .Colors property

            // Flatten a multi-dimension set into a single set
            // IN .NET use LINQ .SelectMany or .ContinueWith

            // this works, but is not optimal

            List<List<string>> colorsA = brands.Select(x => x.Colors).ToList();
            Console.WriteLine(colorsA);

            foreach (var colors in colorsA)
            {
                foreach (var color in colors)
                {
                    Console.WriteLine(color);
                }
            }
            // flatten

            List<string> colorsB = brands.SelectMany(x => x.Colors).ToList();
            foreach (var color in colorsB)
            {
                Console.WriteLine(color);
            }
        }
    }

    public class Brand {
        public string Name { get; set; }
        public List<string> Colors { get; set; }
    }
}
