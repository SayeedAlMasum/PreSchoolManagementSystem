using System.ComponentModel.DataAnnotations;

namespace Database.Model
{
    public class UserInfo : BaseModel
    {
        [Key]
        public string UserInfoId { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? PasswordHash { get; set; }
        [Required]
        public string? Location { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public int RoleId { get; set; }



    }

}