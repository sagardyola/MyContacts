using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyContacts.Business.Repository.IRepository;
using MyContacts.DataAccessLayer.ContactInformation;
using MyContacts.DataAccessLayer.DataAccess;
using MyContacts.Models.ContactInformationDTO;

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
            var detail = _mapper.Map<LabelDTO, Label>(objDTO);

            var addedObj = _db.Labels.Add(detail);
            await _db.SaveChangesAsync();

            return _mapper.Map<Label, LabelDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int Id)
        {
            var obj = await _db.Labels.FirstOrDefaultAsync(x => x.Id == Id);
            if (obj != null)
            {
                _db.Labels.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<LabelDTO> Edit(LabelDTO objDTO)
        {
            var objFromDb = await _db.Labels.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = objDTO.Title;

                _db.Labels.Update(objFromDb);
                await _db.SaveChangesAsync();

                return _mapper.Map<Label, LabelDTO>(objFromDb);
            }
            return objDTO;
        }

        public async Task<LabelDTO> Get(int Id)
        {
            var obj = await _db.Labels.FirstOrDefaultAsync(u => u.Id == Id);
            if (obj != null)
            {
                return _mapper.Map<Label, LabelDTO>(obj);
            }
            return new LabelDTO();
        }

        public async Task<IEnumerable<LabelDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Label>, IEnumerable<LabelDTO>>(_db.Labels);
        }
    }
}
