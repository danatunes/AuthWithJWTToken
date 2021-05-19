using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication14
{
    public class Subject
    {
        public Subject()
        {

        }
        public Subject( string s)
        {
            Name = s;
        }

      
        [Key]
        public string Name { get; set; }
    }
}
