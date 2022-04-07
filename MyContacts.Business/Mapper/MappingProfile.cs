using AutoMapper;
using MyContacts.DataAccessLayer.ContactInformation;
using MyContacts.Models.ContactInformationDTO;

namespace MyContacts.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ContactDetail, ContactDetailDTO>().ReverseMap();
            CreateMap<Label, LabelDTO>().ReverseMap();
            CreateMap<PhoneNumber, PhoneNumberDTO>().ReverseMap();
        }
    }
}