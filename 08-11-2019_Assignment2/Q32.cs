using System;
using System.Text;
namespace _08_11_2019_Assignment2
{
  class Q32
  {
      public static void Run()
      {
          string input;
          Console.WriteLine("Enter the String");
          input=Console.ReadLine();
          StringBuilder stringBuilder=new StringBuilder(input);
          Console.WriteLine("Entered string is {0}",stringBuilder);
          if(stringBuilder.Length>2&&!String.IsNullOrEmpty(input)){
          stringBuilder.Remove(2,1);
          Console.WriteLine("String after removal of 2nd letter is {0}",stringBuilder);
          }
          else
          Console.WriteLine("Invalid Length of a string");




      }




  }




}