using System;
using System.Collections.Generic;

namespace VendingMachineApplication
{
  public class VendingMachine
  {

    public Snack[] Snacks { get; set; }
    // public double[] coins { get; set; }
    public double credit { get; set; }
    public double change { get; set; }

    public VendingMachine()
    {
      credit = 0;
      change = 0;
    }

    public string updateCredit(int amount)
    {
      credit = amount*50;
      return("User credit: £" + credit/100 + "\nSelect 1. for Water or \n2. for Chips");
    }

    public string processRequest(int selection)
    {
      Snack[] Snacks = new Snack[2];
      Snack s = new Snack("Water", 60);
      Snack c = new Snack("Chips", 40);
      Snacks[0] = s;
      Snacks[1] = c;
      change = credit - Snacks[selection-1].Price;
      if (change < 0) {
        change = credit;
        return("Insufficient Funds for " + Snacks[selection-1].Name + " - Please Enter More Money");
      } else {
        credit = change;
        return("Product Dispensed: " + Snacks[selection-1].Name + "\nChange: " + this.returnChange(change));
      }
    }

    public string returnChange(double change)
    {
      return(change.ToString());
    }
  }

  public class Snack
  {
    public string Name { get; set; }
    public double Price { get; set; }

    public Snack(string initString, double initDouble)
    {
      Name = initString;
      Price = initDouble;
    }
  }

  public class User
  {
    public void insertCoins(int quantity, VendingMachine vm)
    {
      Console.WriteLine(vm.updateCredit(quantity));
    }

    public void selectSnack(int selection, VendingMachine vm)
    {
      Console.WriteLine(vm.processRequest(selection));
    }
  }

  public class Vend
  {
    static void Main(string[] args)
    {
      VendingMachine v = new VendingMachine();
      User user = new User();
      // PUBLIC METHODS FOR CLI INTERFACE
      user.insertCoins(2, v);
      user.selectSnack(2, v);
      user.selectSnack(1, v);
      user.selectSnack(1, v);
      user.insertCoins(2, v);
      user.selectSnack(1, v);
    }
  }
}
