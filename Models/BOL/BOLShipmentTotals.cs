using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOLShipmentTotals: BaseModel
{
    public int? GrossWeight { get; set; }

    public int? NetWeight { get; set; }

    public string WeightUnit { get; set; } = "lbs";

    public int? HandlingUnits { get; set; }

    public int? LinearLength { get; set; }

    public string DimensionsUnit { get; set; } = "inches";

    public int? Cube { get; set; }

    public string CubeDimensionsUnit { get; set; } = "feet";

    public int? DeclaredValue { get; set; }

    public string Currency { get; set; } = "USD";

}