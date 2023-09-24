using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOLCommoditiesHazardousDetails : BaseModel
{
    public int? Weight { get; set; }

    public string WeightUnit { get; set; } = "lbs";

    public string Class { get; set; } = null!;

    public string UnnaNumber { get; set; } = null!;

    public string Propername { get; set; } = null!;

    public string TechnicalName { get; set; } = null!;

    public string PackingGroup { get; set; } = null!;

    public string ContractNumber { get; set; } = null!;
}