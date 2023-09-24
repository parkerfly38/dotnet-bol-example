namespace dotnet_example.RequestModels;

public class ContactRequest
{
    public string Name { get; set; } = null!;

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? State {get; set; }

    public string? PostalCode { get; set; }

    public string? Address1  {get; set; }

    public string? Address2 { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? LicenseNo { get; set; }

    public Guid CompanyId { get; set; }
}