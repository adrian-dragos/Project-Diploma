using Application.Features.Queries;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.ViewModels.User;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UsersController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserViewModel>>> GetCars()
        {
            var query = new GetUserListQuery();

            var users = await _mediator.Send(query);

            var result = _mapper.Map<IEnumerable<UserViewModel>>(users);

            return Ok(result);
        }




    }
}
