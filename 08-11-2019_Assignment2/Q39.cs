using System;
namespace _08_11_2019_Assignment2
{
  class Q39
  {
      public static void Run()
      {
          string input;
          Console.WriteLine("Enter the String");
          input=Console.ReadLine();
          if(!string.IsNullOrEmpty(input))
          {
              Find_2nd_X(input);
          }
          else
            Console.WriteLine("invalid string");
      }
      public static void Find_2nd_X(string input)
      {
          int index,second_Position,count=0;
          char[] array=input.ToCharArray();
          for(index=0;index<array.Length;index++)
          {
              if(array[index]=='x'||array[index]=='X')
              {
                  count++;
                  if(count==2){
                  second_Position=index;
                  Console.WriteLine("2nd position of x in given string is  {0}",index);
                  return;
                  }
              }
          }
          Console.WriteLine("Not found any 2nd letter x in given string");
      }
  }
}