using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWords.Models;
using System;
using System.Collections.Generic;

namespace NumberToWords.Tests
{
  [TestClass]
  public class NumberTests
  {


    // [TestMethod]
    // public void CheckLetter_AddsToArray_period()
    // {
    //   Assert.AreEqual("three four", Numbers.ToLetters(34));
    // }

    [TestMethod]
    public void CheckLetter_AddsToArray_million()
    {
      Assert.AreEqual("five million zero zero one thousand zero three four", Numbers.ToLetters(3));
    }
      [TestMethod]
      public void CheckLetter_AddsToArray_millioasn()
      {
        Assert.AreEqual("five million zero zero one thousand zero three four", Numbers.ToLetters(5));
    }
  }
}
