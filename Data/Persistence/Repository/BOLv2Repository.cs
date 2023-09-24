using dotnet_example.Models;
using dotnet_example.Repository;
using dotnet_example.RequestModels;
using dotnet_example.RequestModels.BOL.v202;
using dotnet_example.ResponseModels;

namespace dotnet_example.Data.Persistence.Repository;

public class BOLv2Repository : DataRepository<BOL>, IBOLv2Repository
{
    public BOLv2Repository(BaseDataContext context) : base(context)
    {}

    public async Task<BOLResponse> AddWithBOLResponse(BOLRequest bol)
    {
        BOL newBOL = new BOL();
        newBOL.Id = new Guid();
        newBOL.RequestedPickupDate = DateTime.Parse(bol.Bol.RequestedPickupDate);
        newBOL.Function = bol.Bol.Function;
        newBOL.IsTest = bol.Bol.IsTest ?? false;
        newBOL.RequestorRole = bol.Bol.RequestorRole;
        newBOL.SpecialInstructions = bol.Bol.SpecialInstructions;
        newBOL.ShipmentTotals = await AddShipmentTotals(bol.ShipmentTotals);
        newBOL.ReferenceNumbers = await AddReferenceNumbers(bol.ReferenceNumbers);
        newBOL.ReferenceNumbers.Po = await AddReferenceNumbersPO(bol.ReferenceNumbers.Po, newBOL.ReferenceNumbers.Id);
        newBOL.ReferenceNumbers.AdditionalReferences = await AddAdditionalReferences(bol.ReferenceNumbers.AdditionalReferences, newBOL.ReferenceNumbers.Id);
        newBOL.Payment = await AddPayment(bol.Payment);
        newBOL.Origin = await AddOrigin(bol.Origin);
        newBOL.Notifications = await AddNotifications(bol.Notifications, newBOL.Id);
        newBOL.Images = await AddImages(bol.Images);
        newBOL.Destination = await AddDesintation(bol.Destination);
        newBOL.Accessorials = await AddAccessorials(bol.Accessorials);
        newBOL.Commodities = await AddCommodities(bol.Commodities);
        newBOL.BillTo = await AddBillTo(bol.BillTo);
        newBOL.CustomsBroker = await AddCustomsBroker(bol.CustomsBroker);

        // insert a method here that will create a PRO number if shipper didn't provide one
        // otherwise we will assume one exists

        //insert a method here that will create or retrieve shipment reference number
        // otherwise we'll assume one exists

        // here we'd have some PDF generation / retrieval for BOL and shipping labels.

        await _context.BOLs.AddAsync(newBOL);
        BOLResponse bOLResponse = new BOLResponse
        {
            Version = "v2.0.2",
            TransactionDate = newBOL.CreatedDate,
            ReferenceNumbers = new BOLResponseReferenceNumbers
            {
                Pro = newBOL.ReferenceNumbers.Pro,
                ShipmentConfirmationNumber = newBOL.ReferenceNumbers.ShipmentId
            },
            Images = new BOLResponseImages {
                Bol = "<blank string>",
                ShippingLabels = "<blank string>"
            },
            //add a blank message status for now
            MessageStatus = new BOLResponseMessageStatus(),
            ResultStatusCodes = new List<Object>() 
        };
        return bOLResponse;
    }

    #region private methods
    private async Task<BOLShipmentTotals> AddShipmentTotals(BOLRequestShipmentTotals shipmentTotals)
    {
        BOLShipmentTotals newShipmentTotal = new BOLShipmentTotals()
        {
            GrossWeight = shipmentTotals.GrossWeight,
            NetWeight = shipmentTotals.NetWeight,
            WeightUnit = shipmentTotals.WeightUnit,
            HandlingUnits = shipmentTotals.HandlingUnits,
            LinearLength = shipmentTotals.LinearLength,
            DimensionsUnit = shipmentTotals.DimensionsUnit,
            Cube = shipmentTotals.Cube,
            CubeDimensionsUnit = shipmentTotals.CubeDimensionsUnit,
            DeclaredValue = shipmentTotals.DeclaredValue,
            Currency = shipmentTotals.Currency
        };
        await _context.BOLShipmentTotals.AddAsync(newShipmentTotal);
        return newShipmentTotal;
    }

