using System;
namespace _08_11_2019_Assignment2
{
  class Q42
  {
      public static void Run()
      {
          string input;
          Console.WriteLine("Enter the String");
          input=Console.ReadLine();
          if(!string.IsNullOrEmpty(input))
          {
              Delete_Words_Betwn_X(input);
          }
          else
            Console.WriteLine("invalid string");
      }
      public static void Delete_Words_Betwn_X(string input)
      {
          int index,first_Position=0,second_Position,count=0;string new_Words;
          char[] array=input.ToCharArray();
          for(index=0;index<array.Length;index++)
          {
               if(array[index]=='x'||array[index]=='X')
              {
                  if(count==0)
                    first_Position=index;
                 else if(count==1)
                  {
                  second_Position=index;
                  new_Words=input.Substring(0,first_Position+1)+input.Substring(second_Position);
                  Console.WriteLine("string after  deleted words between 1st and 2nd x is {0}",new_Words);
                  return;
                  }
                   count++;
              }
          }
          Console.WriteLine("cannot find 2x's in given string");
      }
  }
}