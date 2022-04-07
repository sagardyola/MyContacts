using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyContacts.Business.Repository.IRepository;
using MyContacts.DataAccessLayer.ContactInformation;
using MyContacts.DataAccessLayer.DataAccess;
using MyContacts.Models.ContactInformationDTO;

namespace MyContacts.Business.Repository
{
    public class ContactDetailRepository : IContactDetailRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public ContactDetailRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ContactDetailDTO> Get(int Id)
        {
            var obj = await _db.ContactDetails.FirstOrDefaultAsync(u => u.Id == Id);
            if (obj != null)
            {
                return _mapper.Map<ContactDetail, ContactDetailDTO>(obj);
            }
            return new ContactDetailDTO();
        }

        public async Task<IEnumerable<ContactDetailDTO>> GetAll()
        {
            /*
            var obj = await _db.ContactDetails.Include(x => x.Label).ToListAsync();
            //.Include(x => x.ContactNumbers).ToListAsync();
            return _mapper.Map<List<ContactDetail>, List<ContactDetailDTO>>(obj);
            */

            return _mapper.Map<IEnumerable<ContactDetail>, IEnumerable<ContactDetailDTO>>(_db.ContactDetails.Include(x => x.Label).Include(x => x.PhoneNumbers));
        }

        public async Task<ContactDetailDTO> Create(ContactDetailDTO objDTO)
        {
            var detail = _mapper.Map<ContactDetailDTO, ContactDetail>(objDTO);

            var addedObj = _db.ContactDetails.Add(detail);
            await _db.SaveChangesAsync();

            return _mapper.Map<ContactDetail, ContactDetailDTO>(addedObj.Entity);
        }

        public async Task<ContactDetailDTO> Edit(ContactDetailDTO objDTO)
        {
            var objFromDb = await _db.ContactDetails.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
            if (objFromDb != null)
            {
                objFromDb.FirstName = objDTO.FirstName;
                objFromDb.LastName = objDTO.LastName;
                objFromDb.Address = objDTO.Address;
                objFromDb.Notes = objDTO.Notes;

                _db.ContactDetails.Update(objFromDb);
                await _db.SaveChangesAsync();

                return _mapper.Map<ContactDetail, ContactDetailDTO>(objFromDb);
            }
            return objDTO;
        }

        public async Task<int> Delete(int Id)
        {
            var obj = await _db.ContactDetails.Include(x => x.PhoneNumbers).FirstOrDefaultAsync(x => x.Id == Id);
            if (obj != null)
            {
                _db.ContactDetails.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }
    }
}
