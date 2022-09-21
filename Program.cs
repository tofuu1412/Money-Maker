using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      //Greet the user and get input
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert to coins: ");
      string totalAsString = Console.ReadLine();
      double total = Convert.ToDouble(totalAsString);
      Console.WriteLine($"{total} is equal to...");
      
    // Define coin values
    int goldValue = 10;
    int silverValue = 5;

    // calculate the change
    double goldCoins = Math.Floor(total / goldValue);
    double remainder = total % goldValue;

    double silverCoins = Math.Floor(remainder / silverValue);
    remainder = remainder % silverValue;

    //print the result
    Console.WriteLine($"Gold Coins: {goldCoins}");
    Console.WriteLine($"Silver Coins: {silverCoins}");
    Console.WriteLine($"Bronze Coins: {remainder}");


    }
  }
}
