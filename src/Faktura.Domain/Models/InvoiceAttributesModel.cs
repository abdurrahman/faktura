using System;
using Faktura.Domain.Constants;

namespace Faktura.Domain.Models
{
    public class InvoiceAttributesModel
    {
        /// <summary>
        /// The timestamp of when the invoice was created
        /// </summary>
        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        public string ReferenceId { get; set; }

        public string CreditorReference { get; set; }

        public DateTime InvoiceExpirationDate { get; set; }

        public bool InvoiceFoundation { get; set; }

        public string Currency { get; set; }

        public double NetAmount { get; set; }

        public double GrossAmount { get; set; }

        public double Remainder { get; set; }

        public double VatAmount { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime Date { get; set; }

        public InvoiceCloseCode CloseCode { get; set; }

        public InvoiceState InvoiceStateOnClose { get; set; }

        public InvoiceState InvoiceState { get; set; }

        public string InvoiceComments { get; set; }

        public string InternalComments { get; set; }

        public CampaignType CurrentProduct { get; set; }
    }
}