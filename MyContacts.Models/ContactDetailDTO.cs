using System.ComponentModel.DataAnnotations;

namespace MyContacts.Models
{
    public class ContactDetailDTO
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter the Username")]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Notes { get; set; }
        public bool IsPublished { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
