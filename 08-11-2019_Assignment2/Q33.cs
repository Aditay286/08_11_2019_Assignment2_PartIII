using System;
using System.Text;
namespace _08_11_2019_Assignment2
{
  class Q33
  {
      public static void Run()
      {
          string input;
          Console.WriteLine("Enter the String");
          input=Console.ReadLine();
          if(!String.IsNullOrEmpty(input)&&input.Length>=1)
          {
          input=input.Substring(0,1)+input;
          Console.WriteLine("String after addition of 1st letter is {0}",input);
          }
        else
         Console.WriteLine("Invalid Length of a string");
      }
  }
}