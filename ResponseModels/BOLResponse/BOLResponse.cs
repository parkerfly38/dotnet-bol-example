using dotnet_example.ResponseModels;

namespace dotnet_example.RequestModels;

public class BOLResponse
{
    /// <summary>
    /// Indicates which version of the Digital LTL Council Bill of Lading spec was returned
    /// </summary>
    public string Version { get; set; } = null!;

    /// <summary>
    /// The date associated with this electronic bill of lading transaction.
    /// </summary>
    public DateTime TransactionDate { get; set; }

    /// <summary>
    /// Reference numbers, including shipper's PRO number (or carrier-assigned PRO number when shipper doesn't include one) and carrier shipment confirmation number.
    /// </summary>
    public BOLResponseReferenceNumbers ReferenceNumbers { get; set; } = null!;

    /// <summary>
    /// Base 64 PDFs of completed bill of lading and any shipping labels. 
    /// </summary>
    public BOLResponseImages Images { get; set; } = null!;

    /// <summary>
    /// BOL Status messages
    /// </summary>
    public BOLResponseMessageStatus MessageStatus { get; set; } = null!;

    /// <summary>
    /// Error response
    /// </summary>
    public List<Object> ResultStatusCodes { get; set; } = null!;


}