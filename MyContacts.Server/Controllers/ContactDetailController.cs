using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyContacts.Business.Repository.IRepository;
using MyContacts.Models;

namespace MyContacts.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactDetailController : ControllerBase
    {

        private readonly IContactDetailRepository _detailRepository;
        public ContactDetailController(IContactDetailRepository detailRepository)
        {
            _detailRepository = detailRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _detailRepository.GetAll());
        }

        [HttpGet("{userName}")]
        public async Task<IActionResult> Get(string userName)
        {
            if (userName == null)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Invalid Username",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }

            var product = await _detailRepository.Get(userName);
            if (product == null)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Invalid Username",
                    StatusCode = StatusCodes.Status404NotFound
                });
            }

            return Ok(product);
        }
    }
}
