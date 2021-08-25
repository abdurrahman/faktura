using System;
using System.Threading.Tasks;
using Faktura.Domain.Models;

namespace Faktura.Domain.Services
{
    public interface IInvoiceService
    {
        /// <summary>
        /// Create a new invoice record.
        /// </summary>
        /// <param name="model">CreateInvoiceRequestModel</param>
        /// <returns>CreateInvoiceResponseModel</returns>
        Task<CreateInvoiceResponseModel> CreateInvoice(CreateInvoiceRequestModel model);

        /// <summary>
        /// Get a listing of invoice records by specification.
        /// </summary>
        /// <returns>IList&lt;GetInvoicesResponseModel&gt;</returns>
        Task<GetInvoicesResponseModel> GetInvoices(GetInvoicesFilterRequestModel model);
        
        /// <summary>
        /// Get a single invoice record by invoice id. 
        /// </summary>
        /// <param name="id">Invoice identifier</param>
        /// <returns>GetInvoiceByIdResponseModel</returns>
        Task<GetInvoiceByIdResponseModel> GetInvoiceById(string id);
    }
}