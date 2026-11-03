using System;
using System.Text.RegularExpressions;


class Program
{
   static string FilterText(string text)
   {
       Regex myReg = new Regex(
           @"кор(ень|ня|нем|ні|нів)",
           RegexOptions.IgnoreCase
       );


       return myReg.Replace(text, "[-------]");
   }


   static void Main(string[] args)
   {
       Console.Write("Введіть текст: ");
       string text = Console.ReadLine();


       string result = FilterText(text);


       Console.WriteLine("Результат:");
       Console.WriteLine(result);
   }
}

