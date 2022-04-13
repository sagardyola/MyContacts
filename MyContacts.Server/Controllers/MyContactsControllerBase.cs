using Microsoft.AspNetCore.Mvc;
using MyContacts.Models.Shared;
using SD.Common.Utilities;

namespace MyContacts.Server.Controllers
{
    public class MyContactsControllerBase : Controller
    {
        private readonly IConfiguration _config;
        private string _filePath;
        public List<ErrorModelDTO> statusCodes = new List<ErrorModelDTO>();
        public MyContactsControllerBase(IConfiguration config)
        {
            _config = config;
            _filePath = _config.GetValue<string>("FilePaths:ErrorMessages");
            statusCodes = _filePath.ReadJSONFile<ErrorModelDTO>();
        }
    }
}
