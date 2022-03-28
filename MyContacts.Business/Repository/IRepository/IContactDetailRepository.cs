using MyContacts.Models;

namespace MyContacts.Business.Repository.IRepository
{
    public interface IContactDetailRepository
    {
        public Task<ContactDetailDTO> Create(ContactDetailDTO objDTO);
        public Task<ContactDetailDTO> Update(ContactDetailDTO objDTO);
        public Task<int> Delete(int id);
        public Task<ContactDetailDTO> Get(string userName);
        public Task<IEnumerable<ContactDetailDTO>> GetAll();
    }
}
