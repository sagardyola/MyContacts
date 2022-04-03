using MyContacts.Client.Service.IService;
using MyContacts.Models;

namespace MyContacts.Client.Service
{
    public class ContactNumberService : IContactNumberService
    {
        public Task<ContactNumberDTO> Create(ContactNumberDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<ContactNumberDTO> Edit(ContactNumberDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ContactNumberDTO> Get(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ContactNumberDTO>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
