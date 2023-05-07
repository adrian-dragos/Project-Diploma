using Application.Features.Commands;
using Application.Features.Queries;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.ViewModels.User;

namespace WebApi.Controllers
{
    [Route("api/users")]
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
        public async Task<ActionResult<IEnumerable<UserViewModel>>> GetUsers()
        {
            var query = new GetUserListQuery();

            var users = await _mediator.Send(query);

            var response = _mapper.Map<IEnumerable<UserViewModel>>(users);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserViewModel>> GetUser(int id)
        {
            var query = new GetUserQuery { Id = id };

            var user = await _mediator.Send(query);

            var response = _mapper.Map<UserViewModel>(user);

            return Ok(response);
        }

        [ProducesResponseType(typeof(RegisterUserRequestViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("register")]
        public async Task<ActionResult> RegisterUser(
             [FromBody] RegisterUserRequestViewModel request,
             CancellationToken cancellationToken)
        {
            var command = _mapper.Map<RegisterUserCommand>(request);

            var user = await _mediator.Send(command, cancellationToken);

            var response = _mapper.Map<RegisterUserResponeViewModel>(user);

            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> LoginUser(
            [FromBody] LoginUserRequestViewModel request,
            CancellationToken cancellationToken)
        {
            var command = new LoginUserCommand { Email = request.Email, Password = request.Password };

            var jwtToken = await _mediator.Send(command, cancellationToken);

            return Ok(jwtToken);
        }
    }
}
