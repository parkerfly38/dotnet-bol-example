using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_example.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.CreateTable(
                name: "BOLAccessorialsAppointmentDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    PickupStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    PickUpEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeliveryStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeliveryEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLAccessorialsAppointmentDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BOLAccessorialsFullValueCoverageDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    MonetaryValue = table.Column<decimal>(type: "numeric", nullable: false),
                    Currency = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLAccessorialsFullValueCoverageDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BOLAccessorialsHazardousDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLAccessorialsHazardousDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BOLAccessorialsLimitedAccessTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Origin = table.Column<string>(type: "text", nullable: false),
                    Destination = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLAccessorialsLimitedAccessTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BOLAccessorialsMarkDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Pieces = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLAccessorialsMarkDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BOLAccessorialsSortAndSegregateDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Pieces = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLAccessorialsSortAndSegregateDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BOLAccessorialsTimeCriticalDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Start = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    End = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLAccessorialsTimeCriticalDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BOLCommodities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    LineItemLayout = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLCommodities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BOLCommoditiesHazardousDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Weight = table.Column<int>(type: "integer", nullable: true),
                    WeightUnit = table.Column<string>(type: "text", nullable: false),
                    Class = table.Column<string>(type: "text", nullable: false),
                    UnnaNumber = table.Column<string>(type: "text", nullable: false),
                    Propername = table.Column<string>(type: "text", nullable: false),
                    TechnicalName = table.Column<string>(type: "text", nullable: false),
                    PackingGroup = table.Column<string>(type: "text", nullable: false),
                    ContractNumber = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLCommoditiesHazardousDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BOLImagesEmails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    IncludeBol = table.Column<bool>(type: "boolean", nullable: true),
                    IncludeLabels = table.Column<bool>(type: "boolean", nullable: true),
                    Addresses = table.Column<string[]>(type: "text[]", nullable: true),
                    BOLImagesId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLImagesEmails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BOLImagesShippingLables",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Format = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: true),
                    Position = table.Column<int>(type: "integer", nullable: true),
                    BOLImagesId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLImagesShippingLables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BOLPayments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Terms = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLPayments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BOLReferenceNumbers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Pro = table.Column<string>(type: "text", nullable: false),
                    QuoteId = table.Column<string>(type: "text", nullable: false),
                    ShipmentId = table.Column<string>(type: "text", nullable: false),
                    MasterBol = table.Column<string>(type: "text", nullable: false),
                    Bol = table.Column<List<string>>(type: "text[]", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLReferenceNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BOLShipmentTotals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    GrossWeight = table.Column<int>(type: "integer", nullable: true),
                    NetWeight = table.Column<int>(type: "integer", nullable: true),
                    WeightUnit = table.Column<string>(type: "text", nullable: false),
                    HandlingUnits = table.Column<int>(type: "integer", nullable: true),
                    LinearLength = table.Column<int>(type: "integer", nullable: true),
                    DimensionsUnit = table.Column<string>(type: "text", nullable: false),
                    Cube = table.Column<int>(type: "integer", nullable: true),
                    CubeDimensionsUnit = table.Column<string>(type: "text", nullable: false),
                    DeclaredValue = table.Column<int>(type: "integer", nullable: true),
                    Currency = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLShipmentTotals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Name = table.Column<string>(type: "text", nullable: false),
                    MeasureUnits = table.Column<string>(type: "text", nullable: true),
                    LimitTemperature = table.Column<decimal>(type: "numeric", nullable: false),
                    IdealPressure = table.Column<decimal>(type: "numeric", nullable: false),
                    DeltaPressure = table.Column<decimal>(type: "numeric", nullable: false),
                    Alert = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BOLAccessorialsHazardousDetailsEmergencyContacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    BOLAccessorialsHazardousDetailsId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLAccessorialsHazardousDetailsEmergencyContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BOLAccessorialsHazardousDetailsEmergencyContacts_BOLAccesso~",
                        column: x => x.BOLAccessorialsHazardousDetailsId,
                        principalTable: "BOLAccessorialsHazardousDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BOLCommoditiesHandlingUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Count = table.Column<int>(type: "integer", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: false),
                    TareWeight = table.Column<int>(type: "integer", nullable: true),
                    Weight = table.Column<int>(type: "integer", nullable: true),
                    WeightUnit = table.Column<string>(type: "text", nullable: false),
                    Length = table.Column<int>(type: "integer", nullable: true),
                    Width = table.Column<int>(type: "integer", nullable: true),
                    Height = table.Column<int>(type: "integer", nullable: true),
                    DimensionsUnit = table.Column<string>(type: "text", nullable: false),
                    Stackable = table.Column<bool>(type: "boolean", nullable: true),
                    BOLCommoditiesId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLCommoditiesHandlingUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BOLCommoditiesHandlingUnits_BOLCommodities_BOLCommoditiesId",
                        column: x => x.BOLCommoditiesId,
                        principalTable: "BOLCommodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BOLImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    IncludeBol = table.Column<bool>(type: "boolean", nullable: true),
                    IncludeShippingLabels = table.Column<bool>(type: "boolean", nullable: true),
                    ShippingLabelsId = table.Column<Guid>(type: "uuid", nullable: false),
                    ShippingLabelsId1 = table.Column<Guid>(type: "uuid", nullable: false),
                    EmailId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmailId1 = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BOLImages_BOLImagesEmails_EmailId1",
                        column: x => x.EmailId1,
                        principalTable: "BOLImagesEmails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLImages_BOLImagesShippingLables_ShippingLabelsId1",
                        column: x => x.ShippingLabelsId1,
                        principalTable: "BOLImagesShippingLables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BOLReferenceNumbersAdditionalReferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    BOLReferenceNumbersId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLReferenceNumbersAdditionalReferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BOLReferenceNumbersAdditionalReferences_BOLReferenceNumbers~",
                        column: x => x.BOLReferenceNumbersId,
                        principalTable: "BOLReferenceNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BOLReferenceNumbersPOs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Number = table.Column<string>(type: "text", nullable: false),
                    Pieces = table.Column<int>(type: "integer", nullable: true),
                    Weight = table.Column<int>(type: "integer", nullable: true),
                    WeightUnit = table.Column<string>(type: "text", nullable: false),
                    Palletized = table.Column<bool>(type: "boolean", nullable: true),
                    AdditionalShipperInfo = table.Column<string>(type: "text", nullable: false),
                    BOLReferenceNumbersId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLReferenceNumbersPOs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BOLReferenceNumbersPOs_BOLReferenceNumbers_BOLReferenceNumb~",
                        column: x => x.BOLReferenceNumbersId,
                        principalTable: "BOLReferenceNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    AccountNumber = table.Column<string>(type: "text", nullable: true),
                    CustomsBrokerType = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    PostalCode = table.Column<string>(type: "text", nullable: true),
                    Address1 = table.Column<string>(type: "text", nullable: true),
                    Address2 = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    LicenseNo = table.Column<string>(type: "text", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BOLCommmoditiesLineItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Weight = table.Column<int>(type: "integer", nullable: true),
                    WeightUnit = table.Column<string>(type: "text", nullable: false),
                    Pieces = table.Column<int>(type: "integer", nullable: true),
                    PackagingType = table.Column<string>(type: "text", nullable: false),
                    Classification = table.Column<string>(type: "text", nullable: false),
                    Nmfc = table.Column<string>(type: "text", nullable: false),
                    NmfcSub = table.Column<string>(type: "text", nullable: false),
                    Hazardous = table.Column<bool>(type: "boolean", nullable: true),
                    HazardousDescription = table.Column<string>(type: "text", nullable: false),
                    BOLCommoditiesHazardousDetailsId = table.Column<Guid>(type: "uuid", nullable: false),
                    BOLCommoditiesHandlingUnitsId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLCommmoditiesLineItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BOLCommmoditiesLineItems_BOLCommoditiesHandlingUnits_BOLCom~",
                        column: x => x.BOLCommoditiesHandlingUnitsId,
                        principalTable: "BOLCommoditiesHandlingUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLCommmoditiesLineItems_BOLCommoditiesHazardousDetails_BOL~",
                        column: x => x.BOLCommoditiesHazardousDetailsId,
                        principalTable: "BOLCommoditiesHazardousDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BOLAccessorialsCods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    Currency = table.Column<string>(type: "text", nullable: false),
                    Terms = table.Column<string>(type: "text", nullable: false),
                    CustomerCheckAcceptable = table.Column<bool>(type: "boolean", nullable: true),
                    RemitToId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLAccessorialsCods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BOLAccessorialsCods_Contacts_RemitToId",
                        column: x => x.RemitToId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BOLAccessorials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Codes = table.Column<List<string>>(type: "text[]", nullable: false),
                    HazardousDetailsId = table.Column<Guid>(type: "uuid", nullable: false),
                    CodId = table.Column<Guid>(type: "uuid", nullable: false),
                    SortAndSegregateDetailsId = table.Column<Guid>(type: "uuid", nullable: false),
                    FullValueCoverageDetailsId = table.Column<Guid>(type: "uuid", nullable: false),
                    MarkDetailsId = table.Column<Guid>(type: "uuid", nullable: false),
                    LimitedAccessTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    TimeCriticalDetailsId = table.Column<Guid>(type: "uuid", nullable: false),
                    AppointmentDetailsId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLAccessorials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BOLAccessorials_BOLAccessorialsAppointmentDetails_Appointme~",
                        column: x => x.AppointmentDetailsId,
                        principalTable: "BOLAccessorialsAppointmentDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLAccessorials_BOLAccessorialsCods_CodId",
                        column: x => x.CodId,
                        principalTable: "BOLAccessorialsCods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLAccessorials_BOLAccessorialsFullValueCoverageDetails_Ful~",
                        column: x => x.FullValueCoverageDetailsId,
                        principalTable: "BOLAccessorialsFullValueCoverageDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLAccessorials_BOLAccessorialsHazardousDetails_HazardousDe~",
                        column: x => x.HazardousDetailsId,
                        principalTable: "BOLAccessorialsHazardousDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLAccessorials_BOLAccessorialsLimitedAccessTypes_LimitedAc~",
                        column: x => x.LimitedAccessTypeId,
                        principalTable: "BOLAccessorialsLimitedAccessTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLAccessorials_BOLAccessorialsMarkDetails_MarkDetailsId",
                        column: x => x.MarkDetailsId,
                        principalTable: "BOLAccessorialsMarkDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLAccessorials_BOLAccessorialsSortAndSegregateDetails_Sort~",
                        column: x => x.SortAndSegregateDetailsId,
                        principalTable: "BOLAccessorialsSortAndSegregateDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLAccessorials_BOLAccessorialsTimeCriticalDetails_TimeCrit~",
                        column: x => x.TimeCriticalDetailsId,
                        principalTable: "BOLAccessorialsTimeCriticalDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BOLs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    RequestedPickupDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Function = table.Column<string>(type: "text", nullable: false),
                    IsTest = table.Column<bool>(type: "boolean", nullable: false),
                    RequestorRole = table.Column<string>(type: "text", nullable: false),
                    SpecialInstructions = table.Column<string>(type: "text", nullable: false),
                    BOLImagesId = table.Column<Guid>(type: "uuid", nullable: false),
                    BOLReferenceNumbersId = table.Column<Guid>(type: "uuid", nullable: false),
                    BOLPaymentId = table.Column<Guid>(type: "uuid", nullable: false),
                    BOLCommoditiesId = table.Column<Guid>(type: "uuid", nullable: false),
                    BOLShipmentTotalsId = table.Column<Guid>(type: "uuid", nullable: false),
                    AccessorialsId = table.Column<Guid>(type: "uuid", nullable: false),
                    OriginId = table.Column<Guid>(type: "uuid", nullable: false),
                    DestinationId = table.Column<Guid>(type: "uuid", nullable: false),
                    BillToId = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomsBrokerId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BOLs_BOLAccessorials_AccessorialsId",
                        column: x => x.AccessorialsId,
                        principalTable: "BOLAccessorials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLs_BOLCommodities_BOLCommoditiesId",
                        column: x => x.BOLCommoditiesId,
                        principalTable: "BOLCommodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLs_BOLImages_BOLImagesId",
                        column: x => x.BOLImagesId,
                        principalTable: "BOLImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLs_BOLPayments_BOLPaymentId",
                        column: x => x.BOLPaymentId,
                        principalTable: "BOLPayments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLs_BOLReferenceNumbers_BOLReferenceNumbersId",
                        column: x => x.BOLReferenceNumbersId,
                        principalTable: "BOLReferenceNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLs_BOLShipmentTotals_BOLShipmentTotalsId",
                        column: x => x.BOLShipmentTotalsId,
                        principalTable: "BOLShipmentTotals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLs_Contacts_BillToId",
                        column: x => x.BillToId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLs_Contacts_CustomsBrokerId",
                        column: x => x.CustomsBrokerId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLs_Contacts_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOLs_Contacts_OriginId",
                        column: x => x.OriginId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BOLNotifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    BOLId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOLNotifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BOLNotifications_BOLs_BOLId",
                        column: x => x.BOLId,
                        principalTable: "BOLs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BOLAccessorials_AppointmentDetailsId",
                table: "BOLAccessorials",
                column: "AppointmentDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLAccessorials_CodId",
                table: "BOLAccessorials",
                column: "CodId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLAccessorials_FullValueCoverageDetailsId",
                table: "BOLAccessorials",
                column: "FullValueCoverageDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLAccessorials_HazardousDetailsId",
                table: "BOLAccessorials",
                column: "HazardousDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLAccessorials_LimitedAccessTypeId",
                table: "BOLAccessorials",
                column: "LimitedAccessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLAccessorials_MarkDetailsId",
                table: "BOLAccessorials",
                column: "MarkDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLAccessorials_SortAndSegregateDetailsId",
                table: "BOLAccessorials",
                column: "SortAndSegregateDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLAccessorials_TimeCriticalDetailsId",
                table: "BOLAccessorials",
                column: "TimeCriticalDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLAccessorialsCods_RemitToId",
                table: "BOLAccessorialsCods",
                column: "RemitToId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLAccessorialsHazardousDetailsEmergencyContacts_BOLAccesso~",
                table: "BOLAccessorialsHazardousDetailsEmergencyContacts",
                column: "BOLAccessorialsHazardousDetailsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BOLCommmoditiesLineItems_BOLCommoditiesHandlingUnitsId",
                table: "BOLCommmoditiesLineItems",
                column: "BOLCommoditiesHandlingUnitsId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLCommmoditiesLineItems_BOLCommoditiesHazardousDetailsId",
                table: "BOLCommmoditiesLineItems",
                column: "BOLCommoditiesHazardousDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLCommoditiesHandlingUnits_BOLCommoditiesId",
                table: "BOLCommoditiesHandlingUnits",
                column: "BOLCommoditiesId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLImages_EmailId1",
                table: "BOLImages",
                column: "EmailId1");

            migrationBuilder.CreateIndex(
                name: "IX_BOLImages_ShippingLabelsId1",
                table: "BOLImages",
                column: "ShippingLabelsId1");

            migrationBuilder.CreateIndex(
                name: "IX_BOLNotifications_BOLId",
                table: "BOLNotifications",
                column: "BOLId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLReferenceNumbersAdditionalReferences_BOLReferenceNumbers~",
                table: "BOLReferenceNumbersAdditionalReferences",
                column: "BOLReferenceNumbersId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLReferenceNumbersPOs_BOLReferenceNumbersId",
                table: "BOLReferenceNumbersPOs",
                column: "BOLReferenceNumbersId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLs_AccessorialsId",
                table: "BOLs",
                column: "AccessorialsId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLs_BillToId",
                table: "BOLs",
                column: "BillToId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLs_BOLCommoditiesId",
                table: "BOLs",
                column: "BOLCommoditiesId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLs_BOLImagesId",
                table: "BOLs",
                column: "BOLImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLs_BOLPaymentId",
                table: "BOLs",
                column: "BOLPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLs_BOLReferenceNumbersId",
                table: "BOLs",
                column: "BOLReferenceNumbersId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLs_BOLShipmentTotalsId",
                table: "BOLs",
                column: "BOLShipmentTotalsId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLs_CustomsBrokerId",
                table: "BOLs",
                column: "CustomsBrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLs_DestinationId",
                table: "BOLs",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_BOLs_OriginId",
                table: "BOLs",
                column: "OriginId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CompanyId",
                table: "Contacts",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BOLAccessorialsHazardousDetailsEmergencyContacts");

            migrationBuilder.DropTable(
                name: "BOLCommmoditiesLineItems");

            migrationBuilder.DropTable(
                name: "BOLNotifications");

            migrationBuilder.DropTable(
                name: "BOLReferenceNumbersAdditionalReferences");

            migrationBuilder.DropTable(
                name: "BOLReferenceNumbersPOs");

            migrationBuilder.DropTable(
                name: "BOLCommoditiesHandlingUnits");

            migrationBuilder.DropTable(
                name: "BOLCommoditiesHazardousDetails");

            migrationBuilder.DropTable(
                name: "BOLs");

            migrationBuilder.DropTable(
                name: "BOLAccessorials");

            migrationBuilder.DropTable(
                name: "BOLCommodities");

            migrationBuilder.DropTable(
                name: "BOLImages");

            migrationBuilder.DropTable(
                name: "BOLPayments");

            migrationBuilder.DropTable(
                name: "BOLReferenceNumbers");

            migrationBuilder.DropTable(
                name: "BOLShipmentTotals");

            migrationBuilder.DropTable(
                name: "BOLAccessorialsAppointmentDetails");

            migrationBuilder.DropTable(
                name: "BOLAccessorialsCods");

            migrationBuilder.DropTable(
                name: "BOLAccessorialsFullValueCoverageDetails");

            migrationBuilder.DropTable(
                name: "BOLAccessorialsHazardousDetails");

            migrationBuilder.DropTable(
                name: "BOLAccessorialsLimitedAccessTypes");

            migrationBuilder.DropTable(
                name: "BOLAccessorialsMarkDetails");

            migrationBuilder.DropTable(
                name: "BOLAccessorialsSortAndSegregateDetails");

            migrationBuilder.DropTable(
                name: "BOLAccessorialsTimeCriticalDetails");

            migrationBuilder.DropTable(
                name: "BOLImagesEmails");

            migrationBuilder.DropTable(
                name: "BOLImagesShippingLables");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
