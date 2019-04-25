using System;
using System.Collections.Generic;

namespace NumberToWords.Models
{
  public class Numbers
  {
    private static Dictionary<long,string> Ones = new Dictionary<long,string> {
            {90, "ninety"},
            {80, "eighty"},
            {70, "seventy"},
            {60, "sixty"},
            {50, "fifty"},
            {40, "fourty"},
            {30, "thirty"},
            {20, "twenty"},
            {19, "nineteen"},
            {18, "eighteen"},
            {17, "seventeen"},
            {16, "sixteen"},
            {15, "fifteen"},
            {14, "fourteen"},
            {13, "thirteen"},
            {12, "twelve"},
            {11, "eleven"},
            {10, "ten"},
            {9, "nine"},
            {8, "eight"},
            {7, "seven"},
            {6, "six"},
            {5, "five"},
            {4, "four"},
            {3, "three"},
            {2, "two"},
            {1, "one"}

        };
    public static string ToLetters(long theNum)
    {
      string result = "";
      long[] numArray = digitArr(theNum);
      for(int i = 0;i<numArray.Length-2;i+=3)
      {
        string toAdd = "";
        long theNums = numArray[numArray.Length-( 1+ (i))]+(numArray[numArray.Length- (2+ (i))]*10)+1;
        if(numArray[numArray.Length- 3- (i)] > 0)
        {
          toAdd += Ones[numArray[numArray.Length- (3+ i)]] + " hundred ";
        }
        foreach(KeyValuePair<long,string> nums in Ones)
        {
          if(theNums > nums.Key){
            toAdd += nums.Value + " ";
            theNums -= nums.Key;
          }
        }


        if(i == 12 && toAdd.Length > 0)
        {
          toAdd += "trillion " ;
        }else
        if(i == 9 && toAdd.Length > 0)
        {
          toAdd += "billion ";
        }else
        if(i == 6 && toAdd.Length > 0)
        {
          toAdd += "million ";
        }else
        if(i == 3 && toAdd.Length > 0)
        {
          toAdd += "thousand ";
        }
        result =  toAdd + result;
      }

      if(numArray.Length % 3 > 0){
        string toAdd = "";

        long theNums;
        if(numArray.Length % 3 == 2)
        {
          theNums = numArray[1]+1+numArray[0]*10;
        }else{
          theNums = numArray[0]+1;
        }

        foreach(KeyValuePair<long,string> nums in Ones)
        {
          if(theNums > nums.Key){
            toAdd += nums.Value + " ";
            theNums -= nums.Key;
          }
        }

        if(numArray.Length >= 12 && toAdd.Length > 0)
        {
          toAdd += "trillion " ;
        }else
        if(numArray.Length >= 9  && toAdd.Length > 0)
        {
          toAdd += "billion ";
        }else
        if(numArray.Length >= 6 && toAdd.Length > 0)
        {
          toAdd += "million ";
        }else
        if(numArray.Length >= 3 && toAdd.Length > 0)
        {
          toAdd += "thousand ";
        }
        result =  toAdd + result;
      }
      result = result.TrimEnd();
      return result;
    }

    private static long[] digitArr(long n)
    {
        if (n == 0) return new long[1] { 0 };

        var digits = new List<long>();

        for (; n != 0; n /= 10)
            digits.Add(n % 10);

        var arr = digits.ToArray();
        Array.Reverse(arr);
        return arr;
    }

  }
}
