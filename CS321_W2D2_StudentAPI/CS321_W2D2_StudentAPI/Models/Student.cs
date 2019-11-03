using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Just addded this
using System.Linq;
using System.Threading.Tasks;

namespace CS321_W2D2_StudentAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "FistName cannot be empty")]
        
        public string FirstName { get; set; }
        [Required]
        [MaxLength(75, ErrorMessage = "FirstName cannot be more than 75 char")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(75, ErrorMessage = "FirstName cannot be more than 75 char")]
        public DateTime BirthDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string Email { get; set; }
        [Required]
        [EmailAddress]
        public string Phone { get; set; }
        [Required]
        [Phone]

    }
}
