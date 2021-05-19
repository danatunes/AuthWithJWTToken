using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication14
{
    public class Question
    {
        [Key]
        public int? Id_q { get; set; }
        public string Name { get; set; }
        public string Question_N { get; set; }
        public List<string> Answers{get;set;}
        public string Answer_r { get; set; }
    }
}
