using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOLImagesEmail : BaseModel
{
    public bool? IncludeBol { get; set; }
    public bool? IncludeLabels { get; set; }
    public string[]? Addresses { get; set; }

    [ForeignKey("BOLImages")]
    public Guid BOLImagesId { get; set; }
}