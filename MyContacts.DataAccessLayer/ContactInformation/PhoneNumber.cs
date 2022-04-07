using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyContacts.DataAccessLayer.ContactInformation
{
    public class PhoneNumber
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string ContactNumber { get; set; }

        public int? ContactDetailId { get; set; }
        [ForeignKey("ContactDetailId")]
        public ContactDetail? ContactDetail { get; set; }
    }
}
