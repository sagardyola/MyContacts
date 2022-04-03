using MyContacts.Models;

namespace MyContacts.Business.Repository.IRepository
{
    public interface ILabelRepository
    {
        Task<LabelDTO> Get(int Id);
        Task<IEnumerable<LabelDTO>> GetAll();
        Task<LabelDTO> Create(LabelDTO objDTO);
        Task<LabelDTO> Edit(LabelDTO objDTO);
        Task<int> Delete(int Id);
    }
}
