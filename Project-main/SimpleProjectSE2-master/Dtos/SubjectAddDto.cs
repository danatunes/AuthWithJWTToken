using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProjectSE2.Dtos
{
    public class SubjectAddDto
    {

        [Required]
        public string Name { get; set; }
    }
}
