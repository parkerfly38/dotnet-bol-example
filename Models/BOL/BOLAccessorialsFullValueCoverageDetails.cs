using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOLAccessorialsFullValueCoverageDetails : BaseModel
{
    public decimal MonetaryValue { get; set; } = 0;

    public string Currency { get; set; } = "USD";

}