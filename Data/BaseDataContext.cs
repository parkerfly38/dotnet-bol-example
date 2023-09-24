using Microsoft.EntityFrameworkCore;
using dotnet_example.Models;

namespace dotnet_example.Data;

public class BaseDataContext : DbContext
{
    private readonly DbContextOptions<BaseDataContext> _options;

    public DbContextOptions<BaseDataContext> Options {
        get { return _options; }
    }

    public BaseDataContext(DbContextOptions<BaseDataContext> options) : base(options)
    {
        _options = options;
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Trace);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("uuid-ossp");

        foreach (var entity in modelBuilder.Model.GetEntityTypes())
        {
            foreach (var property in entity.GetProperties())
            {
                if (property.Name == "Id")
                {
                    property.SetDefaultValueSql("uuid_generate_v4()");
                }
            }
        }
    }

    public DbSet<Company> Companies { get; set; } = null!;

    public DbSet<Contact> Contacts { get; set; } = null!;

    public DbSet<BOL> BOLs { get; set; } = null!;

    public DbSet<BOLAccessorials> BOLAccessorials { get; set; } = null!;

     public DbSet<BOLAccessorialsAppointmentDetails> BOLAccessorialsAppointmentDetails { get; set; } = null!;
    public DbSet<BOLAccessorialsCod> BOLAccessorialsCods { get; set; } = null!;
    public DbSet<BOLAccessorialsFullValueCoverageDetails> BOLAccessorialsFullValueCoverageDetails { get; set; } = null!;
    public DbSet<BOLAccessorialsHazardousDetails> BOLAccessorialsHazardousDetails { get; set; } = null!;
    public DbSet<BOLAccessorialsHazardousDetailsEmergencyContact> BOLAccessorialsHazardousDetailsEmergencyContacts { get; set; } = null!;
    public DbSet<BOLAccessorialsLimitedAccessType> BOLAccessorialsLimitedAccessTypes { get; set; } = null!;
    public DbSet<BOLAccessorialsMarkDetails> BOLAccessorialsMarkDetails { get; set; } = null!;
    public DbSet<BOLAccessorialsSortAndSegregateDetails> BOLAccessorialsSortAndSegregateDetails { get; set; } = null!;
    public DbSet<BOLAccessorialsTimeCriticalDetails> BOLAccessorialsTimeCriticalDetails { get; set; } = null!;
    public DbSet<BOLCommodities> BOLCommodities { get; set; } = null!;
    public DbSet<BOLCommoditiesHandlingUnits> BOLCommoditiesHandlingUnits { get; set; } = null!;
    public DbSet<BOLCommoditiesHazardousDetails> BOLCommoditiesHazardousDetails { get; set; } = null!;
    public DbSet<BOLCommmoditiesLineItems> BOLCommmoditiesLineItems { get; set; } = null!;
    public DbSet<BOLImages> BOLImages { get; set; } = null!;
    public DbSet<BOLImagesEmail> BOLImagesEmails { get; set; } = null!;
    public DbSet<BOLImagesShippingLables> BOLImagesShippingLables { get; set; } = null!;
    public DbSet<BOLNotifications> BOLNotifications { get; set; } = null!;
    public DbSet<BOLPayment> BOLPayments { get; set; } = null!;
    public DbSet<BOLReferenceNumbers> BOLReferenceNumbers { get; set; } = null!;
    public DbSet<BOLReferenceNumbersAdditionalReferences> BOLReferenceNumbersAdditionalReferences { get; set; } = null!;
    public DbSet<BOLReferenceNumbersPO> BOLReferenceNumbersPOs { get; set; } = null!;
    public DbSet<BOLShipmentTotals> BOLShipmentTotals { get; set; } = null!;
}