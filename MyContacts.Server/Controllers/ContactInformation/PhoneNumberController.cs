using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyContacts.Business.Repository.IRepository;
using MyContacts.Models.Shared;

namespace MyContacts.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneNumberController : MyContactsControllerBase
    {
        private readonly IPhoneNumberRepository _numberRepository;
        private List<ErrorModelDTO> _statusCodes = new List<ErrorModelDTO>();

        public PhoneNumberController(IPhoneNumberRepository numberRepository, IConfiguration config) : base(config)
        {
            _numberRepository = numberRepository;
            _statusCodes = new MyContactsControllerBase(config).statusCodes;
        }
    }
}
