namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

/// <summary>
/// Represents a request to create a new Product in the system.
/// </summary>
public class CreateProductRequest
{
    /// <summary>
    /// Gets or sets the Name. Must be unique and contain only valid characters.
    /// </summary>
    public string ProductName { get; set; } = string.Empty;
    public decimal UnitPrice { get; set; } = decimal.Zero;

}