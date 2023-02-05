using System.Collections.Generic;
using System;

namespace PrimeSifting.Models
{
  public class Prime
  {
    public int Number { get; }
    private static List<int> _numList = new List<int> { };
    private static List<int> _primeList = new List<int> { };

    public Prime(int input)
    {
      Number = input;
      if (input >= 2)
      {
        createNumList();
        createPrimeList();
      }
      else
      {
        //do nothing
      }
    }

    public void createNumList()
    {
      for (int index = 2; index <= Number; index++)
      {
        _numList.Add(index);
      }
    }
    public void createPrimeList()
    {
      List<int> testList = new List<int> { };
      testList.AddRange(_numList);
      for (int prime = 2; prime <= Number; prime++)
      {
        testList.RemoveAll(x => x % prime == 0 && x != prime);
      }
      _primeList = testList;
    }

    public List<int> GetNumList()
    {
      return _numList;
    }

    public List<int> GetPrimeList()
    {
      return _primeList;
    }

    public static void ClearAll()
    {
      _numList.Clear();
      _primeList.Clear();
    }
  }
}