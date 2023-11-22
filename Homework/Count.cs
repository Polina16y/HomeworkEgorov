using System.ComponentModel.DataAnnotations;

namespace Homework
{
    internal class Count
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public int Score { get; set; }
    }
}