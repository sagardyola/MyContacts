﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyContacts.Business.Repository.IRepository;
using MyContacts.DataAccess;
using MyContacts.DataAccess.Data;
using MyContacts.Models;

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

        public async Task<ContactDetailDTO> Create(ContactDetailDTO objDTO)
        {
            var detail = _mapper.Map<ContactDetailDTO, ContactDetail>(objDTO);

            var addedObj = _db.Add(detail);
            _db.SaveChangesAsync();

            return _mapper.Map<ContactDetail, ContactDetailDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj = await _db.ContactDetails.FirstOrDefaultAsync(x => x.ID == id);
            if (obj != null)
            {
                _db.ContactDetails.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<ContactDetailDTO> Get(string userName)
        {
            var obj = await _db.ContactDetails.FirstOrDefaultAsync(u => u.UserName == userName);
            if (obj != null)
            {
                return _mapper.Map<ContactDetail, ContactDetailDTO>(obj);
            }
            return new ContactDetailDTO();
        }

        public async Task<IEnumerable<ContactDetailDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<ContactDetail>, IEnumerable<ContactDetailDTO>>(_db.ContactDetails);
        }

        public async Task<ContactDetailDTO> Update(ContactDetailDTO objDTO)
        {
            var objFromDb = await _db.ContactDetails.FirstOrDefaultAsync(u => u.ID == objDTO.ID);
            if (objFromDb != null)
            {
                objFromDb.UserName = objDTO.UserName;
                _db.ContactDetails.Update(objFromDb);
                await _db.SaveChangesAsync();
                return _mapper.Map<ContactDetail, ContactDetailDTO>(objFromDb);
            }
            return objDTO;

        }
    }
}