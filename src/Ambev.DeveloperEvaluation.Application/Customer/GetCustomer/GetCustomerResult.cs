namespace Ambev.DeveloperEvaluation.Application.Customers.GetCustomer;

/// <summary>
/// Response model for GetCustomer operation
/// </summary>
public class GetCustomerResult
{
    /// <summary>
    /// The unique identifier of the Customer
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The Customer's full name
    /// </summary>
    public string Name { get; set; } = string.Empty;

    
}
