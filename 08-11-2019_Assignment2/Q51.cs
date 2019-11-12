using System;
namespace _08_11_2019_Assignment2
{
    class Q51
    {
        public static void Run()
        {
            string input1,input2;
            Console.WriteLine("Enter the first string");
            input1=Console.ReadLine();
            Console.WriteLine("Enter the second string");
            input2=Console.ReadLine();
               if(!string.IsNullOrEmpty(input1)&&!string.IsNullOrEmpty(input2))
          {

              if(Compare(input1,input2)>0)
              {
                  Console.WriteLine("{0}",1);      
              }
              else if(Compare(input1,input2)<0)
              {
                        Console.WriteLine("{0}",2);       
              }
              else
                    Console.WriteLine("{0}",0);
          }
          else
            Console.WriteLine("invalid string");
        }
        public static int Compare(string input1,string input2)
        {
            char[] array1,array2;int index=0;
            array1=input1.ToCharArray();
            array2=input2.ToCharArray();

             for(index=0;index<array1.Length&&index<array2.Length;index++)
             {
                 if((int)array1[index]>(int)array2[index])
                 {
                     return (int)(array1[index]-array2[index]);
                 }
                       if((int)array1[index]<(int)array2[index])
                 {
                     return (int)(array1[index]-array2[index]);
                 }
             }
                   if(array1.Length>array2.Length)
                 {
                     return array1.Length-array2.Length;
                 }
                           if(array1.Length<array2.Length)
                 {
                     return array1.Length-array2.Length;
                 }
        return 0;
    }
 }
}