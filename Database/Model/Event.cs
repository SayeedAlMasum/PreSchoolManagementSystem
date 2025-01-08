using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        [Required]
        public string? EventName { get; set; }
        [Required]
        public DateTime EventDate { get; set; } = DateTime.Now;
        [Required]
        public string? Description { get; set; }
    }
}
