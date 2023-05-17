using Application.Features.Queries.Lesson;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.ViewModels.Lesson;

namespace WebApi.Controllers
{
    [Route("api/lessons")]
    [ApiController]
    public sealed class LessonsController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public LessonsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet("{studentId}")]
        public async Task<ActionResult<IEnumerable<GetStudentLessonsListViewModel>>> GetStudentLessons(int studentId)
        {
            var query = new GetStudentLessonsListQuery { StudentId = studentId};

            var lessons = await _mediator.Send(query);

            var response = _mapper.Map<IEnumerable<GetStudentLessonsListViewModel>>(lessons);

            return Ok(response);
        }

    }
}
