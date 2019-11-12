using System;
namespace _08_11_2019_Assignment2
{
  class Q45
  {
      public static void Run()
      {
          string input;
          Console.WriteLine("Enter the String");
          input=Console.ReadLine();
          if(!string.IsNullOrEmpty(input))
          {
              Find_Index_2ndpos(input);
          }
          else
            Console.WriteLine("invalid string");
      }
      public static void Find_Index_2ndpos(string input)
      {
          int index,second_Position,count=0;
          char[] array=input.ToCharArray();
          for(index=0;index<array.Length;index++)
          {
              if(array[index]==array[0])
              {
                  count++;
                  if(count==2)
                  {
                  second_Position=index;
                  Console.WriteLine("2nd position of {0} in given string is  {1}",array[0],second_Position);
                  return;
                  }
              }
          }
          Console.WriteLine("Not found any 2nd position of letter {0} in given string",array[0]);
      }
  }
}