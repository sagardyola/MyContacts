using MyContacts.Models;

namespace MyContacts.Client.Service.IService
{
    public interface IContactDetailService
    {
        public Task<ContactDetailDTO> Get(int ID);
        public Task<IEnumerable<ContactDetailDTO>> GetAll();
        public Task<ContactDetailDTO> Create(ContactDetailDTO objDTO);
        public Task<ContactDetailDTO> Edit(ContactDetailDTO objDTO);
        public Task Delete(int ID);
    }
}
