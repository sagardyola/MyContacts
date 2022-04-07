using System.ComponentModel.DataAnnotations;

namespace MyContacts.DataAccessLayer.ContactInformation
{
    public class Label
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