    private async Task<BOLReferenceNumbers> AddReferenceNumbers(BOLRequestReferenceNumbers referenceNumbers)
    {
        BOLReferenceNumbers newReferenceNumbers = new BOLReferenceNumbers()
        {
            Pro = referenceNumbers.Pro,
            QuoteId = referenceNumbers.QuoteId,
            ShipmentId = referenceNumbers.ShipmentId,
            MasterBol = referenceNumbers.MasterBol,
            Bol = referenceNumbers.Bol
        };
        await _context.BOLReferenceNumbers.AddAsync(newReferenceNumbers);
        return newReferenceNumbers;
    }

    private async Task<List<BOLReferenceNumbersPO>> AddReferenceNumbersPO(
        List<BOLRequestReferenceNumbersPo> pos, 
        Guid referenceNumberId)
    {
        List<BOLReferenceNumbersPO> newPOs = new List<BOLReferenceNumbersPO>();
        foreach (var po in pos)
        {
            BOLReferenceNumbersPO newPO = new BOLReferenceNumbersPO()
            {
                BOLReferenceNumbersId = referenceNumberId,
                Number = po.Number,
                Pieces = po.Pieces,
                Weight = po.Weight,
                WeightUnit = po.WeightUnit,
                Palletized = po.Palletized,
                AdditionalShipperInfo = po.AdditionalShipperInfo
            };
            await _context.BOLReferenceNumbersPOs.AddAsync(newPO);
            newPOs.Add(newPO);
        }
        return newPOs;
    }
    
    private async Task<List<BOLReferenceNumbersAdditionalReferences>> AddAdditionalReferences(
        List<BOLRequestReferenceNumbersAdditionalReferences> additionalReferences,
        Guid referenceNumberId)
    {
        List<BOLReferenceNumbersAdditionalReferences> newAdditionalReferences = new List<BOLReferenceNumbersAdditionalReferences>();
        foreach (var additionalReference in additionalReferences)
        {
            BOLReferenceNumbersAdditionalReferences newAdditionalReference = new BOLReferenceNumbersAdditionalReferences() {
                BOLReferenceNumbersId = referenceNumberId,
                Name = additionalReference.Name,
                Value = additionalReference.Value
            };
            await _context.BOLReferenceNumbersAdditionalReferences.AddAsync(newAdditionalReference);
            newAdditionalReferences.Add(newAdditionalReference);
        }
        return newAdditionalReferences;
    }
    
    private async Task<BOLPayment> AddPayment(BOLRequestPayment payment)
    {
        BOLPayment newPayment = new BOLPayment()
        {
            Terms = payment.Terms
        };
        await _context.BOLPayments.AddAsync(newPayment);
        return newPayment;
    }

    private async Task<Contact> AddOrigin(BOLRequestOrigin origin)
    {
        Contact newOrigin = new Contact() {
            Name = origin.Name,
            Phone = origin.Contact.Phone + " " + origin.Contact.PhoneExt,
            Email = origin.Contact.Email,
            AccountNumber = origin.Account,
            Address1 = origin.Address1,
            Address2 = origin.Address2,
            City = origin.City,
            State = origin.StateProvince,
            PostalCode = origin.Country
        };
        await _context.Contacts.AddAsync(newOrigin);
        return newOrigin;
    }

    private async Task<List<BOLNotifications>> AddNotifications(List<BOLRequestNotifications> notifications, Guid BOLid)
    {
        List<BOLNotifications> newNotifications = new List<BOLNotifications>();
        foreach (var notification in notifications)
        {
            BOLNotifications newNotification = new BOLNotifications() {
                BOLId = BOLid,
                PhoneNumber = notification.PhoneNumber,
                Email = notification.Email
            };
            await _context.BOLNotifications.AddAsync(newNotification);
            newNotifications.Add(newNotification);
        }
        return newNotifications;
    }

