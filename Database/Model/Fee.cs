using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    internal class Fee
    {
        [Key]
        public int FeeId { get; set;}
        [Required]
        public int StudentId { get; set;}
        [Required]
        public int Amount { get; set;}
        [Required]
        public DateTime DueDate { get; set;} = DateTime.Now;
        [Required]
        public int PaymentStatus { get; set;}
    }
}
