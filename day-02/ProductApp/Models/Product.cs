namespace ProductApp.Models
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