using System;
using System.Collections.Generic;

public class Program
  {
    public static void Main()
    {

      Console.WriteLine("Enter a word to see if it is a Palindrome:");
      string userInput = Console.ReadLine();
      string backwardsUserInput = "";

      for (int i = 0; i < userInput.Length; i++)
      {
        if (userInput[userInput.Length -i -1] != userInput[i])
        {
          System.Console.Write("Not a palindrome!");
          i += userInput.Length;
        }
        else if (userInput[userInput.Length -i -1] == userInput[i])
        {
          backwardsUserInput += userInput[i];
        }
      }

      System.Console.Write(backwardsUserInput);

      // for (int i = 0; i < userInput.Length; i++)
      // {
      //   System.Console.Write(userInput[userInput.Length -i -1]);
      //
      //   if (userInput[userInput.Length -i -1] == userInput[i])
      //   {
      //     Console.WriteLine("You made it");
      //   }
      // }
    }
  }
