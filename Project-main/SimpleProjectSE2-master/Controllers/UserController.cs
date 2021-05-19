using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleProjectSE2.Dtos;
using SimpleProjectSE2.Repositories.Interfaces;
using WebApplication14;
using WebApplication14.Models;

namespace SimpleProjectSE2.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // [Authorize(Roles = Role.Teacher)]
        [AllowAnonymous]
        [HttpPost("addSubject")]
        public async Task<ActionResult> AddSubject(SubjectAddDto subjectAdd)
        {
            var subject = new Subject()
            {
                Name = subjectAdd.Name
            };
            if (await _userRepository.AddSubject(subject))
            {
                return Ok("A new subject was added successfully!");
            }

            return BadRequest("Oops, somthing wring happened!");
        }


        [AllowAnonymous]
        [HttpPost("addQuestion")]
        public async Task<ActionResult> AddQuestion(QuestionAddDto questionAdd)
        {
            var question = new Question()
            {
                Name = questionAdd.Name,
                Question_N = questionAdd.Question_N,
                Answers = questionAdd.Answers,
                Answer_r = questionAdd.Answer_r
            };
            if (await _userRepository.AddQuestion(question))
            {
                return Ok("A new subject was added successfully!");
            }

            return BadRequest("Oops, somthing wring happened!");
        }

        [AllowAnonymous]
        [HttpGet]
        public List<Subject> index()
        {
            return _userRepository.mainPage();
        }

        [AllowAnonymous]
        [HttpGet("getTest/{name}")]
        public List<Question> getTest(string name)
        {
           if(name != null)
            {
                return _userRepository.getTest(name);
            }
            return null;           
       }
        [AllowAnonymous]
        [HttpGet("getAnswer/{name}")]
        public List<Question> getAnswer(string name)
        {
            if (name != null)
            {
                return _userRepository.getAnswer(name);
            }
            return null;
        }

        /*        [Authorize(Roles = Role.LeaderOfGroup)]
                [HttpGet]
                public async Task<ActionResult<ICollection<StudentDto>>> GetStudents()
                {
                    IEnumerable<Student> innerStudents = await _studentRepository.GetStudents();
                    ICollection<StudentDto> students = new LinkedList<StudentDto>();

                    foreach (Student s in innerStudents)
                    {
                        students.Add(new StudentDto()
                        {
                            Name = s.Name,
                            Surname = s.Surname,
                            Birthday = s.Birthday,
                            GroupId = s.GroupId
                        });
                    }
                    return Ok(students);
                }*/

        [HttpPost]
        public async Task<ActionResult> AddUser(UserDto u)
        {
            User us = new User(u);
            if (await _userRepository.AddStudent(us))
            {
                return Ok("A new user was added successfully!");
            }

            return BadRequest("Oops, somthing wring happened!");
        }
    }
}
