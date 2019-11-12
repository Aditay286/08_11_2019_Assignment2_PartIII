using System;

namespace _08_11_2019_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
     string input;int no,choice;
    do{
        Console.WriteLine("_08_11_2019_Assignment2 part-III");
        Console.WriteLine("Enter the Question no you want to run or for all at once enter 0");
        input=Console.ReadLine();    
        if(Int32.TryParse(input,out no))
        {
        switch(no)
        {
            case 0:
            Console.WriteLine("Question-32");
            Q32.Run();
            Console.WriteLine("Question-33");       
            Q33.Run();
                   Console.WriteLine("Question-34");
            Q34.Run();
                   Console.WriteLine("Question-35");
            Q35.Run();
                   Console.WriteLine("Question-36");
            Q36.Run();
                   Console.WriteLine("Question-37");
            Q37.Run();
                   Console.WriteLine("Question-38");
            Q38.Run();
                   Console.WriteLine("Question-39");
            Q39.Run();
                   Console.WriteLine("Question-40");
            Q40.Run();
                   Console.WriteLine("Question-41");
            Q41.Run();
                   Console.WriteLine("Question-42");
            Q42.Run();
                   Console.WriteLine("Question-43");
            Q43.Run();
                   Console.WriteLine("Question-44");
            Q44.Run();
                   Console.WriteLine("Question-45");
            Q45.Run();
                   Console.WriteLine("Question-46");
            Q46.Run();
                   Console.WriteLine("Question-47");
            Q47.Run();
                   Console.WriteLine("Question-48");
            Q48.Run();
                   Console.WriteLine("Question-49");
            Q49.Run();
                       Console.WriteLine("Question-49_B");
            Q49_B.Run();
            
                   Console.WriteLine("Question-50");
            Q50.Run();
                   Console.WriteLine("Question-51");
            Q51.Run();
                   Console.WriteLine("Question-52");
            Q52.Run();
                 Console.WriteLine("Question-52_B");
            Q52_B.Run();
                   Console.WriteLine("Question-53");
            Q53.Run();
                   Console.WriteLine("Question-54");
            Q54.Run();
                   Console.WriteLine("Question-55");
            Q55.Run();
                   Console.WriteLine("Question-56");
            Q56.Run();
                   Console.WriteLine("Question-57");
            Q57.Run();
                   Console.WriteLine("Question-59");
            Q59.Run();
                   Console.WriteLine("Question-60");
            Q60.Run();
            break;
        case 32:
            Console.WriteLine("Question-32");
            Q32.Run();
            break;
        case 33:
              Console.WriteLine("Question-33");       
            Q33.Run();
          break;
        case 34:
               Console.WriteLine("Question-34");       
            Q34.Run();
         break;
        case 35:
               Console.WriteLine("Question-35");       
            Q35.Run();
            break;
        case 36:
          Console.WriteLine("Question-36");       
            Q36.Run();
              break;
        case 37:
         Console.WriteLine("Question-37");       
            Q37.Run();
            break;
        case 38:
               Console.WriteLine("Question-38");       
            Q38.Run();
         break;
        case 39:
               Console.WriteLine("Question-39");       
            Q39.Run();
            break;     
        case 40:
             Console.WriteLine("Question-40");       
            Q40.Run();
            break;
        case 41:
          Console.WriteLine("Question-41");       
            Q41.Run();
              break;
        case 42:
             Console.WriteLine("Question-42");       
            Q42.Run();
            break;
        case 43:
             Console.WriteLine("Question-43");       
            Q43.Run();
            break;
        case 44:
             Console.WriteLine("Question-44");       
            Q44.Run();
            break;
         case 45:
             Console.WriteLine("Question-45");       
            Q45.Run();
            break; 
        case 46:
          Console.WriteLine("Question-46");       
            Q46.Run();
              break;
        case 47:
         Console.WriteLine("Question-47");       
            Q47.Run();
            break;
        case 48:
         Console.WriteLine("Question-48");       
           Q48.Run();
         break;
        case 49:
         Console.WriteLine("Question-49");       
            Q49.Run();
         Console.WriteLine("Question-49_B"); 
         Q49_B.Run();      
         break; 
        case 50:
             Console.WriteLine("Question-50");       
            Q50.Run();
            break;
        case 51:
          Console.WriteLine("Question-51");       
            Q51.Run();
              break;
        case 52:
             Console.WriteLine("Question-52");       
            Q52.Run();
       Console.WriteLine("Question-52_B");       
            Q52_B.Run();
            break;
        case 53:
             Console.WriteLine("Question-53");       
            Q53.Run();
            break;
        case 54:
             Console.WriteLine("Question-54");       
            Q54.Run();
            break;
        case 55:
            Console.WriteLine("Question-55");       
            Q55.Run();
            break;
        case 56:
          Console.WriteLine("Question-56");       
            Q56.Run();
              break;
        case 57:
         Console.WriteLine("Question-57");       
            Q57.Run();
            break;
        case 59:
          Console.WriteLine("Question-59");       
            Q59.Run();
            break;     
        case 60:
         Console.WriteLine("Question-60");       
            Q60.Run();
            break;    
        default:
            Console.WriteLine("Question no {0} does not exist",no);
        break;
        }
      }
           else
        {
            Console.WriteLine("Not an Integer Value");
        }
       Console.WriteLine("Do you want to run another program 1.yes 2.no");
        string input2=Console.ReadLine(); 
       while(!(Int32.TryParse(input2,out choice)))
       {
        Console.WriteLine("Renter the choice");   
         input2=Console.ReadLine();                
       }
      }while(choice==1);
     }    
    }
}
