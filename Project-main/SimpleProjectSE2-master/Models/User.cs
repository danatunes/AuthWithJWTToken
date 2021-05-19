using SimpleProjectSE2.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication14.Models
{
    
        public class User
        {

            public User()
            {

            }

            public User(UserDto u)
            {
                Name = u.Name;
            }
            public string Name { get; set; }
            [Key]
            public string Username { get; set; }
            public byte[] PasswordHash { get; set; }
            public byte[] PasswordSalt { get; set; }
            public string Role { get; set; }
        
    }
}
