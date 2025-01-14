using Ambev.DeveloperEvaluation.Common.Entities;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using System.Collections.ObjectModel;

namespace Ambev.DeveloperEvaluation.Domain.Entities;


/// <summary>
/// Represents a Sale in the system with authentication and profile information.
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class Sale : BaseEntity, ISale
{
    public required string SaleNumber { get; set; } = string.Empty;

    public required DateTime SaleDate { get; set; } = DateTime.Today;
    public required Guid CustomerId { get; set; }
    public required Customer Customer { get; set; }
    public required Collection<ISaleItem> SaleItems { get; set; }
    public decimal Total { get; set; } = 0 ;
    public required Guid UserId { get; set; }
    public required User User { get; set; }
    public required CancelStatus CancelStatus { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets the unique identifier of the Sale.
    /// </summary>
    /// <returns>The Sale's ID as a string.</returns>
    string ISale.Id => Id.ToString();

    /// <summary>
    /// Gets the Salename.
    /// </summary>
    /// <returns>The Salename.</returns>
    string ISale.SaleNumber => SaleNumber;

    /// <summary>
    /// Performs validation of the Sale entity using the SaleValidator rules.
    /// </summary>
    /// <returns>
    /// A <see cref="ValidationResultDetail"/> containing:
    /// - IsValid: Indicates whether all validation rules passed
    /// - Errors: Collection of validation errors if any rules failed
    /// </returns>
    /// <remarks>
    /// <listheader>The validation includes checking:</listheader>
    /// <list type="bullet">Salename format and length</list>
    /// <list type="bullet">Email format</list>
    /// <list type="bullet">Phone number format</list>
    /// <list type="bullet">Password complexity requirements</list>
    /// <list type="bullet">Role validity</list>
    /// 
    /// </remarks>
    public ValidationResultDetail Validate()
    {
        var validator = new SaleValidator();
        var result = validator.Validate(this);
        
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }

    /// <summary>
    /// Activates the Sale account.
    /// Changes the Sale's status to Active.
    /// </summary>
    public void Activate()
    {
        CancelStatus = CancelStatus.NotCancelled;
    }

    /// <summary>
    /// Deactivates the Sale account.
    /// Changes the Sale's status to Inactive.
    /// </summary>
    public void Cancel()
    {
        CancelStatus = CancelStatus.Cancelled;
        UpdatedAt = DateTime.UtcNow;
    }

}