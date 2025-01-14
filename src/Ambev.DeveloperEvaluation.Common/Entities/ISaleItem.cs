namespace Ambev.DeveloperEvaluation.Common.Entities
{
    public interface ISaleItem
    {
        public string Id { get; }
        public string SaleId { get; }
        public string ProductId { get; }
        public decimal Quantity { get; }
        public decimal UnitPrice { get; }
        public decimal Discount { get; }
        public decimal Total { get; }

    }
}
