using MyContacts.Client.Service.IService;
using MyContacts.DataAccess;
using MyContacts.Models;
using Newtonsoft.Json;

namespace MyContacts.Client.Service
{
    public class ContactDetailService : IContactDetailService
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;
        private string BaseServerUrl;

        public ContactDetailService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            BaseServerUrl = _configuration.GetSection("BaseServerUrl").Value;
        }
        public Task<ContactDetailDTO> Create(ContactDetail objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ContactDetailDTO> Get(string userName)
        {
            var response = await _httpClient.GetAsync($"/api/ContactDetail/{userName}");
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var detail = JsonConvert.DeserializeObject<ContactDetailDTO>(content);
                return detail;
            }
            else
            {
                var errorModel = JsonConvert.DeserializeObject<ErrorModelDTO>(content);
                throw new Exception(errorModel.ErrorMessage);
            }
        }

        public async Task<IEnumerable<ContactDetailDTO>> GetAll()
        {
            var response = await _httpClient.GetAsync("/api/ContactDetail");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var details = JsonConvert.DeserializeObject<IEnumerable<ContactDetailDTO>>(content);

                return details;
            }

            return new List<ContactDetailDTO>();
        }

        public Task<ContactDetailDTO> Update(ContactDetailDTO objDTO)
        {
            throw new NotImplementedException();
        }
    }
}
