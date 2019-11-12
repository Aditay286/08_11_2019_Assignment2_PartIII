using System;
namespace _08_11_2019_Assignment2
{
  class Q44
  {
      public static void Run()
      {
          string input;
          Console.WriteLine("Enter the String");
          input=Console.ReadLine();
          if(!string.IsNullOrEmpty(input))
          {
              Exchange_Neighbours_Of_X(input);
          }
          else
            Console.WriteLine("invalid string");
      }
      public static void Exchange_Neighbours_Of_X(string input)
      {
          int index,first_Position=0;string new_Words, first_Neighbour="",second_Neighbour="",first_part="",second_Part="";
          char[] array=input.ToCharArray();
          for(index=0;index<array.Length;index++)
          {
              if(array[index]=='x'||array[index]=='X')
              {
                  first_Position=index;
                  if(first_Position-1>=0)
                  {
                   first_Neighbour+=array[first_Position-1];
                     if(first_Position-1>0)
                   {
                      first_part+=input.Substring(0,first_Position-1);
                   }
                  }
                   if(first_Position+1<array.Length)
                   {
                      second_Neighbour+=array[first_Position+1];
                      if(first_Position+1!=array.Length-1)
                      {
                          second_Part=input.Substring(first_Position+2);
                      }
                   }
                  new_Words=first_part+second_Neighbour+array[first_Position]+first_Neighbour+second_Part;
                  Console.WriteLine("fp={0} f={1} sp={2} sn={3} ",first_part,first_Neighbour,second_Part,second_Neighbour);
                  Console.WriteLine("string after exchanging neighbours of x is {0}",new_Words);
                  return;
              }
          }
          Console.WriteLine("cannot find x in given string");
      }
  }
}