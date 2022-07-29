using System.ComponentModel.DataAnnotations;

namespace CommonLayer
{
    public class RegisterModel
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public long MobileNumber { get; set; }
    }
}
