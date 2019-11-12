using System;
namespace _08_11_2019_Assignment2
{
    class Q52_B
    {
        public static void Run()
        {
           string input,new_Words;char[] array;int index=0;
          Console.WriteLine("Enter the String");
          input=Console.ReadLine();
          if(!string.IsNullOrEmpty(input))
          {
              new_Words=input.Trim();
              array=new_Words.ToCharArray();
              for(index=0;index<array.Length;index++)
              {
                  if(array[index]!=' ')
                  Console.Write("{0}",array[index]);
                  else
                   break;
              }
          }
          else
            Console.WriteLine("invalid string");
        }
      }
    }