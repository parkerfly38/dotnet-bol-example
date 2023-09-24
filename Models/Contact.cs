using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class Contact : BaseModel
{
    public string? AccountNumber { get; set; }

    public string? CustomsBrokerType { get; set; }

    public string Name { get; set; } = null!;

    public string? Country { get; set; }

    public string? State  {get; set; }

    public string? City { get; set; }

    public string? PostalCode { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? LicenseNo { get; set; }

    [ForeignKey("Company")]
    public Guid CompanyId { get; set; }

    public Company Company { get; set; } = null!;
}