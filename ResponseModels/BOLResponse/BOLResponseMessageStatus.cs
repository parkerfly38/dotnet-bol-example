namespace dotnet_example.ResponseModels;

public class BOLResponseMessageStatus
{
    /// <summary>
    /// Inidcates the status of the request.
    /// PASS - Request is successful with no exceptions
    /// FAIL - Request is unsuccessful due to some exception.
    /// WARNING - Request is successful with some exception.
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// Indicates response detail code.
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// Provides information pertaining to the response code.
    /// </summary>
    public string Message { get; set; } = null!;

    /// <summary>
    /// Provides guidance pertaining to the response code.
    /// </summary>
    public string Resolution { get; set; } = null!;

    public List<BOLResponseMessageStatusInformation> Information { get; set; } = null!;

    public List<Object> ResultStatusCodes { get; set; } = null!;

}