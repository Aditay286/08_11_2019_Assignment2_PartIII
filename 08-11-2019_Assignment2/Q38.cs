using System;
namespace _08_11_2019_Assignment2
{
  class Q38
  {
      public static void Run()
      {
          string input;
          Console.WriteLine("Enter the String");
          input=Console.ReadLine();
          if(!string.IsNullOrEmpty(input))
          {
              Replace_X(input);
          }
          else
            Console.WriteLine("invalid string");
      }
      public static void Replace_X(string input)
      {
          int index;string new_Words;
          char[] array=input.ToCharArray();
          for(index=0;index<array.Length;index++)
          {
            if(array[index]=='x'||array[index]=='X')
              {
                  new_Words=input.Substring(0,index)+"y"+input.Substring(index+1);
                  Console.WriteLine("string after replacing letter x with y is {0}",new_Words);
                  return;
              }
          }
          Console.WriteLine("Not found any letter x in given string");
      }
  }
}
