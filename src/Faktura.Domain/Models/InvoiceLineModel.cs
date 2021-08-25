using System.ComponentModel.DataAnnotations;
using Faktura.Domain.Constants;

namespace Faktura.Domain.Models
{
    public class InvoiceLineModel
    {
        [Required(ErrorMessage = "Unit net price field is required")]
        public double UnitNetPrice { get; set; }

        [Required(ErrorMessage = "Description field is required")]
        public string Description { get; set; }

        public double Quantity { get; set; }

        public double VatRate { get; set; }

        public DiscountType DiscountType { get; set; }

        public double DiscountValue { get; set; }
    }
}