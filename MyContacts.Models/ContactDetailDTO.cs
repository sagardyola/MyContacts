﻿using System.ComponentModel.DataAnnotations;

namespace MyContacts.Models
{
    public class ContactDetailDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the Firstname")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public string Image { get; set; }
        public bool IsPublished { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

        [Range(1, int.MaxValue, ErrorMessage = "Please select a label")]
        public int LabelId { get; set; }
        public LabelDTO Label { get; set; }

        public ICollection<ContactNumberDTO> ContactNumbers { get; set; }
    }
}
