using MyContacts.Client.Service.IService;
using MyContacts.Models.ContactInformationDTO;

namespace MyContacts.Client.Service
{
    public class PhoneNumberService : IPhoneNumberService
    {
        public Task<PhoneNumberDTO> Create(PhoneNumberDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<PhoneNumberDTO> Edit(PhoneNumberDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<PhoneNumberDTO> Get(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PhoneNumberDTO>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
