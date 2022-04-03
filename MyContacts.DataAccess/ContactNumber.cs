using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyContacts.DataAccess
{
    public class ContactNumber
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Number { get; set; }

        public int ContactDetailId { get; set; }
        [ForeignKey("ContactDetailId")]
        public ContactDetail ContactDetail { get; set; }
    }
}
