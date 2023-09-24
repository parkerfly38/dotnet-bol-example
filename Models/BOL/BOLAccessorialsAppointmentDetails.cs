namespace dotnet_example.Models;

public class BOLAccessorialsAppointmentDetails : BaseModel
{
    public DateTime? PickupStart { get; set; }

    public DateTime? PickUpEnd { get; set; }

    public DateTime? DeliveryStart { get; set; }

    public DateTime? DeliveryEnd { get; set; }
}