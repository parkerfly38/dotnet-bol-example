namespace dotnet_example.Models;

public class BOLCommodities : BaseModel
{
    public string LineItemLayout { get; set; } = null!;

    public List<BOLCommoditiesHandlingUnits> HandlingUnits { get; set; } = null!;
}