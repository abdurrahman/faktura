using System;
using System.Threading.Tasks;
using Faktura.Domain.Models;
using Faktura.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Faktura.WepApi.Controllers
{
    public class InvoicesController : BaseController
    {
        private readonly IInvoiceService _invoiceService;
        
        public InvoicesController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }
        
        // GET api/Invoices
        [HttpGet]
        public async Task<IActionResult> GetInvoices([FromQuery] GetInvoicesFilterRequestModel model)
        {
            var result = await _invoiceService.GetInvoices(model);
            
            return Ok(result);
        }

        // GET api/Invoices/1
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetInvoice([FromRoute] Guid id)
        {
            var result = await _invoiceService.GetInvoiceById(id.ToString());
            return Ok(result);
        }
        
        // POST api/Invoices
        [HttpPost]
        public async Task<IActionResult> AddInvoice([FromBody] CreateInvoiceRequestModel model)
        {
            var result = await _invoiceService.CreateInvoice(model);
            return Ok(result);
        }
    }
}