using MyContacts.Models.ContactInformationDTO;

namespace MyContacts.Client.Service.IService
{
    public interface IPhoneNumberService
    {
        Task<PhoneNumberDTO> Get(int ID);
        Task<IEnumerable<PhoneNumberDTO>> GetAll();
        Task<PhoneNumberDTO> Create(PhoneNumberDTO objDTO);
        Task<PhoneNumberDTO> Edit(PhoneNumberDTO objDTO);
        Task Delete(int ID);
    }
}
