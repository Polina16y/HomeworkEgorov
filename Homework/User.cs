using System.ComponentModel.DataAnnotations;

namespace Homework
{
    internal class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
