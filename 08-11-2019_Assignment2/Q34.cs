using System;
namespace _08_11_2019_Assignment2
{
  class Q34
  {
      public static void Run()
      {
          string input,new_String, first,second;
          Console.WriteLine("Enter the String");
          input=Console.ReadLine();
         if(input.Length>=2)
         {
          first=input.Substring(0,1);
          second=input.Substring(1,1);
          new_String=second+first+input.Substring(2);
          Console.WriteLine("String after exchange of 1st and 2nd letter is {0}",new_String);
         }
       else
          Console.WriteLine("Invalid Length of a string");
    }
  }
}