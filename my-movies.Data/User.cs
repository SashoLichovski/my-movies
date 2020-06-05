using System.ComponentModel.DataAnnotations;

namespace my_movies.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}