using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19_MAudesse
{
    class Invoice
    {
        public string PartNumber { get; set; }

        private int quantity;
        private decimal pricePerItem;

        public Invoice(string part, string description, int count, decimal price)
        {
            PartNumber = part;
            Partdescription = description;
            Quantity = count;
            pricePerItem = price;
        }

        public int Quantity{
            get
            {
                return quantity;
            }
            set
            {
                if(value >= 0)
                    quantity = value;
            }
        }

        public decimal PricePerItem{
            get
            {
                return pricePerItem;
            }
            set
            {
                if(value >= 0)
                    pricePerItem = value;
            }
        }

        public decimal GetInvoiceAmount(){
            return Quantity * PricePerItem;
        }
        }

    }

