using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cond = true;



            // Logic Block

            int x = 0;

            do
            {
                Console.WriteLine(x * 2);
                Console.WriteLine(x + 6);
                Console.WriteLine(x + 7);
                Console.WriteLine(x + 9);
                Console.WriteLine(x + 10);
                x++;
                if (x > 8)
                {
                    cond = false;
                }
            } while (cond);

            cond = false;

            while (cond) ;

            Console.WriteLine("***************************************************");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine(x * 11);
            Console.WriteLine(x + 1);
            Console.WriteLine(x * 12);
            Console.WriteLine(x * 5);
            Console.WriteLine(x * 6);

            cond = true;

            while (cond)
            {
                Console.WriteLine(x / 8);
                Console.WriteLine(x / 8);
                Console.WriteLine(x / 9);
                Console.WriteLine(x / 10);
                Console.WriteLine(x / 7);

                x++;
                if (x > 8)
                {
                    cond = false;

                }
                cond = true;

                while (cond) ;
                {
                    Console.WriteLine(x - 1);
                    Console.WriteLine(x - 4);
                    Console.WriteLine(x - 5);
                    Console.WriteLine(x - 6);
                    Console.WriteLine(x - 8);

                }
            }
            Console.Read();
        }
    }
}

        
    

            
     

      
                    
            
            


   

            
            

        
         
        

        
            


        }
    }
}
