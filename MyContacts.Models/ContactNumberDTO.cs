using System.ComponentModel.DataAnnotations;

namespace MyContacts.Models
{
    public class ContactNumberDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Number { get; set; }

        //[Required]
        public int? ContactDetailId { get; set; }
    }
}
