using MyContacts.Client.Service.IService;
using MyContacts.Models;
using Newtonsoft.Json;

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
        public Task<LabelDTO> Create(LabelDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<LabelDTO> Edit(LabelDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<LabelDTO> Get(int ID)
        {
            throw new NotImplementedException();
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
