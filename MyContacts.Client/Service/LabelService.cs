using MyContacts.Client.Service.IService;
using MyContacts.Models;
using Newtonsoft.Json;
using System.Text;

namespace MyContacts.Client.Service
{
    public class LabelService : ILabelService
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;

        public LabelService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public async Task<LabelDTO> Create(LabelDTO objDTO)
        {
            var content = JsonConvert.SerializeObject(objDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/Label/Create", bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<LabelDTO>(responseResult);
                return result;
            }

            return new LabelDTO();
        }

        public async Task Delete(int Id)
        {
            var response = await _httpClient.DeleteAsync($"api/Label/{Id}");
        }

        public async Task<LabelDTO> Edit(LabelDTO objDTO)
        {
            var content = JsonConvert.SerializeObject(objDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync("api/Label/{objDTO}", bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<LabelDTO>(responseResult);
                return result;
            }

            return new LabelDTO();
        }

        public async Task<LabelDTO> Get(int Id)
        {
            var response = await _httpClient.GetAsync($"api/Label/{Id}");
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var detail = JsonConvert.DeserializeObject<LabelDTO>(content);
                return detail;
            }
            else
            {
                var errorModel = JsonConvert.DeserializeObject<ErrorModelDTO>(content);
                throw new Exception(errorModel.ErrorMessage);
            }
        }

        public async Task<IEnumerable<LabelDTO>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/Label");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var details = JsonConvert.DeserializeObject<IEnumerable<LabelDTO>>(content);

                return details;
            }

            return new List<LabelDTO>();
        }
    }
}
