using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Assessment
    {
        [Key]
        public int AssessmentId { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public string? Subject { get; set; }
        [Required]
        public string? Score { get; set; }
        [Required]
        public DateTime Date { get; set; }

    }
}
