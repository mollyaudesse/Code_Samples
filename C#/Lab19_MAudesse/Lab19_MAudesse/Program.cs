using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19_MAudesse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Orginal invoice information");
            Invoice lab19 = new Invoice("1234", "Hammer", 2, 14.95M);

            lab19.GetInvoiceAmount();
            Console.WriteLine();

            Console.WriteLine("Update invoice information");
            lab19.PartNumber = "001234";
            lab19.description = "Yellow Hammer";
            lab19.Quantity = 3;
            lab19.PricePerItem = 19.49;

            lab19.GetInvoiceAmount();
            Console.WriteLine();

            Console.WriteLine("Orignal invoice information");
            Invoice lab019 = new Invoice("5678", "PaintBrush", 0, 0.00M);
            lab019.GetInvoiceAmount();
            Console.WriteLine();

            Console.WriteLine("Update Invoice information");
            lab019.Quantity = 3;
            lab019.PricePerItem = 9.49M;
            lab019.GetInvoiceAmount();
        }
    }
}
