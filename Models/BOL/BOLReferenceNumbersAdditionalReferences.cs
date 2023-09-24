using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOLReferenceNumbersAdditionalReferences : BaseModel
{
    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    [ForeignKey("BOLReferenceNumbers")]
    public Guid BOLReferenceNumbersId { get; set; }
}