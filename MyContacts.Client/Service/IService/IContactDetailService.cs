using MyContacts.DataAccess;
using MyContacts.Models;

namespace MyContacts.Client.Service.IService
{
    public interface IContactDetailService
    {
        public Task<ContactDetailDTO> Create(ContactDetail objDTO);
        public Task<ContactDetailDTO> Update(ContactDetailDTO objDTO);
        public Task<int> Delete(int id);
        public Task<ContactDetailDTO> Get(string userName);
        public Task<IEnumerable<ContactDetailDTO>> GetAll();
    }
}
