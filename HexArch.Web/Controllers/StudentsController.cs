using HexArch.ApplicationCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HexArch.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentReadOnlyRepository _repository;

        public StudentsController(IStudentReadOnlyRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult List()
        {
            var result = _repository.GetAll();
            return Ok(result);
        }
    }
}
