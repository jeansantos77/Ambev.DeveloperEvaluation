using Ambev.DeveloperEvaluation.Common.Entities;
using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class SaleItem: BaseEntity, ISaleItem
    {
        public required string SaleId { get; set; }
        public required Sale Sale { get; set; }

        public required string ProductId { get; set; }
        public required Product Product { get; set; }

        public required decimal Quantity { get; set; } = 1;

        public required decimal UnitPrice { get; set; } = 0;

        public required decimal Discount { get; set; } = 0;

        public decimal Total => Quantity * UnitPrice * (1 - Discount / 100);

        string ISaleItem.Id => Id.ToString();
    }
}
