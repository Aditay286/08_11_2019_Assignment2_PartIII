using System;
namespace _08_11_2019_Assignment2
{
  class Q36
  {
      public static void Run()
      {
          string input,output;int occurance;char[] array;
          Console.WriteLine("Enter the String");
          input=Console.ReadLine();
          if(!string.IsNullOrEmpty(input))
          {
              array=input.ToCharArray();
        occurance=Count_Character(array);
        if(occurance!=-1){
            output=input.Replace(array[occurance],'@');
            Console.WriteLine("required string is {0}",output);
          }
          else
          Console.WriteLine("no letter has occurance > 1");
        }
          else
          {
              Console.WriteLine("invalid string");
          }
      }
      static int Count_Character(char[] ch)
      {
          int index1=0,index2;int count=0,position=0;
           for(index1=0;index1<ch.Length;index1++)
           {
               count=0;
               for(index2=0;index2<ch.Length;index2++)
               {
                   if(ch[index1]==ch[index2])
                   {
                       count++;
                     position=index2;
                       if(count>1)
                       {
                           
                          return position;
                       }
                   }
               }
           }
           return -1;
           }
      }
  }