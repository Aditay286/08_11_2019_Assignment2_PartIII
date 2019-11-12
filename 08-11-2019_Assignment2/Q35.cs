using System;
namespace _08_11_2019_Assignment2
{
  class Q35
  {
      public static void Run()
      {
          string input,new_String,fourth,tenth;
          Console.WriteLine("Enter the String");
          input=Console.ReadLine();
          if(input.Length>=11){
          fourth=input.Substring(4,1);
          tenth=input.Substring(10,1);
          new_String=input.Substring(0,4)+tenth+input.Substring(5,5)+fourth+input.Substring(11);
          Console.WriteLine("String after exchange of 4th and tenth no letter is {0}",new_String);
      }
      else
        Console.WriteLine("Invalid Length of a string");

      }
  }
}