    using System;
    namespace _08_11_2019_Assignment2
    {
        class Q54
        {
            public static void Run()
            {
            string input,new_Words,string_After_Deletion;char[] array;int index=0,count=0,start_Index_2ndWord=0,end_Index_2ndWord=0;
            Boolean second_Word=false;
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
                    if(second_Word==false)
                    start_Index_2ndWord=index;
                    second_Word=true;  
                    if(index+1==array.Length||array[index+1]==' ')
                    {
                        
                        end_Index_2ndWord=index;
                        break;
                    }
                  }
                }
                 else
                {
                        count++;
                }                
              }
              if(count!=0)
              {
                string_After_Deletion=input.Substring(0,start_Index_2ndWord)+input.Substring(end_Index_2ndWord+1);
                Console.WriteLine("string after deletion of first word {0}",string_After_Deletion); 
              }
              else
              Console.WriteLine("no second word in a string");
            }      
            else
            Console.WriteLine("invalid string"); 
        }
        }
    }