using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PrimeSifting.Models;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Prime.ClearAll();
    }

    [TestMethod]
    public void PrimeConstructor_CreatesInstanceOfItem_Prime()
    {
      int testInput = 3;
      Prime newPrime = new Prime(testInput);
      Assert.AreEqual(typeof(Prime), newPrime.GetType());
      Assert.AreEqual(3, newPrime.Number);
    }

    [TestMethod]
    public void PrimeConstructor_CreatesListofNumbers_Prime()
    {
      int testInput = 5;
      Prime newPrime = new Prime(testInput);
      List<int> testNumList = newPrime.GetNumList();
      Assert.AreEqual(2, testNumList[0]);
      Assert.AreEqual(3, testNumList[1]);
      Assert.AreEqual(4, testNumList[2]);
      Assert.AreEqual(5, testNumList[3]);
    }

    [TestMethod]
    public void PrimeConstructor_CreatesPrimeList_Prime()
    {
      int testInput = 7;
      Prime newPrime = new Prime(testInput);
      List<int> testPrimeList = newPrime.GetPrimeList();
      Assert.AreEqual(2, testPrimeList[0]);
      Assert.AreEqual(3, testPrimeList[1]);
      Assert.AreEqual(5, testPrimeList[2]);
      Assert.AreEqual(7, testPrimeList[3]);
    }

  }
}