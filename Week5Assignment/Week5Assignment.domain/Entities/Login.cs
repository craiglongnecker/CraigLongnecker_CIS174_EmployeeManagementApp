using System.ComponentModel.DataAnnotations;

namespace Week5Assignment.domain.Entities
{
    public class Login
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
