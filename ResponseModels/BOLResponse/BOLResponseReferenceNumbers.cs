namespace dotnet_example.ResponseModels;

public class BOLResponseReferenceNumbers
{
    /// <summary>
    /// Shipper's pre-assigned PRO number for the requested carrier.  If one was not provided in the request, one will be auto-assigned by the carrier.  The PRO number value should include the check digit when applicable.
    /// </summary>
    public string Pro { get; set; } = null!;

    /// <summary>
    /// Number provided by the carrier to acknowledge they accepted the BOL.
    /// </summary>
    public string ShipmentConfirmationNumber { get; set; } = null!;
}