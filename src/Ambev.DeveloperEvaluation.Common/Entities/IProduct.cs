namespace Ambev.DeveloperEvaluation.Common.Entities
{
    public interface IProduct
    {
        public string Id { get; }

        public string ProductName { get; }
        public decimal UnitPrice { get; set; }

    }
}
