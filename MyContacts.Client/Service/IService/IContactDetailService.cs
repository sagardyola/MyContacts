using MyContacts.Models.ContactInformationDTO;

namespace MyContacts.Client.Service.IService
{
    public interface IContactDetailService
    {
        public Task<ContactDetailDTO> Get(int Id);
        public Task<IEnumerable<ContactDetailDTO>> GetAll();
        public Task<ContactDetailDTO> Create(ContactDetailDTO objDTO);
        public Task<ContactDetailDTO> Edit(ContactDetailDTO objDTO);
        public Task Delete(int Id);
    }
}
