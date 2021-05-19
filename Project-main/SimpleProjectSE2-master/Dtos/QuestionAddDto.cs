using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProjectSE2.Dtos
{
    public class QuestionAddDto
    {
        public string Name { get; set; }
        public string Question_N { get; set; }
        public List<string> Answers { get; set; }
        public string Answer_r { get; set; }
    }
}
