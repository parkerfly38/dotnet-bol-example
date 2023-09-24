using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models;

public class BOLAccessorials : BaseModel
{
    public List<string> Codes { get; set; } = null!;

    [ForeignKey("BOLAccessorialsHazardousDetails")]
    public Guid HazardousDetailsId { get; set; }
    public BOLAccessorialsHazardousDetails HazardousDetails { get; set; } = null!;

    [ForeignKey("BOLAccessorialsCod")]
    public Guid CodId { get; set; }
    public BOLAccessorialsCod Cod { get; set; } = null!;

    [ForeignKey("BOLAccessorialsSortAndSegregateDetails")]
    public Guid SortAndSegregateDetailsId { get; set; }
    public BOLAccessorialsSortAndSegregateDetails SortAndSegregateDetails { get; set; } = null!;

    [ForeignKey("BOLAccessorialsFullValueCoverageDetails")]
    public Guid FullValueCoverageDetailsId { get; set; }
    public BOLAccessorialsFullValueCoverageDetails FullValueCoverageDetails { get; set; } = null!;

    [ForeignKey("BOLAccessorialsMarkDetails")]
    public Guid MarkDetailsId { get; set; }
    public BOLAccessorialsMarkDetails MarkDetails { get; set; } = null!;

    [ForeignKey("BOLAccessorialsLimitedAccessType")]
    public Guid LimitedAccessTypeId { get; set; }
    public BOLAccessorialsLimitedAccessType LimitedAccessType { get; set; } = null!;

    [ForeignKey("BOLAccessorialsTimeCriticalDetails")]
    public Guid TimeCriticalDetailsId { get; set; }
    public BOLAccessorialsTimeCriticalDetails TimeCriticalDetails { get; set; } = null!;

    [ForeignKey("BOLAccessorialsAppointmentDetails")]
    public Guid AppointmentDetailsId { get; set; }
    public BOLAccessorialsAppointmentDetails AppointmentDetails { get; set; } = null!;

}