    private async Task<BOLImages> AddImages(BOLRequestImages images)
    {
        BOLImages newImages = new BOLImages{
            IncludeBol = images.IncludeBol,
            IncludeShippingLabels = images.IncludeShippingLabels,
            ShippingLabels = new BOLImagesShippingLables {
                Format = images.ShippingLabels.Format,
                Quantity = images.ShippingLabels.Quantity,
                Position = images.ShippingLabels.Position
            },
            Email = new BOLImagesEmail {
                IncludeBol = images.Email.IncludeBol,
                IncludeLabels = images.Email.IncludeLabels,
                Addresses = images.Email.Addresses.ToArray<string>()
            }
        };
        await _context.BOLImages.AddAsync(newImages);
        return newImages;

    }

    private async Task<Contact> AddDesintation(BOLRequestDestination destination)
    {
        Contact newDestination = new Contact {
            AccountNumber = destination.Account,
            Name = destination.Name,
            Address1 = destination.Address1,
            Address2 = destination.Address2,
            City = destination.City,
            State = destination.StateProvince,
            PostalCode = destination.PostalCode,
            Country = destination.Country,
            Phone = destination.Contact.Phone + " " + destination.Contact.PhoneExt,
            Email = destination.Contact.Email
        };
        await _context.Contacts.AddAsync(newDestination);
        return newDestination;
    }

    private async Task<BOLAccessorials> AddAccessorials(BOLRequestAccessorials accessorials)
    {
        BOLAccessorials newAccessorials = new BOLAccessorials {
            Codes = accessorials.Codes,
            HazardousDetails = new BOLAccessorialsHazardousDetails {
                EmergencyContact = new BOLAccessorialsHazardousDetailsEmergencyContact
                {
                    Name = accessorials.HazardousDetails.EmergencyContact.Name,
                    Phone = accessorials.HazardousDetails.EmergencyContact.Phone
                }
            },
            Cod = new BOLAccessorialsCod
            {
                Amount = Convert.ToDecimal(accessorials.Cod.Amount),
                Currency = accessorials.Cod.Currency,
                Terms = accessorials.Cod.Terms,
                CustomerCheckAcceptable = accessorials.Cod.CustomerCheckAcceptable ?? false,
                RemitTo = new Contact{
                    Name = accessorials.Cod.RemitTo.Name,
                    Address1 = accessorials.Cod.RemitTo.Address1,
                    Address2 = accessorials.Cod.RemitTo.Address2,
                    City = accessorials.Cod.RemitTo.City,
                    State = accessorials.Cod.RemitTo.StateProvince,
                    PostalCode = accessorials.Cod.RemitTo.PostalCode,
                    Country = accessorials.Cod.RemitTo.Country
                }
            },
            SortAndSegregateDetails = new BOLAccessorialsSortAndSegregateDetails {
                Pieces = accessorials.SortAndSegregateDetails.Pieces
            },
            FullValueCoverageDetails = new BOLAccessorialsFullValueCoverageDetails {
                MonetaryValue = Convert.ToDecimal(accessorials.FullValueCoverageDetails.MonetaryValue),
                Currency = accessorials.FullValueCoverageDetails.Currency
            },
            MarkDetails = new BOLAccessorialsMarkDetails {
                Pieces = accessorials.MarkDetails.Pieces
            },
            LimitedAccessType = new BOLAccessorialsLimitedAccessType {
                Origin = accessorials.LimitedAccessType.Origin,
                Destination = accessorials.LimitedAccessType.Destination
            },
            TimeCriticalDetails = new BOLAccessorialsTimeCriticalDetails {
                Type = accessorials.TimeCriticalDetails.Type,
                Start = DateTime.Parse(accessorials.TimeCriticalDetails.Date.Start),
                End = DateTime.Parse(accessorials.TimeCriticalDetails.Date.End)
            },
            AppointmentDetails = new BOLAccessorialsAppointmentDetails {
                PickupStart = DateTime.Parse(accessorials.AppointmentDetails.Pickup.Start),
                PickUpEnd = DateTime.Parse(accessorials.AppointmentDetails.Pickup.End),
                DeliveryStart = DateTime.Parse(accessorials.AppointmentDetails.Delivery.Start),
                DeliveryEnd = DateTime.Parse(accessorials.AppointmentDetails.Delivery.End)
            }
        };
        await _context.AddAsync(newAccessorials);
        return newAccessorials;
    }

