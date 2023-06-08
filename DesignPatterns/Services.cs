
namespace DesignPatterns
{
    public class ProductCatalog : IProductCatalog
    {
        public Product GetProductDetails(string productId)
        {
            Console.WriteLine("Item exists in the stock.");
            return new Product(productId, "testName");
        }
    }

    public class PaymentSystem : IPaymentSystem
    {
        public bool MakePayment(Payment payment)
        {
            Console.WriteLine("Payment was successful.");
            return true;
        }
    }

    public class InvoiceSystem : IInvoiceSystem
    {
        public void SendInvoice(Invoice invoice)
        {
            Console.WriteLine("Invoice was sent to email.");
        }
    }
}
