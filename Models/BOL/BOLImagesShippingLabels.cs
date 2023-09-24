using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOLImagesShippingLables : BaseModel
{
    public string Format { get; set; } = null!;
    public int? Quantity { get; set; }
    public int? Position { get; set; }

    [ForeignKey("BOLImages")]
    public Guid BOLImagesId { get; set; }
}