    private async Task<BOLCommodities> AddCommodities(BOLRequestCommodities commodities)
    {
        BOLCommodities newCommodities = new BOLCommodities
        {
            LineItemLayout = commodities.LineItemLayout
        };
        newCommodities.HandlingUnits = new List<BOLCommoditiesHandlingUnits>();
        foreach (var handlingUnit in commodities.HandlingUnits)
        {
            BOLCommoditiesHandlingUnits newCommoditiesHandlingUnits = new BOLCommoditiesHandlingUnits
            {
                Count = handlingUnit.Count,
                Type = handlingUnit.Type,
                TareWeight = handlingUnit.TareWeight ?? 0,
                Weight = handlingUnit.Weight,
                WeightUnit = handlingUnit.WeightUnit ?? "lbs",
                Length = handlingUnit.Length,
                Width = handlingUnit.Width,
                Height = handlingUnit.Height,
                DimensionsUnit = handlingUnit.DimensionsUnit ?? "inches",
                Stackable = handlingUnit.Stackable ?? false,
                LineItems = new List<BOLCommmoditiesLineItems>()              
            };
            foreach (var lineItem in handlingUnit.LineItems)
            {
                BOLCommmoditiesLineItems newLineItem = new BOLCommmoditiesLineItems
                {
                    Description = lineItem.Description,
                    Weight = lineItem.Weight,
                    WeightUnit = lineItem.WeightUnit ?? "lbs",
                    Pieces = lineItem.Pieces,
                    PackagingType = lineItem.PackagingType,
                    Classification = lineItem.Classification,
                    Nmfc = lineItem.Nmfc,
                    NmfcSub = lineItem.NmfcSub,
                    Hazardous = lineItem.Hazardous ?? false,
                    HazardousDescription = lineItem.HazardousDescription,
                    HazardousDetails = new BOLCommoditiesHazardousDetails
                    {
                        Weight = lineItem.HazardousDetails.Weight,
                        WeightUnit = lineItem.HazardousDetails.WeightUnit ?? "lbs",
                        Class = lineItem.HazardousDetails._Class,
                        UnnaNumber = lineItem.HazardousDetails.UnnaNumber,
                        Propername = lineItem.HazardousDetails.Propername,
                        TechnicalName = lineItem.HazardousDetails.TechnicalName,
                        PackingGroup = lineItem.HazardousDetails.PackingGroup,
                        ContractNumber = lineItem.HazardousDetails.ContractNumber
                    }
                };
                newCommoditiesHandlingUnits.LineItems.Add(newLineItem);
            }
            newCommodities.HandlingUnits.Add(newCommoditiesHandlingUnits);
        }
        await _context.BOLCommodities.AddAsync(newCommodities);
        return newCommodities;

    }

    public async Task<Contact> AddBillTo(BOLRequestBillTo billTo)
    {
        Contact newBillTo = new Contact
        {
            AccountNumber = billTo.Account,
            Name = billTo.Name,
            Address1 = billTo.Address1,
            Address2 = billTo.Address2,
            City = billTo.City,
            State = billTo.StateProvince,
            PostalCode = billTo.PostalCode,
            Country = billTo.Country,
            Phone = billTo.Contact.Phone + " " + billTo.Contact.PhoneExt,
            Email = billTo.Contact.Email
        };
        await _context.Contacts.AddAsync(newBillTo);
        return newBillTo;
    }

    private async Task<Contact> AddCustomsBroker(BOLRequestCustomsBroker customsBroker)
    {
        Contact newCustomsBroker = new Contact
        {
            CustomsBrokerType = customsBroker.Type,
            Name = customsBroker.Name,
            Address1 = customsBroker.Address1,
            Address2 = customsBroker.Address2,
            City = customsBroker.City,
            State = customsBroker.StateProvince,
            PostalCode = customsBroker.PostalCode,
            Country = customsBroker.Country,
            Email = customsBroker.Contact.Email,
            Phone = customsBroker.Contact.Phone + " " + customsBroker.Contact.PhoneExt
        };
        await _context.Contacts.AddAsync(newCustomsBroker);
        return newCustomsBroker;
    }

    #endregion
}