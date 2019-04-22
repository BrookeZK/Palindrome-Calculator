using System;
using System.Collections.Generic;

public class Program
{
  public static void Main()
  {

    Console.WriteLine("Enter a word to see if it is a Palindrome:");
    string userInput = Console.ReadLine();
    // string lowerCaseUserInput = userInput.ToLower();
    // string spaceString = " ";
    string backwardsUserInput = "";
    // List<string> removeSpaces = new List<string>{};

    // for (int i = 0; i < lowerCaseUserInput.Length; i++)
    // {
    //   if (lowerCaseUserInput[i] == spaceString[0])
    //   {
    //     removeSpaces.Add(lowerCaseUserInput[i])
    //     Console.WriteLine(removeSpaces);
    //     // removeSpaces.Remove(" ");
    //   }
    // }

    for (int i = 0; i < userInput.Length; i++)
    {
      if (userInput[userInput.Length -i -1] != userInput[i])
      {
        Console.WriteLine("Not a palindrome!");
        i += userInput.Length;
      }
      else if (userInput[userInput.Length -i -1] == userInput[i])
      {
        backwardsUserInput += userInput[i];
      }
    }

    if (backwardsUserInput.Length == userInput.Length)
    {
      Console.WriteLine("Congratulations, this is a Palindrome: ");
      Console.WriteLine(userInput + " is " + backwardsUserInput + " backwards. Now ya Know.");
    }
  }

}
