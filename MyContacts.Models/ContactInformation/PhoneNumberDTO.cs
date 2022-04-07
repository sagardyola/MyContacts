using System.ComponentModel.DataAnnotations;

namespace MyContacts.Models.ContactInformationDTO
{
    public class PhoneNumberDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ContactNumber { get; set; }

        //[Required]
        public int? ContactDetailId { get; set; }
    }
}
