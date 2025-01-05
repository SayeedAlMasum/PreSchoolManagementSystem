using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    internal class ParentGuardian
    {
        [Key]
        public int ParentId { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? ContactInfo { get; set; }
        [Required]  
        public string? RelationshipToStudent { get; set; }
    }
}
