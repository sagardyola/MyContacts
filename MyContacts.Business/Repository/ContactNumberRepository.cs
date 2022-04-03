using AutoMapper;
using MyContacts.Business.Repository.IRepository;
using MyContacts.DataAccess;
using MyContacts.DataAccess.Data;
using MyContacts.Models;

namespace MyContacts.Business.Repository
{
    public class ContactNumberRepository : IContactNumberRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public ContactNumberRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<ContactNumberDTO> Create(ContactNumberDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<ContactNumberDTO> Edit(ContactNumberDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<ContactNumberDTO> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ContactNumberDTO>> GetAll(int? Id = null)
        {
            if (Id != null && Id > 0)
            {
                return _mapper.Map<IEnumerable<ContactNumber>, IEnumerable<ContactNumberDTO>>
                    (_db.ContactNumbers.Where(u => u.Id == Id));
            }
            else
            {
                return _mapper.Map<IEnumerable<ContactNumber>, IEnumerable<ContactNumberDTO>>(_db.ContactNumbers);
            }
        }
    }
}
