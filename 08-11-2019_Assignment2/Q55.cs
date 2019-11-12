    using System;
    namespace _08_11_2019_Assignment2
    {
        class Q55
        {
            public static void Run()
            {
            string input,new_Words,string_After_Exchange;char[] array;
            int index=0,count=0,start_Index_2ndWord=0,end_Index_2ndWord=0;
            int end_Index_1stWord=0;
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
                        if(count==0)
                         end_Index_1stWord=index-1;
                        count++;
                }                
              }
              if(count!=0)
              {
                string_After_Exchange=input.Substring(start_Index_2ndWord,end_Index_2ndWord-start_Index_2ndWord+1)+" "+input.Substring(0,end_Index_1stWord+1)+input.Substring(end_Index_2ndWord+1);
                Console.WriteLine("string after exchange of first and second word {0}",string_After_Exchange); 
              }
              else
              Console.WriteLine("no second word in a string");
            }      
            else
            Console.WriteLine("invalid string"); 
        }
     }
}