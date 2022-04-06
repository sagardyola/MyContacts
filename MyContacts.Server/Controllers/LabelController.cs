using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyContacts.Business.Repository.IRepository;
using MyContacts.Models;

namespace MyContacts.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabelController : ControllerBase
    {
        private readonly ILabelRepository _labelRepository;
        public LabelController(ILabelRepository labelRepository)
        {
            _labelRepository = labelRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _labelRepository.GetAll());
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

            var contact = await _labelRepository.Get(Id.Value);
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
        public async Task<IActionResult> Create([FromBody] LabelDTO objDTO)
        {
            var result = await _labelRepository.Create(objDTO);
            return Ok(result);
        }

        [HttpPut("{objDTO}")]
        public async Task<IActionResult> Edit([FromBody] LabelDTO objDTO)
        {
            var result = await _labelRepository.Edit(objDTO);
            return Ok(result);
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
                        ErrorMessage = "Invalid Id",
                        StatusCode = StatusCodes.Status400BadRequest
                    });
                }

                var contact = await _labelRepository.Delete(Id.Value);
                if (contact == 0)
                {
                    return BadRequest(new ErrorModelDTO()
                    {
                        ErrorMessage = "Id Couldnot be found",
                        StatusCode = StatusCodes.Status404NotFound
                    });
                }

                return Ok(contact);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting data");
            }
        }
    }
}
