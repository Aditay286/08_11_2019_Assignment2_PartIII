    using System;
    namespace _08_11_2019_Assignment2
    {
        class Q53
        {
            public static void Run()
            {
            string input,new_Words;char[] array;int index=0,count=0;
            Console.WriteLine("Enter the String");
            input=Console.ReadLine();
            if(!string.IsNullOrEmpty(input))
            {
                new_Words=input.Trim();
                array=new_Words.ToCharArray();
                for(index=0;index<array.Length;index++)
                {
                if(array[index]!=' ')
                {
                 if(count>0)
                  {
                    Console.Write("{0}",array[index]);
                    if(index+1==array.Length||array[index+1]==' ')
                    {
                        break;
                    }
                  }
                }
                 else
                {
                        count++;
                }            
              }
            }      
            else
            Console.WriteLine("invalid string"); 
        }
        }
    }