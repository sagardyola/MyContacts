using AutoMapper;
using MyContacts.DataAccess;
using MyContacts.Models;

namespace MyContacts.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ContactDetail, ContactDetailDTO>().ReverseMap();
        }
    }
}