using Faktura.Domain.Constants;

namespace Faktura.Domain.Models
{
    public class InvoiceDebtorModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string AccountingDebtorId { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public LegalEntityType DebtorType { get; set; }

        public string Address { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }
    }
}