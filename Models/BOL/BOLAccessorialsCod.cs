using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOLAccessorialsCod : BaseModel
{
    public decimal Amount { get; set; } = 0;

    public string Currency { get; set; } = "USD";

    public string Terms { get; set; } = null!;

    public bool? CustomerCheckAcceptable { get; set; }

    [ForeignKey("Contact")]
    public Guid RemitToId { get; set; }
    public Contact RemitTo { get; set; } = null!;

}