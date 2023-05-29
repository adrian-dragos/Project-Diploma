using Application.Features.Commands.Student;
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
        public async Task<ActionResult<StudentProfileViewModel>> GetStudentProfile(
            int id, 
            CancellationToken cancellation)
        {
            var query = new GetStudentProfileQuery { Id = id };

            var user = await _mediator.Send(query, cancellation);

            var response = _mapper.Map<StudentProfileViewModel>(user);

            return Ok(response);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateStudentProfile(
            int id,
            [FromBody] UpdateStudentProfileViewModel student,
            CancellationToken cancellation)
        { 
        
            var query = _mapper.Map<UpdateStudentProfileCommand>(student);
            query.Id = id;

            await _mediator.Send(query, cancellation);

            return NoContent();
        }
    }
}
