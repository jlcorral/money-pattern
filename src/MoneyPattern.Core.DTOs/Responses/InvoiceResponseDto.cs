namespace MoneyPattern.Core.DTOs.Responses
{
    public class InvoiceResponseDto
    {
        public int Id { get; set; }
        public decimal Approval { get; set; }
        public decimal Leasing { get; set; }
        public decimal ProcessingFee { get; set; }
        public decimal Funded { get; set; }
    }
}