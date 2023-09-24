namespace dotnet_example.Models;

public class BOLAccessorialsTimeCriticalDetails : BaseModel
{
    public string Type { get; set; } = null!;
    public DateTime? Start { get; set; }
    public DateTime? End { get; set; }
}