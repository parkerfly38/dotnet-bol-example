namespace dotnet_example.ResponseModels;

public class BOLResponseImages
{
    /// <summary>
    /// Base 64 encoded PDF of the populated Bill of Lading.  Any bar code within the image(s) should include the check digit when applicable.
    /// </summary>
    public string Bol { get; set; } = null!;

    /// <summary>
    /// Base 64 encoded PDF of the populated shipping labels.  Any bar code within the image(s) should include the check digit when applicable.
    /// </summary>
    public string ShippingLabels { get; set; } = null!;
}