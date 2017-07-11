using System;
using System.Collections.Generic;

namespace VendingMachineApplication
{
  class VendingMachine
  {
    // member variables i.e. attributes
    static Dictionary<string, int> data { get; set; }
    public string[] snacks { get; set; }
    public double[] purse { get; set; }
    public double credit { get; set; }

    // constructor i.e. intialize with defaults
    public VendingMachine()
    {
      // IDictionary<string, int> dict = new Dictionary<string, int>();
      // dict = new dictionary<product, price> {"Water" => ,60};
      data = new Dictionary<string, int>(){
        {"Ancestor", 17},
        {"Successor", 18}
      };
      snacks = new string[] {"water","chips"};
      purse = new double[] {20,10,5,2,1};
      credit = 0;
    }

    public void insertCoins(int x)
    {
      credit = x*50;
      Console.WriteLine("User inserted " + x + " 50p coins");
      Console.WriteLine("User credit: £" + credit/100);
    }

    public void selectSnack(int x)
    {
      Console.WriteLine("Selected Snack " + snacks[(x-1)]);
      Console.WriteLine("Dictionary" + data["Ancestor"]);
      Console.WriteLine(this.returnChange());
    }

    public string returnChange()
    {
      return "waffles";

    }

    public void Display()
    {
      // Console.WriteLine("price is {0}", price);
      Console.WriteLine("Select Product:\n1 for {0}\n2 for {1}", snacks[0],snacks[1]);
    }

  }

  class Vend
  {
    // string a;
    static void Main(string[] args)
    {
      // User u = new User();
      VendingMachine v = new VendingMachine();

      // PUBLIC METHODS FOR CLI INTERFACE LATER
      Console.WriteLine(v.credit);
      v.Display();
      v.insertCoins(2);
      v.selectSnack(1);
      // u.insertCoin(2,v)
      // Console.WriteLine(v.snacks)
      // v.Acceptdetails();
      // string a = Console.ReadLine();
      // Console.WriteLine("this is what you just wrote " + a);
    }
  }
}

// class User
// {
//   public double[] purse { get; set; }
//
//   public User()
//   {
//     purse = new double[] { 50, 50, 50, 50};
//   }
//
//   public void Display()
//   {
//     Console.WriteLine("User has " + purse.Length + " 50p coins");
//   }
//
// }
