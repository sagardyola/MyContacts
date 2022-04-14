using MyContacts.Models.ContactInformationDTO;

namespace MyContacts.Business.Repository.IRepository
{
    public interface IContactDetailRepository
    {
        Task<ContactDetailDTO> Get(int Id);
        Task<IEnumerable<ContactDetailDTO>> GetAll();
        Task<ContactDetailDTO> Create(ContactDetailDTO objDTO);
        Task<ContactDetailDTO> Edit(ContactDetailDTO objDTO);
        Task<int> Delete(int Id);
    }
}