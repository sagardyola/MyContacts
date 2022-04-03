using MyContacts.Models;

namespace MyContacts.Business.Repository.IRepository
{
    public interface IContactNumberRepository
    {
        Task<ContactNumberDTO> Get(int Id);
        Task<IEnumerable<ContactNumberDTO>> GetAll(int? id = null);
        Task<ContactNumberDTO> Create(ContactNumberDTO objDTO);
        Task<ContactNumberDTO> Edit(ContactNumberDTO objDTO);
        Task<int> Delete(int Id);
    }
}
