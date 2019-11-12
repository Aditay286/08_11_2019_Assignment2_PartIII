using System;
namespace _08_11_2019_Assignment2
{
  class Q46
  {
      public static void Run()
      {
          string input;
          Console.WriteLine("Enter the String");
          input=Console.ReadLine();
          if(!string.IsNullOrEmpty(input))
          {
              Delete_Y(input);
          }
          else
            Console.WriteLine("invalid string");
      }
      public static void Delete_Y(string input)
      {
          int index,count=0;Boolean find_X=false;string new_Word;
          char[] array=input.ToCharArray();
          for(index=0;index<array.Length;index++)
          {
              if(array[index]=='x'||array[index]=='X')
              {
                  count++;
                  find_X=true;
                  if(count>1)
                   find_X=false;
              }
                if(find_X&&array[index]=='y'||array[index]=='Y')
                {
                    new_Word=input.Remove(index,1);
                  Console.WriteLine("String after removal of  Y in given string is  {0}",new_Word);
                  return;
                }
          }
         
          Console.WriteLine("string is not in correct format for operation");
      }
  }
}