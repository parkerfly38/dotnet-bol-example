using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOLCommmoditiesLineItems : BaseModel
{
    public string Description { get; set; } = null!;

    public int? Weight { get; set; }

    public string WeightUnit { get; set; } = "lbs";

    public int? Pieces { get; set; }

    public string PackagingType { get; set; } = null!;

    public string Classification { get; set; } = null!;

    public string Nmfc { get; set; } = null!;

    public string NmfcSub { get; set; } = null!;

    public bool? Hazardous { get; set; }

    public string HazardousDescription { get; set; } = null!;

    [ForeignKey("BOLCommoditiesHazardousDetails")]
    public Guid BOLCommoditiesHazardousDetailsId { get; set; }
    public BOLCommoditiesHazardousDetails HazardousDetails { get; set; } = null!;

    [ForeignKey("BOLCommoditiesHandlingUnits")]
    public Guid BOLCommoditiesHandlingUnitsId { get; set; }

}