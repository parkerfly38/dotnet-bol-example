using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOLImages : BaseModel
{
    public bool? IncludeBol { get; set; }
    public bool? IncludeShippingLabels { get; set; }
    [ForeignKey("BOLImagesShippingLables")]
    public Guid ShippingLabelsId { get; set; }
    public BOLImagesShippingLables ShippingLabels { get; set; } = null!;

    [ForeignKey("BOLImagesEmail")]
    public Guid EmailId { get; set; }
    public BOLImagesEmail Email { get; set; } = null!;
}