using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOL : BaseModel
{
    public DateTime RequestedPickupDate { get; set; }
    public string Function { get; set; } = null!;
    public bool IsTest { get; set; } = false;
    public string RequestorRole { get; set; } = null!;
    public string SpecialInstructions { get; set; } = null!;

    [ForeignKey("BOLImages")]
    public Guid BOLImagesId { get; set; }
    public BOLImages Images { get; set; } = null!;

    public List<BOLNotifications> Notifications { get; set; } = null!;

    [ForeignKey("BOLReferenceNumbers")]
    public Guid BOLReferenceNumbersId { get; set; }
    public BOLReferenceNumbers ReferenceNumbers { get; set; } = null!;

    [ForeignKey("BOLPayment")]
    public Guid BOLPaymentId { get; set; }
    public BOLPayment Payment { get; set; } = null!;

    [ForeignKey("BOLCommodities")]
    public Guid BOLCommoditiesId { get; set; }
    public BOLCommodities Commodities { get; set; } = null!;

    [ForeignKey("BOLShipmentTotals")]
    public Guid BOLShipmentTotalsId { get; set; }
    public BOLShipmentTotals ShipmentTotals { get; set; } = null!;

    [ForeignKey("BOLAccessorials")]
    public Guid AccessorialsId { get; set; }
    public BOLAccessorials Accessorials { get; set; } = null!;

    [ForeignKey("Contact")]
    public Guid OriginId { get; set; }
    public Contact Origin { get; set; } = null!;

    [ForeignKey("Contact")]
    public Guid DestinationId { get; set; }
    public Contact Destination { get; set; } = null!;

    [ForeignKey("Contact")]
    public Guid BillToId { get; set; }
    public Contact BillTo { get; set; } = null!;

    [ForeignKey("Contact")]
    public Guid CustomsBrokerId { get; set; }
    public Contact CustomsBroker { get; set; } = null!;

}