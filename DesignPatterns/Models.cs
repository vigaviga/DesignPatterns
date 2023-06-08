namespace DesignPatterns
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public int Quantity { get; set; }

        public Product(string id, string name)
        {
            Id = id;
            Name = name;
            Quantity = 50;
        }
    }

    public class Payment
    {
        public int Id { get; set; }
        public bool IsSuccessful { get; set; }
        public Payment(int id, bool isSuccessful)
        {
            Id = id;
            IsSuccessful = isSuccessful;
        }
    }

    public class Invoice
    {
        public int Id { get; set; }
        public string Message { get; set; }

        public Invoice(int id, string message)
        {
            Id = id;
            Message = message;
        }
    }
}
