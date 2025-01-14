using Ambev.DeveloperEvaluation.Common.Entities;
using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Product : BaseEntity, IProduct
    {
        public string ProductName { get; set; } = string.Empty;

        public decimal UnitPrice { get; set; }

        string IProduct.Id => Id.ToString();
        
        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

    }
}
