using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishMart.Models
{
    public class Akun
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string NoTelp { get; set; }
        public bool IsAdmin { get; set; }
    }
}
