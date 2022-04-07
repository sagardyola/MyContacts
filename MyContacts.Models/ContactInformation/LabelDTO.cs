using System.ComponentModel.DataAnnotations;

namespace MyContacts.Models.ContactInformationDTO
{
    public class LabelDTO
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Please enter the Label name")]
        public string Title { get; set; }
    }
}
