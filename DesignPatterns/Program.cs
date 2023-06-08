using DesignPatterns;
OrderFacade orderFacade = new OrderFacade();
orderFacade.PlaceOrder("1", 40, "test@mail.com");


public class OrderFacade : IPlaceOrderFacade
{
    private IProductCatalog productCatalog;
    private IPaymentSystem paymentSystem;
    private IInvoiceSystem invoiceSystem;

    public OrderFacade()
    {
        productCatalog = new ProductCatalog();
        paymentSystem = new PaymentSystem();
        invoiceSystem = new InvoiceSystem();
    }

    public void PlaceOrder(string productId, int quantity, string email)
    {
        var product = productCatalog.GetProductDetails(productId);
        if (product.Quantity < quantity)
        {
            Console.WriteLine($"Can only order {product.Quantity} items");
            return;
        }
        var payment = new Payment(1, true);
        var paymentResult = paymentSystem.MakePayment(payment);


        var invoice = new Invoice(1, "you payed $300");
        if (paymentResult)
        {
            invoiceSystem.SendInvoice(invoice);
        }
        else
        {
            Console.WriteLine("Payment was unsuccessful");
        }
    }
}