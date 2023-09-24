using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOLReferenceNumbers : BaseModel
{
    public string Pro { get; set; } = null!;

    public string QuoteId { get; set; } = null!;

    public string ShipmentId { get; set; } = null!;

    public string MasterBol { get; set; } = null!;

    public List<string> Bol { get; set; } = null!;
    public List<BOLReferenceNumbersPO> Po { get; set; } = null!;
    public List<BOLReferenceNumbersAdditionalReferences> AdditionalReferences { get; set; } = null!;

}