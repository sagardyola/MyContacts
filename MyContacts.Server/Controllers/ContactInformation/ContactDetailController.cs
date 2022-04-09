using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyContacts.Business.Repository.IRepository;
using MyContacts.Models.ContactInformationDTO;
using MyContacts.Models.Shared;
using SD.Common.Utilities;

namespace MyContacts.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactDetailController : ControllerBase
    {
        private readonly IContactDetailRepository _detailRepository;
        private readonly IConfiguration _config;

        public ContactDetailController(IContactDetailRepository detailRepository, IConfiguration config)
        {
            _detailRepository = detailRepository;
            _config = config;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            string filePath = _config.GetValue<string>("FilePaths:ErrorMessages");
            List<ErrorModelDTO> item = JSONUtils.Read<ErrorModelDTO>(filePath);

            try
            {
                return Ok(await _detailRepository.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Records could not be loaded...",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
        }

        [HttpGet("{Id:int}")]
        public async Task<IActionResult> Get(int? Id)
        {
            if (Id == null)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Invalid Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }

            var contact = await _detailRepository.Get(Id.Value);
            if (contact == null)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Invalid Username",
                    StatusCode = StatusCodes.Status404NotFound
                });
            }

            return Ok(contact);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] ContactDetailDTO objDTO)
        {
            try
            {
                return Ok(await _detailRepository.Create(objDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Error saving record",
                    StatusCode = StatusCodes.Status404NotFound
                });
            }
        }

        [HttpPut("{objDTO}")]
        public async Task<IActionResult> Edit([FromBody] ContactDetailDTO objDTO)
        {
            try
            {
                return Ok(await _detailRepository.Edit(objDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "Error updating record",
                    StatusCode = StatusCodes.Status404NotFound
                });
            }
        }

        [HttpDelete("{Id:int}")]
        public async Task<IActionResult> Delete(int? Id)
        {
            try
            {
                if (Id == null)
                {
                    return BadRequest(new ErrorModelDTO()
                    {
                        ErrorMessage = "Invalid Id...",
                        StatusCode = StatusCodes.Status400BadRequest
                    });
                }

                var contact = await _detailRepository.Delete(Id.Value);
                if (contact == 0)
                {
                    return BadRequest(new ErrorModelDTO()
                    {
                        ErrorMessage = "The record could not be deleted...",
                        StatusCode = StatusCodes.Status404NotFound
                    });
                }

                return Ok(contact);
            }
            catch (Exception)
            {
                return BadRequest(new ErrorModelDTO()
                {
                    ErrorMessage = "The record could not be deleted...",
                    StatusCode = StatusCodes.Status404NotFound
                });
            }
        }
    }
}
