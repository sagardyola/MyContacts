using MyContacts.Models;

namespace MyContacts.Client.Service.IService
{
    public interface ILabelService
    {
        Task<LabelDTO> Get(int ID);
        Task<IEnumerable<LabelDTO>> GetAll();
        Task<LabelDTO> Create(LabelDTO objDTO);
        Task<LabelDTO> Edit(LabelDTO objDTO);
        Task Delete(int ID);
    }
}
