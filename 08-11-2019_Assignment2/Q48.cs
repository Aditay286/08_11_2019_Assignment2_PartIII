using System;
namespace _08_11_2019_Assignment2
{
  class Q48
  {
      public static void Run()
      {
          string input;
          Console.WriteLine("Enter the String");
          input=Console.ReadLine();
          if(!string.IsNullOrEmpty(input))
          {
              Replace_X_Neighbours(input);
          }
          else
            Console.WriteLine("invalid string");
      }
      public static void Replace_X_Neighbours(string input)
      {
          char[] array;int[] positions_Array;char Neighbour_2nd_X;string new_Words;
          int index=0;Boolean occurance=false;
          array=input.ToCharArray();
          positions_Array=new int[2];
          if(Find_X(array,positions_Array))
          {
              if(input.IndexOf("x")!=0)
              {
                  if(positions_Array[1]==array.Length-1)
                  {
                      new_Words=input+""+array[positions_Array[0]-1];
                      Console.WriteLine("after operation on string,new string is {0}",new_Words);
                  }
                  else
                  {       
                  Neighbour_2nd_X=array[positions_Array[1]+1];
                  for(index=0;index<=positions_Array[1];index++)
                  {
                      if(array[index]==Neighbour_2nd_X)
                      {
                          occurance=true;
                          break;
                      }
                  }
                  if(!occurance)
                  {
                      array[positions_Array[1]+1]=array[positions_Array[0]-1];
                          Console.WriteLine("after operation on string,new string is:-");
                      for(index=0;index<array.Length;index++)
                      Console.Write("{0}",array[index]);
                  
                  }
                  else
                   Console.WriteLine("no operation done, required output is {0}",input);
                }
              }
              else
              Console.WriteLine("Does not exist left neighbour of 1st x");
          }
          else
          Console.WriteLine("Does not found x in given string");
      }
      public static Boolean Find_X(char[] array,int[] positions_Array)
      {
          int index=0,count=0;
          for(index=0;index<array.Length;index++)
          {
              if(array[index]=='x')
              {
               positions_Array[count]=index;   
              count++;
              if(count==2)
               return true;
              }
          }
          return false;
      }

   }
}
