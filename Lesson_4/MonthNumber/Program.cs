namespace MonthNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter month from 1 to 12: ");
            int month=int.Parse(Console.ReadLine());
            switch(month){ 
                    case 1:
                     case 2:   
                 Console.WriteLine("winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("autumn");
                    break;
                case 12:
                        Console.WriteLine("winter");
                    break;
                          }
            
            
            
        }
    }
}     
                    
                   
                   
                   
                   
                    
                
