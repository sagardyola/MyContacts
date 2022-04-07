using MyContacts.Models.ContactInformationDTO;

namespace MyContacts.Business.Repository.IRepository
{
    public interface IPhoneNumberRepository
    {
        Task<PhoneNumberDTO> Get(int Id);
        Task<IEnumerable<PhoneNumberDTO>> GetAll(int? id = null);
        Task<PhoneNumberDTO> Create(PhoneNumberDTO objDTO);
        Task<PhoneNumberDTO> Edit(PhoneNumberDTO objDTO);
        Task<int> Delete(int Id);
    }
}
