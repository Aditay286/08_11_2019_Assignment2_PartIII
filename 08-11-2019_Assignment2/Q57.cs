    using System;
    namespace _08_11_2019_Assignment2
    {
        class Q57
        {
            public static void Run()
            {
            string input,new_Words;char[] array;char temp;
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
                  temp=array[end_Index_1stWord];
                  array[end_Index_1stWord]=array[end_Index_2ndWord];
                  array[end_Index_2ndWord]=temp;
                  Console.Write("String after exchange of last letters of 1st and 2nd word is ");
                  Print_String(array);
              }
              else
              Console.WriteLine("no second word in a string");
            }      
            else
            Console.WriteLine("invalid string"); 
        }
        public static void Print_String(char[] array)
        {
            int index=0;
            for(index=0;index<array.Length;index++)
            {
                Console.Write("{0}",array[index]);
            }
        }
     }
}