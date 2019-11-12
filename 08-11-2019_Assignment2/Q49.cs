using System;
namespace _08_11_2019_Assignment2
{
  class Q49
  {
      public static void Run()
      {
          string input;
          Console.WriteLine("Enter the String");
          input=Console.ReadLine();
          if(!string.IsNullOrEmpty(input))
          {
              Print_String_OfOthLetter(input);
          }
          else
            Console.WriteLine("invalid string");
      }
      public static void Print_String_OfOthLetter(string input)
      {
          char[] array;int[] positions_Array;char right_Neighbour;string newWords;
          int index=0,index_Of_Right_Neighbour_1st,index_Of_Left_Neighbour_1st=0;Boolean check=false;
          array=input.ToCharArray();
          positions_Array=new int[2];
          if(Find_Second_Occurance(array,positions_Array))
          {
              if(positions_Array[1]+1<array.Length)
              {
                  right_Neighbour=array[positions_Array[1]+1];
                  index_Of_Right_Neighbour_1st=input.IndexOf(right_Neighbour);
                  for(index=index_Of_Right_Neighbour_1st+1;index<array.Length;index++)
                  {
                      if(array[index]==array[positions_Array[1]-1])
                      {
                          index_Of_Left_Neighbour_1st=index;
                          check=true;
                          break;
                      }
                  }
                  if(check){
                  newWords=input.Substring(index_Of_Right_Neighbour_1st,index_Of_Left_Neighbour_1st-index_Of_Right_Neighbour_1st+1);
                  Console.WriteLine("string between 1st occurance of neighbours of 2nd occurance of 0th letter is {0}",newWords);
              }
              else
              Console.WriteLine("There is not occurance of left neighbour after 1st occurance of right neighbour");
            }
              else
              Console.WriteLine("Right neighbour of 2nd occurance of 0th letter does not exist");
          }
          else
          Console.WriteLine("given condition is not satisfied by given string");           
      }
      public static Boolean Find_Second_Occurance(char[] array,int[] positions_Array)
      {
          int index=0,count=0;
          for(index=0;index<array.Length;index++)
          {
              if(array[index]==array[0])
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
