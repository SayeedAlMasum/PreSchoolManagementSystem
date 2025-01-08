using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public DateOnly DateOfBirth { get; set; }
        [Required]
        public string? Gender   { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? ParentGuardianInfo { get; set; }
        [Required]
        public DateOnly EnrollmentDate { get; set; }
        [Required]
        public int ClassId { get; set; }
    }
}
