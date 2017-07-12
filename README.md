# Vending Machine

## An Object-Oriented Vending Machine program created in C#

# Design
This project was put together in less than 24 hours, with no prior experience in C# whatsoever.

In order to object orient the process I considered the process as made up or 5 potential classes: User, VendingMachine, Snack, Coin, Vend (as a project runner class). I elected not to use Coin due to time constraints.
Each class should know as little about the others as possible and have separate concerns, as well as DRY and SOLID code.
See the sequence diagram below for program structure.

There are MANY design flaws as a function of unfamiliarity with C#. Given more time here are some obvious next steps:
- I was unable to make the Snacks array available across the whole class instance so it has to be initialized in the processRequest method. It should be initialized within the public VendingMachine() class method as a member variable.
- VendingMachine only returns the change as an integer. It should be relatively simple to deduce what coins were necessary to return to the user by dividing the change owed by progressively smaller coin denominations, then returning them as an array to the User class.
- VendingMachine doesn't return a Snack object to the User class, only a string
- Dependency inversion should be applied to the VendingMachine class as it currently refers directly to the Snack class which is an unnecessary coupling (as opposed to an object which it gets passed on intialization).
- All the methods are public, which means each class has an unnecessarily large public interface. As most of this project was tinkering with C# for the first time, I kept them public so that it would run.
- All of the classes are within one folder. For whatever reason I couldn't successfully separate the classes into different files without errors.
- processRequest method is very long, given more understanding of C# I would keep all methods at 5 lines or less.
- Ideally whenever a VendingMachine is initialized it would have default values but could take arguments to define attributes such as available coins, available stock and so on.


## Requirements
- Vending Machine accepts 50p coins only, but can give correct change
- Vending Machine dispenses either bottle water at 60p or crisps at 40p
- Create a solution that allows us to request a product and deposit the correct number of 50p coins. The response should show that we get the products we asked for and the correct change owed

# Built With
- C#
- Mono Project

# How to Run
- Clone this repo
- Install the mono project (or other C# compiler)
- Compile with mcs vend.cs
- Run with mono vend.exe
- Adapt the user.insertCoins() and user.selectSnack() methods in the Vend class to see how the project runs

# Diagram

![Imgur](http://i.imgur.com/KX7KOc1.png)
