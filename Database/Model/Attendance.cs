using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    internal class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string? Status { get; set; }
    }
}
