using dotnet_example.Models;
using dotnet_example.Repository;
using dotnet_example.RequestModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_example.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase{
    
    private readonly IUnitOfWork _unitOfWork;

    public ContactController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [Authorize("read:data")]
    [HttpGet]
    [ProducesResponseType(typeof(PagedResponse<Contact>), 200)]
    [ProducesResponseType(404)]
    public IActionResult GetAll([FromQuery] QueryParams qp)
    {
        var contacts = _unitOfWork.Contacts.Get(qp.Page, qp.PageSize);
        if (contacts != null)
        {
            return Ok(contacts);
        } else {
            return NotFound();
        }
    }

    [Authorize("read:data")]
    [HttpGet]
    [Route("{id:Guid}")]
    [ProducesResponseType(typeof(Contact), 200)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var contact = await _unitOfWork.Contacts.GetById(id);
        if (contact == null)
        {
            return NotFound();
        } else {
            return Ok(contact);
        }
    }

    [Authorize("write:data")]
    [HttpPost]
    [ProducesResponseType(typeof(Contact), 200)]
    public async Task<IActionResult> Create([FromBody] ContactRequest contact)
    {
        Contact newContact = new Contact
        {
            Name = contact.Name,
            Country = contact.Country,
            State = contact.State,
            City = contact.City,
            PostalCode = contact.PostalCode,
            Address1 = contact.Address1,
            Address2 = contact.Address2,
            Phone = contact.Phone,
            Email = contact.Email,
            LicenseNo = contact.LicenseNo,
            CompanyId = contact.CompanyId
        };
        await _unitOfWork.Contacts.Add(newContact);
        await _unitOfWork.SaveChanges();
        return Ok(newContact);
    }

    [Authorize("write:data")]
    [HttpPut]
    [ProducesResponseType(204)]
    public async Task<IActionResult> Update([FromBody] Contact contact)
    {
        _unitOfWork.Contacts.Update(contact);
        await _unitOfWork.SaveChanges();
        return NoContent();
    }

    [Authorize("write:data")]
    [HttpDelete]
    [Route("{id:Guid}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        var contact = await _unitOfWork.Contacts.GetById(id);
        if (contact != null)
        {
            _unitOfWork.Contacts.Delete(contact);
            await _unitOfWork.SaveChanges();
        } else {
            return NotFound();
        }
        return NoContent();
    }
}