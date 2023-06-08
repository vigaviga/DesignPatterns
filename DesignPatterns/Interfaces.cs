namespace DesignPatterns
{
    interface IProductCatalog
    {
        Product GetProductDetails(string productId);
    }

    interface IPaymentSystem
    {
        bool MakePayment(Payment payment);
    }

    interface IInvoiceSystem
    {
        void SendInvoice(Invoice invoice);
    }

    interface IPlaceOrderFacade
    {
        void PlaceOrder(string productId, int quantity, string email);
    }
}
