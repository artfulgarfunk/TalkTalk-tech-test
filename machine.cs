using System;
namespace VendingMachinesGenerally
{
  class VendingMachine
  {
    // member variables i.e. attributes
    double price;
    string product;
    public void Acceptdetails()
    {
      price = 3;
      product = "sandwich";
    }

    public double ListDetails()
    {
        return 3 + 5;
    }

    public void Display()
    {
      Console.WriteLine("price is {0}", price);
      Console.WriteLine("product is {0}", product);
    }
  }

  class Vend
  {
    // string a;
    static void Main(string[] args)
    {
      VendingMachine v = new VendingMachine();
      v.Acceptdetails();
      v.Display();
      string a = Console.ReadLine();
      Console.WriteLine("this is what you just wrote " + a);
    }
  }
}
