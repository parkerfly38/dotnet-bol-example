using dotnet_example.Models;
using dotnet_example.RequestModels;
using dotnet_example.RequestModels.BOL.v202;
using dotnet_example.ResponseModels;

namespace dotnet_example.Repository;

public interface IBOLv2Repository : IDataRepository<BOL>
{
    Task<BOLResponse> AddWithBOLResponse(BOLRequest bol);
}