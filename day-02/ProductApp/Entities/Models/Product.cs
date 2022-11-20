using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Product
    {
        public Int16 Id { get; set; }
        public String ProductName { get; set; }
        public decimal Price { get; set; }

        public Product()
        {

        }

        public Product(short id, string productName, decimal price)
        {
            Id = id;
            ProductName = productName;
            Price = price;
        }
    }
}
