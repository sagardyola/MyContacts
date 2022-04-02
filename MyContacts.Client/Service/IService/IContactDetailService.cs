using MyContacts.DataAccess;
using MyContacts.Models;

namespace MyContacts.Client.Service.IService
{
    public interface IContactDetailService
    {
        public Task<ContactDetailDTO> Create(ContactDetailDTO objDTO);
        public Task<ContactDetailDTO> Edit(ContactDetailDTO objDTO);
        public Task<int> Delete(int id);
        public Task<ContactDetailDTO> Get(int ID);
        public Task<IEnumerable<ContactDetailDTO>> GetAll();
    }
}
