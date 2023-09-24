using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOLAccessorialsHazardousDetailsEmergencyContact : BaseModel
{
    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    [ForeignKey("BOLAccessorialsHazardousDetails")]
    public Guid BOLAccessorialsHazardousDetailsId { get; set; }
}