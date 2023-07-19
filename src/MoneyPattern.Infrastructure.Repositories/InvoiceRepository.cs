using Dapper;
using MoneyPattern.Core.Domain;
using MoneyPattern.Core.Repositories.Contracts;
using MoneyPattern.Infrastructure.Repositories.Mappings;
using MoneyPattern.Infrastructure.Repositories.Queries;
using System.Data;

namespace MoneyPattern.Infrastructure.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly IDbConnection _connection;

        public InvoiceRepository(IDbConnection connection) => _connection = connection;


        public Task<Invoice> Get(int id)
        {
            SqlMapper.AddTypeHandler(new MoneyTypeHandler());
            return _connection.QueryFirstOrDefaultAsync<Invoice>(InvoiceRepositoryQueries.GET_BY_ID, new { id });
        }
    }
}
