using Application.Features.Queries.Student;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.ViewModels.Student;

namespace WebApi.Controllers
{
    [Route("api/students")]
    [ApiController]
    public sealed class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public StudentController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StudentProfileViewModel>> GetStudent(int id)
        {
            var query = new GetStudentProfileQuery { Id = id };

            var user = await _mediator.Send(query);

            var response = _mapper.Map<StudentProfileViewModel>(user);

            return Ok(response);
        }
    }
}
