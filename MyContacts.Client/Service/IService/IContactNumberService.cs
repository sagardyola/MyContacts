using MyContacts.Models;

namespace MyContacts.Client.Service.IService
{
    public interface IContactNumberService
    {
        Task<ContactNumberDTO> Get(int ID);
        Task<IEnumerable<ContactNumberDTO>> GetAll();
        Task<ContactNumberDTO> Create(ContactNumberDTO objDTO);
        Task<ContactNumberDTO> Edit(ContactNumberDTO objDTO);
        Task Delete(int ID);
    }
}
