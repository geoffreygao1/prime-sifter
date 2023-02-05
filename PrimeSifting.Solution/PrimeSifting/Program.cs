using System;
using System.Collections.Generic;
using PrimeSifting.Models;

namespace PrimeSifting
{
  public class Program
  {
    public static void Main()
    {
      Console.Write("Please enter a number:");
      int inputNum = int.Parse(Console.ReadLine());
      if (inputNum >= 2)
      {
        Prime inputPrime = new Prime(inputNum);
        List<int> primeList = inputPrime.GetPrimeList();
        Console.Write("Prime Numbers up to the number " + inputNum + " are: ");
        Console.WriteLine(" ");
        foreach (int x in primeList)
        {
          Console.WriteLine(x);
        }
      }
      else
      {
        Console.WriteLine("Please enter a number greater than or equal to 2");
        Main();
      }
    }
  }
}