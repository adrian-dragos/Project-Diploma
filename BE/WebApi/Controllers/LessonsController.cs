using Application.DTOs.Paging;
using Application.Features.Queries.Lesson;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.ViewModels.Lesson;
using WebApi.ViewModels.Pagination;

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

        [HttpPost("student/{id}")]
        public async Task<ActionResult<PagedResultViewModel<GetStudentLessonsListViewModel>>> GetStudentLessons(
            int id, 
            [FromBody] PageViewModel pageViewModel,
            CancellationToken cancellationToken)
        {
            var query = new GetStudentLessonsListQuery {
                StudentId = id,
                PageDto = _mapper.Map<PageDto>(pageViewModel)
            };

            var lessons = await _mediator.Send(query, cancellationToken);

            var response = _mapper.Map<PagedResultViewModel<GetStudentLessonsListViewModel>>(lessons);

            return Ok(response);
        }

        [HttpGet("instructor/{id}")]
        public async Task<ActionResult<PagedResultViewModel<GetInstructorLessonsListViewModel>>> GetInstructorLessons(
            int id,
            [FromBody] PageViewModel pageViewModel,
            CancellationToken cancellationToken)
        {
            var query = new GetInstructorLessonsListQuery { 
                InstructorId = id,
                PageDto = _mapper.Map<PageDto>(pageViewModel)
            };

            var lessons = await _mediator.Send(query, cancellationToken);

            var response = _mapper.Map<PagedResultViewModel<GetInstructorLessonsListViewModel>>(lessons);

            return Ok(response);
        }

        [HttpPost("available")]
        public async Task<ActionResult<IEnumerable<GetAvailableLessonsViewModel>>> GetAvailableLessons(
            [FromBody] LessonFilterViewModel filter,
            CancellationToken cancellationToken)
        {
            var query = _mapper.Map<GetAvailableLessonsListQuery>(filter);

            var lessons = await _mediator.Send(query, cancellationToken);

            var response = _mapper.Map<IEnumerable<GetAvailableLessonsViewModel>>(lessons);

            return Ok(response);
        }

    }
}
