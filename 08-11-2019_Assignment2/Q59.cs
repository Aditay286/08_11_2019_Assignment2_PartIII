    using System;
    namespace _08_11_2019_Assignment2
    {
        class Q59
        {
            public static void Run()
            {
            string input,new_Words;char[] array;
            int index=0,count=0,start_Index_2ndWord=0,end_Index_2ndWord=0,end_Index_1stWord=0;
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
                  Find_1st_Letter(array,start_Index_2ndWord,end_Index_2ndWord);                  
              }
              else
              Console.WriteLine("no second word in a string");
            }      
            else
            Console.WriteLine("invalid string"); 
        }
        public static void Find_1st_Letter(char[] array,int start_Index_2ndWord,int end_Index_2ndWord)
        {
            char Letter_1st_Word=array[0];int index;
            for(index=start_Index_2ndWord;index<end_Index_2ndWord;index++)
            {
                if(Letter_1st_Word==array[index])
                {
                    Console.WriteLine("index is {0}",index);
                    return;
                }
            }
            Console.WriteLine("Not found 1st letter of 1st word in 2nd word of given string");
        }
     }
}