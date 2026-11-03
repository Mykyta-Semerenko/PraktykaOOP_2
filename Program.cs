

using System;
using System.Text.RegularExpressions;


class Program
{
   static void Main(string[] args)
   {
       Console.Write("Введіть логін: ");
       string login = Console.ReadLine();


       Regex myReg = new Regex(@"^[a-zA-Z][a-zA-Z0-9]{1,9}$");


       if (myReg.IsMatch(login))
       {
           Console.WriteLine("Логін коректний.");
       }
       else
       {
           Console.WriteLine("Логін некоректний.");
       }
   }
}

