using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOLAccessorialsHazardousDetails : BaseModel
{
    public BOLAccessorialsHazardousDetailsEmergencyContact EmergencyContact { get; set; } = null!;
}