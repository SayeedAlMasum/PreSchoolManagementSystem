using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    internal class Class
    {
        [Key]
        public int ClassId { get; set; }
        [Required]
        public string? ClassName { get; set; }
        [Required]
        public string? Schedule { get; set; }
    }

}
