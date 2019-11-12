using System;
namespace _08_11_2019_Assignment2
{
  class Q41
  {
      public static void Run()
      {
          string input;
          Console.WriteLine("Enter the String");
          input=Console.ReadLine();
          if(!string.IsNullOrEmpty(input))
          {
              Words_Before_2nd_X(input);
          }
          else
            Console.WriteLine("invalid string");
      }
      public static void Words_Before_2nd_X(string input)
      {
          int index,second_Position,count=0;string new_Words;
          char[] array=input.ToCharArray();
          for(index=0;index<array.Length;index++)
          {
               if(array[index]=='x'||array[index]=='X')
              {
                  if(count==1)
                  {
                  second_Position=index;
                  new_Words=input.Substring(0,second_Position);
                  Console.WriteLine("words before 2nd x in a string is {0}",new_Words);
                  return;
                  }
                   count++;
              }
          }
          Console.WriteLine("cannot print words before 2nd x of given string");
      }
  }
}