using CodeParadise.Money;
using Dapper;
using System.Data;

namespace MoneyPattern.Infrastructure.Repositories.Mappings
{
    internal class MoneyTypeHandler : SqlMapper.TypeHandler<Money>
    {
        public override Money Parse(object value)
        {
            decimal amount = Convert.ToDecimal(value);
            amount = decimal.Divide(amount, 100);

            return new Money(amount, Currency.USD);
        }

        public override void SetValue(IDbDataParameter parameter, Money value)
        {
            parameter.Value = value.Amount;
        }
    }
}
