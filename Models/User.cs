using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PixelPort.Components.Models
{
    [Table("Users")] 
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Username { get; set; } = "";

        public string PasswordHash { get; set; } = "";

        public bool IsAdmin { get; set; }
    }
}
