namespace dotnet_example.RequestModels;

public class CompanyRequest
{
    public string Name { get; set; } = null!;

    public string? MeasureUnits { get; set; }

    public decimal LimitTemperature { get; set; }

    public decimal IdealPressure { get; set; }

    public decimal DeltaPressure { get; set; }

    public DateTime? Alert { get; set; }
}