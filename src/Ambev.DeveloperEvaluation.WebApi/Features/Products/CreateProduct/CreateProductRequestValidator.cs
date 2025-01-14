﻿using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

/// <summary>
/// Validator for CreateProductRequest that defines validation rules for Product creation.
/// </summary>
public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreateProductRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Name: Required, length between 3 and 50 characters
    /// </remarks>
    public CreateProductRequestValidator()
    {
        RuleFor(Product => Product.ProductName).NotEmpty().Length(3, 50);
        RuleFor(Product => Product.UnitPrice).GreaterThan(0);
    }
}