using System;

namespace diceconsole
{
  class Program
  {
    static void Main(string[] args)
    {
      play();

    }

    static void play()
    {

      Console.WriteLine("We're gonna roll 2 dice!");
      Console.WriteLine("Type roll to start!");

      String entry = Console.ReadLine();
      if (entry == "roll")
      {
        rolldice();
      }
      else
      {
        return;
      }
    }
    static void rolldice()
    {
      Console.Clear();
      var r = new Random();
      var d1 = r.Next(1, 6);
      var d2 = r.Next(1, 6);

      Console.WriteLine($"You rolled a {d1} and a {d2}!");
      if (d1 != d2)
      {
        Console.WriteLine($"That means you got {d1 + d2} points!");
        play();
      }
      else
      {
        Console.WriteLine("Thats a tie, you lose!");
        play();
      }


    }

  }
}
