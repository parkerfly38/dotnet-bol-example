using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOLCommoditiesHandlingUnits : BaseModel
{
    public int? Count { get; set; }

    public string Type { get; set; } = null!;

    public int? TareWeight { get; set; }

    public int? Weight { get; set; }

    public string WeightUnit { get; set; } = "lbs";

    public int? Length { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public string DimensionsUnit { get; set; } = "inches";

    public bool? Stackable { get; set; }

    public List<BOLCommmoditiesLineItems> LineItems { get; set; } = null!;

    [ForeignKey("BOLCommodities")]
    public Guid BOLCommoditiesId { get; set; }

}