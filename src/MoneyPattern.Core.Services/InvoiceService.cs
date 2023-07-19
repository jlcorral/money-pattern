using MoneyPattern.Core.Domain;
using MoneyPattern.Core.DTOs.Responses;
using MoneyPattern.Core.Repositories.Contracts;
using MoneyPattern.Core.Services.Contracts;

namespace MoneyPattern.Core.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository) => _invoiceRepository = invoiceRepository;


        public async Task<InvoiceResponseDto> Get(int id)
        {
            Invoice invoice = await _invoiceRepository.Get(id);

            return new InvoiceResponseDto
            {
                Id = invoice.Id,
                Approval = invoice.Approval.Amount,
                Leasing = invoice.Leasing.Amount,
                ProcessingFee = invoice.ProcessingFee.Amount,
                Funded = invoice.Funded.Amount,
            };
        }
    }
}
