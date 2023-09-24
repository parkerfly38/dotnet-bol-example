using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using dotnet_example.Models;
using dotnet_example.RequestModels;
using dotnet_example.RequestModels.BOL.v202;
using dotnet_example.Repository;
namespace dotnet_example.Controllers;

[ApiController]
[Route("[controller]")]
public class BOLController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public BOLController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [Authorize("write:data")]
    [HttpPost]
    [Route("v202")]
    [ProducesResponseType(typeof(BOLResponse), 200)]
    [ProducesResponseType(400)]
    public async Task<IActionResult> CreateBOL([FromBody] BOLRequest bolRequest)
    {
        if (bolRequest.Version != "2.0.2")
        {
            return BadRequest("This endpoint requires a version 2.0.2 payload.");
        }
        var newBOL = await _unitOfWork.v2BOLs.AddWithBOLResponse(bolRequest);
        await _unitOfWork.SaveChanges();
        return Ok(newBOL);
    }

    [Authorize("read:data")]
    [HttpGet]
    [Route("v202")]
    [ProducesResponseType(typeof(PagedResponse<BOL>), 200)]
    public IActionResult GetBOLs([FromQuery] QueryParams qp)
    {
        return Ok(_unitOfWork.v2BOLs.Get());
    }
}