using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct;

/// <summary>
/// Validator for CreateProductCommand that defines validation rules for Product creation command.
/// </summary>
public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreateProductCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - ProductName: Required, must be between 3 and 50 characters
    /// </remarks>
    public CreateProductCommandValidator()
    {
        RuleFor(Product => Product.ProductName).NotEmpty().Length(3, 50);
        RuleFor(Product => Product.UnitPrice).GreaterThan(0);
    }
}