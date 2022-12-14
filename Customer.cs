using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManangement
{
  public class Customer
  {
    public int CustomerId { get; private set; }
    public string EmailAddress { get; set; }

    public string FirstName { get; set; }

    public string FullName
    {
      get
      {
        return LastName + "," + FirstName;
      }
    }
    private string _lastName;
    public string LastName
    {
      get
      {
        return _lastName;
      }
      set
      {
        _lastName = value;
      }
    }
  }
}

