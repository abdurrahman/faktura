using Newtonsoft.Json;

namespace Faktura.Domain.Models
{
    public class CreateInvoiceResponseModel
    {
        public InvoiceResourceObjectModel Data { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ErrorObjectModel[] Errors { get; set; }
    }
}