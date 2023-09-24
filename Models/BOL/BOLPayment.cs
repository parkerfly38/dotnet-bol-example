using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOLPayment : BaseModel
{
    public string Terms { get; set; } = null!;
}