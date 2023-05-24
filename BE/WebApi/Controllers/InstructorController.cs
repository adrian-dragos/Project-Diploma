using Application.Features.Queries.Instructor;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.ViewModels.Instructor;

namespace WebApi.Controllers
{
    [Route("api/instructors")]
    [ApiController]
    public sealed class InstructorController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public InstructorController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InstructorProfileViewModel>>> GetInstructors()
        {
            var query = new GetInstructorListQuery();

            var instructors = await _mediator.Send(query);

            var response = _mapper.Map<IEnumerable<InstructorProfileViewModel>>(instructors);

            return Ok(response);
        }
    }
}
