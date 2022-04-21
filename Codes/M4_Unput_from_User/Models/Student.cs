using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace M4_Unput_from_User.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Please Fill the Name")] //checks if null or not 
        [StringLength(20,ErrorMessage ="Name must not exceed 50")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^\d{2}-\d{5}-\d{1}$",ErrorMessage ="Id Must follow XX-XXXXX-X")]
        public string Id { get; set; }
        [Required]
        public string Dob { get; set; }
        [Required]
        public string Email { get; set; }
    }
}