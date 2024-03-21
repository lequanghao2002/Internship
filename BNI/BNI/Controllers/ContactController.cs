using BNI.Data;
using BNI.Models.DTO;
using BNI.Respositories.ContactRepositories.ContactRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BNI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly IContactRepository _contactRepository;

        public ContactController(AppDbContext appDbContext,IContactRepository contactRepository)
        {
            _appDbContext = appDbContext;
            _contactRepository = contactRepository;
        }
        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var contacts = _contactRepository.GetAll();
            return Ok(contacts);
        }
        [HttpPost("add")]
        public IActionResult AddContact([FromBody] AddRequestContactDTO contact)
        {
            var newContact = _contactRepository.AddContact(contact);
            return Ok(newContact);
        }
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteContact(int id)
        {
            var deletedContact = _contactRepository.DeleteContact(id);
            return Ok(deletedContact);
        }
        [HttpPut("update")]
        public IActionResult UpdateContact(int contactId, [FromBody] AddRequestContactDTO contact)
        {
            var updatedContact = _contactRepository.UpdateContact(contactId, contact);
            return Ok(updatedContact);
        }
        [HttpGet("get-by-id")]
        public IActionResult GetById(int id)
        {
            var contact = _contactRepository.GetById(id);
            return Ok(contact);
        }
    }
}
