using MoneyPattern.Core.DTOs.Responses;
using System.Threading.Tasks;

namespace MoneyPattern.Core.Services.Contracts
{
    public interface IInvoiceService
    {
        Task<InvoiceResponseDto> Get(int id);
    }
}
