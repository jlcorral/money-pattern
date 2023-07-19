using CodeParadise.Money;

namespace MoneyPattern.Core.Domain
{
    public class Invoice
    {
        public int Id { get; set; }
        public Money Approval { get; set; }
        public Money Leasing { get; set; }
        public Money ProcessingFee { get; set; }
        public Money Funded { get => Leasing - ProcessingFee; }
    }
}