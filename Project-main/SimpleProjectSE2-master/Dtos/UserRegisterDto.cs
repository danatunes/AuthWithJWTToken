using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProjectSE2.Dtos
{
    public class UserRegisterDto
    {
        public string Name { get; set; }
        public string Role { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "Password length must be between 8 and 15")]
        public string Password { get; set; }
    }
}
