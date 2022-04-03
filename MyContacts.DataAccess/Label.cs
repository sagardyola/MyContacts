using System.ComponentModel.DataAnnotations;

namespace MyContacts.DataAccess
{
    public class Label
    {
        [Key]
        public int Id { get; set; }
        public string LabelName { get; set; }
    }
}
