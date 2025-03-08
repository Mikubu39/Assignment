using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; } // Lưu mật khẩu dưới dạng hash
    }
}
