namespace Faktura.Domain.Constants
{
    public class AppConstants
    {
        // Get a single invoice record by invoice ID.
        public const string LikvidoGetInvoiceByIdEndpoint = "/Invoices/{0}";
        // Get a listing of invoice records by specification.
        public const string LikvidoGetInvoiceListEndpoint = "/Invoices";
        // Create a new invoice record.
        public const string LikvidoCreateInvoiceEndpoint = "/Invoices";
    }
}