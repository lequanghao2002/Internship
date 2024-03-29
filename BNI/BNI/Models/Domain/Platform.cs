﻿using System.ComponentModel.DataAnnotations;

namespace BNI.Models.Domain
{
    public class Platform
    {
        [Key]
        public int Platform_Id { get; set; }
        [Required(ErrorMessage = "Vui lòng điền tên lĩnh vực.")]
        public string Name { get; set; }
        public List<Contact> Contacts { get; set;}
    }
}
