using System;
namespace _08_11_2019_Assignment2
{
  class Q60
  {
      public static void Run()
      {
          double number;string input;

          Console.WriteLine("Enter the number");
          input=Console.ReadLine();
          if(input!=" "&&Double.TryParse(input,out number))
          {
              Console.WriteLine("Square of a no {0} is {1}",number,Square(number).ToString());
          } 
          else
          Console.WriteLine("Not a number");
      }
      public static double Square(double number)
      {
          return number*number;
      }
  }
}