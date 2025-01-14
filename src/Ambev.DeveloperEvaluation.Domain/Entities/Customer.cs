using Ambev.DeveloperEvaluation.Common.Entities;
using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Customer : BaseEntity, ICustomer
    {

        public string Name { get; set; } = string.Empty;

        string ICustomer.Id => Id.ToString();

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

    }
}
