using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal product1 = 0M;
            decimal product2 = 0M;
            decimal product3 = 0M;
            int productId = 1;
            int quantity = 0;
            

            while (productId != 0)
            {
                Console.WriteLine("Enter product number [1-3](0 to stop):");
                productId = Convert.ToInt32(Console.ReadLine());

                if (productId == 0)
                {
                    break;

                }
                
                Console.WriteLine("Enter quantity sold:");
                quantity = Convert.ToInt32(Console.ReadLine());

                switch (productId)
                {
                    case 1: product1 += Convert.ToDecimal(quantity * 2.98);
                        break;
                    case 2: product2 += Convert.ToDecimal(quantity * 4.50);
                        break;
                    case 3: product3 += Convert.ToDecimal(quantity * 9.98);
                        break;
                    default:
                        break;
                       
    

                }


            }

            Console.WriteLine("Product 1: {0}", product1);
            Console.WriteLine("Proudct 2: {0}", product2);
            Console.WriteLine("Product 3: {0}", product3);
        }
    }
}
