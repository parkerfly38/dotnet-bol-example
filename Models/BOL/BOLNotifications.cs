using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOLNotifications : BaseModel
{
    public string PhoneNumber { get; set; } = null!;
    public string Email { get; set; } = null!;

    [ForeignKey("BOL")]
    public Guid BOLId { get; set; }
}