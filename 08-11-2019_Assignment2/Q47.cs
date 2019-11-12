using System;
namespace _08_11_2019_Assignment2
{
  class Q47
  {
      public static void Run()
      {
          string input;
          Console.WriteLine("Enter the String");
          input=Console.ReadLine();
          if(!string.IsNullOrEmpty(input))
          {
              Replace_C(input);
          }
          else
            Console.WriteLine("invalid string");
      }
      public static void Replace_C(string input)
      {
          char[] array;int found;string new_Words;
          array=input.ToCharArray();
          new_Words=input.Replace("c","x");
          found=input.IndexOf("c");
          if(found!=-1)
          Console.WriteLine("Replaced c with x new string is {0}",new_Words);
          else
          Console.WriteLine("Cannot find c in given string");
          }
     }
  }