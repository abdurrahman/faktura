using System;
using Faktura.Domain.Constants;

namespace Faktura.Domain.Models
{
    public class GetInvoicesFilterRequestModel
    {
        public string[] Ids { get; set; }

        public int[] CreditorIds { get; set; }

        public int[] DebtorIds { get; set; }

        public InvoiceCloseCode[] CloseCodes { get; set; }

        public LegalEntityType[] DebtorTypes { get; set; }

        public InvoiceSearchMode? SearchModes { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public string Query { get; set; }

        public short? Take { get; set; }

        public short? Skip { get; set; }
    }
}