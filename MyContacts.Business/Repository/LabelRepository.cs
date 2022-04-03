using AutoMapper;
using MyContacts.Business.Repository.IRepository;
using MyContacts.DataAccess;
using MyContacts.DataAccess.Data;
using MyContacts.Models;

namespace MyContacts.Business.Repository
{
    public class LabelRepository : ILabelRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public LabelRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<LabelDTO> Create(LabelDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<LabelDTO> Edit(LabelDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<LabelDTO> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LabelDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Label>, IEnumerable<LabelDTO>>(_db.Labels);
        }
    }
}
