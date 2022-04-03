using MyContacts.Models;

namespace MyContacts.Business.Repository.IRepository
{
    public interface IContactDetailRepository
    {
        public Task<ContactDetailDTO> Create(ContactDetailDTO objDTO);
        public Task<ContactDetailDTO> Edit(ContactDetailDTO objDTO);
        public Task<int> Delete(int ID);
        public Task<ContactDetailDTO> Get(int ID);
        public Task<IEnumerable<ContactDetailDTO>> GetAll();
    }
}