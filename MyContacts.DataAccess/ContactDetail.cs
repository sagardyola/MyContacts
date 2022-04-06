using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyContacts.DataAccess
{
    public class ContactDetail
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Notes { get; set; }
        public string? Image { get; set; }
        public bool IsPublished { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; }

        public int? LabelId { get; set; }
        [ForeignKey("LabelId")]
        public Label? Label { get; set; }

        public ICollection<ContactNumber>? ContactNumbers { get; set; }
    }
}
