using System;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            int x = int.Parse(Console.ReadLine());
            for (int i = 0;i>=0 ; i++)
            {
                int y = int.Parse(Console.ReadLine());
                string end = Console.ReadLine();

                if (end == "end")
                {
                    End();
                }
               
                    
            }

        }
        static void End()
        {
           
            String maxminmeean = Console.ReadLine();
            if (maxminmeean == "FindMax")
            {
                Console.WriteLine("Max is :");



            }
            else if (maxminmeean == "FindMin")
            {
                Console.WriteLine("Min is :");
            }
            else if (maxminmeean == "FindMean")
            {
                Console.WriteLine("Mean is :");
                
            }
            else
            {
                Console.WriteLine("invalid mode");
            }
        }

    }
}
