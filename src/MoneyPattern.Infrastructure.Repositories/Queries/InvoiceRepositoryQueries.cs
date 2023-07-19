namespace MoneyPattern.Infrastructure.Repositories.Queries
{
    internal static class InvoiceRepositoryQueries
    {
        internal const string GET_BY_ID = @"SELECT TOP (1) [Id]
                    ,[Approval]
                    ,[Leasing]
                    ,[ProcessingFee]
                FROM [InvoiceDemo].[dbo].[Invoice]
                WHERE [Id] = @id";
    }
}
