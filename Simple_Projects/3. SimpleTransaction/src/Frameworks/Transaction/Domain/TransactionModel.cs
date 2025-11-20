namespace Transaction.Framework.Domain
{
    public class TransactionModel
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public string TransactionType { get; set; } = string.Empty;
    }
}
