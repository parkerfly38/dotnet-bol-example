using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOLReferenceNumbersPO : BaseModel
{
    public string Number { get; set; } = null!;

    public int? Pieces { get; set; }

    public int? Weight { get; set; }

    public string WeightUnit { get; set; } = "lbs";

    public bool? Palletized { get; set; }

    public string AdditionalShipperInfo { get; set; } = null!;

    [ForeignKey("BOLReferenceNumbers")]
    public Guid BOLReferenceNumbersId { get; set; }
}