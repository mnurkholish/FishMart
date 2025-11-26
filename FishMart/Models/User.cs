using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishMart.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Username { get; set; }
        public string NoTelp { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public string StatusText => IsActive ? "Aktif" : "Nonaktif";
    }
}
