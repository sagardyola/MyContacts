using AutoMapper;
using MyContacts.Business.Repository.IRepository;
using MyContacts.DataAccessLayer.ContactInformation;
using MyContacts.DataAccessLayer.DataAccess;
using MyContacts.Models.ContactInformationDTO;

namespace MyContacts.Business.Repository
{
    public class PhoneNumberRepository : IPhoneNumberRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public PhoneNumberRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<PhoneNumberDTO> Create(PhoneNumberDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<PhoneNumberDTO> Edit(PhoneNumberDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<PhoneNumberDTO> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PhoneNumberDTO>> GetAll(int? Id = null)
        {
            if (Id != null && Id > 0)
            {
                return _mapper.Map<IEnumerable<PhoneNumber>, IEnumerable<PhoneNumberDTO>>
                    (_db.PhoneNumbers.Where(u => u.Id == Id));
            }
            else
            {
                return _mapper.Map<IEnumerable<PhoneNumber>, IEnumerable<PhoneNumberDTO>>(_db.PhoneNumbers);
            }
        }
    }
}
