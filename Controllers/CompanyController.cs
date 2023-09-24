using dotnet_example.Models;
using dotnet_example.Repository;
using dotnet_example.RequestModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_example.Controllers;

[ApiController]
[Route("[controller]")]
public class CompanyController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public CompanyController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [Authorize("read:data")]
    [HttpGet]
    [ProducesResponseType(typeof(PagedResponse<Company>), 200)]
    [Produces("application/json")]
    [ProducesResponseType(404)]
    public IActionResult GetAll([FromQuery] QueryParams qp)
    {
        var companies = _unitOfWork.Companies.Get(qp.Page, qp.PageSize);
        if (companies != null)
        {
            return Ok(companies);
        } else {
            return NotFound();
        }
    }

    [Authorize("read:data")]
    [HttpGet]
    [Route("{id:Guid}")]
    [ProducesResponseType(typeof(Company), 200)]
    [Produces("application/json")]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var company = await _unitOfWork.Companies.GetById(id);
        if (company == null)
        {
            return NotFound();
        } else {
            return Ok(company);
        }
    }

    [Authorize("write:data")]
    [HttpPost]
    [ProducesResponseType(typeof(Company), 200)]
    [Produces("application/json")]
    public async Task<IActionResult> Create([FromBody] CompanyRequest company)
    {
        Company newCompany = new Company(){
            Name = company.Name,
            MeasureUnits = company.MeasureUnits,
            LimitTemperature = company.LimitTemperature,
            IdealPressure = company.IdealPressure,
            DeltaPressure = company.DeltaPressure,
            Alert = company.Alert
        };
        await _unitOfWork.Companies.Add(newCompany);
        await _unitOfWork.SaveChanges();
        return Ok(newCompany);
    }

    [Authorize("write:data")]
    [HttpPut]
    [ProducesResponseType(204)]
    public IActionResult Update([FromBody] Company company)
    {
        _unitOfWork.Companies.Update(company);
        _unitOfWork.SaveChanges();
        return NoContent();
    }

    [Authorize("write:data")]
    [HttpDelete]
    [Route("{id:Guid}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        var company = await _unitOfWork.Companies.GetById(id);
        if (company != null)
        {
            _unitOfWork.Companies.Delete(company);
            _unitOfWork.SaveChanges();
        } else {
            return NotFound();
        }
        return NoContent();
    }

}