namespace Faktura.Domain.Models
{
    public class InvoiceResourceObjectModel
    {
        public string Type { get; set; }

        public InvoiceAttributesModel Attributes { get; set; }

        public string Id { get; set; }
    }
}