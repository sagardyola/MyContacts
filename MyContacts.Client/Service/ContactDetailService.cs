using MyContacts.Client.Service.IService;
using MyContacts.DataAccess;
using MyContacts.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;

namespace MyContacts.Client.Service
{
    public class ContactDetailService : IContactDetailService
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;
        //private string BaseServerUrl;

        public ContactDetailService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            //BaseServerUrl = _configuration.GetSection("BaseServerUrl").Value;
        }

        public async Task<ContactDetailDTO> Get(int ID)
        {
            var response = await _httpClient.GetAsync($"api/ContactDetail/{ID}");
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
            var response = await _httpClient.GetAsync("api/ContactDetail");
            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<IEnumerable<ContactDetailDTO>>(content);
                return result;
            }

            return new List<ContactDetailDTO>();
        }

        public async Task<ContactDetailDTO> Create(ContactDetailDTO objDTO)
        {
            var content = JsonConvert.SerializeObject(objDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/ContactDetail/Create", bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<ContactDetailDTO>(responseResult);
                return result;
            }

            return new ContactDetailDTO();
        }

        public async Task<ContactDetailDTO> Edit(ContactDetailDTO objDTO)
        {
            var content = JsonConvert.SerializeObject(objDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/contactdetail/{objDTO}", bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<ContactDetailDTO>(responseResult);
                return result;
            }

            return new ContactDetailDTO();
        }

        public async Task Delete(int ID)
        {
            var response = await _httpClient.DeleteAsync($"api/ContactDetail/{ID}");
            /*
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
            */
        }
    }
}
