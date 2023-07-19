using Microsoft.AspNetCore.Mvc;
using MoneyPattern.Core.DTOs.Responses;
using MoneyPattern.Core.Services.Contracts;
using System.Net.Mime;

namespace MoneyPattern.Clients.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;
        public InvoicesController(IInvoiceService invoiceService) => _invoiceService = invoiceService;


        [HttpGet("{id:int}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(InvoiceResponseDto))]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                InvoiceResponseDto response = await _invoiceService.Get(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
