using System;
namespace _08_11_2019_Assignment2
{
  class Q37
  {
      public static void Run()
      {
          string input;
          Console.WriteLine("Enter the String");
          input=Console.ReadLine();
          if(!string.IsNullOrEmpty(input))
          {
              Find_X(input);
          }
          else
            Console.WriteLine("invalid string");
      }
      public static void Find_X(string input)
      {
          int index;string new_Words;
          char[] array=input.ToCharArray();
          for(index=0;index<array.Length;index++)
          {
               if(array[index]=='x'||array[index]=='X')
              {
                  new_Words=input.Substring(index+1);
                  Console.WriteLine("string after letter x is {0}",new_Words);
                  return;
              }
          }
          Console.WriteLine("Not found any letter x in given string");
      }
  }
}
