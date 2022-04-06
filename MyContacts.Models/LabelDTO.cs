using System.ComponentModel.DataAnnotations;

namespace MyContacts.Models
{
    public class LabelDTO
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Please enter the Label name")]
        public string LabelName { get; set; }

    }
}
