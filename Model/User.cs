using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace webAPiINZ.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
