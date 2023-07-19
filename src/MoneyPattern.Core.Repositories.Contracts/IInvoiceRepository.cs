using MoneyPattern.Core.Domain;
using System.Threading.Tasks;
namespace MoneyPattern.Core.Repositories.Contracts
{
    public interface IInvoiceRepository
    {
        Task<Invoice> Get(int id);
    }
}
