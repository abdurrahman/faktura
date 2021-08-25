using System;

namespace Faktura.Domain.Models
{
    public class CreateInvoiceRequestModel
    {
        public DateTime Date { get; set; }

        public DateTime DueDate { get; set; }

        public InvoiceDebtorModel Debtor { get; set; }

        public string Currency { get; set; }

        public short CampaignInitialRequest { get; set; }

        public InvoiceLineModel[] Lines { get; set; }

        public DateTime DebtCollectionWarningDate { get; set; }

        public DateTime DebtRegisterWarningDate { get; set; }
    }
}