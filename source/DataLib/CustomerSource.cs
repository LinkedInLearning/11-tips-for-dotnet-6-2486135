using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib {
  public class CustomerSource {
    private List<Customer> _customerList;
    public CustomerSource() {
      _customerList = new List<Customer>();
      _customerList.Add(new Customer { FullName = "Walt Ritscher", EmailAddress = "walt@somewhere.com", Company = "LinkedIn" , CustomerSince = DateOnly.FromDateTime(new DateTime(year: 2015, month: 11, day: 30)) });
      _customerList.Add(new Customer { FullName = "Richard Wallace", EmailAddress = "richard@somewhere.com", Company = "Big Star Collectibles" , CustomerSince = DateOnly.FromDateTime (new DateTime(year: 2021, month:4, day:12 )) });
    }

    //public List<Customer> Customers
    //{
    //  get
    //  {

    //    return _customerList; 


    //  }
    //}

    public List<Customer> Customers
    {
      get
      {
        
        
        var fakerList = new List<Customer>();
        var customerFaker = new Bogus.Faker<DataLib.Customer>();
        customerFaker.RuleFor(x => x.FullName, x => x.Person.FullName);
        customerFaker.RuleFor(x => x.EmailAddress, x => x.Person.Email);
        customerFaker.RuleFor(x => x.Company, x => x.Person.Company.Name  );
        customerFaker.RuleFor(x => x.CustomerSince, x => DateOnly.FromDateTime(x.Date.Past(5,DateTime.Now)));
        customerFaker.RuleFor(x => x.Review, x => x.Rant.Review());

        for (int counter = 0; counter < 30; counter++)
        {
          fakerList.Add( customerFaker.Generate());
        }

        return fakerList;

      }
    }
  }
}
