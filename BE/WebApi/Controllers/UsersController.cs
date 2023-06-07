using Application.Features.Commands.User;
using Application.Features.Queries.User;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.ViewModels.User;

namespace WebApi.Controllers
{
    [Route("api/user")]
    [ApiController]
    public sealed class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UsersController(IMediator mediator, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _mediator = mediator;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        [Authorize]
        [HttpGet("profile/short")]
        public async Task<ActionResult<GetUserProfileShortViewModel>> GetUserShortProfile(
            CancellationToken cancellationToken)
        {
            var httpContext = _httpContextAccessor.HttpContext;
            var id = httpContext.User
                .Claims
                .FirstOrDefault(x => x.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?
                .Value;

            if (id is null)
            {

                return StatusCode(500, "An internal server error occurred.");
            }


            var query = new GetUserProfileShortQuery
            {
                Id = Int32.Parse(id)
            };

            var users = await _mediator.Send(query, cancellationToken);

            var response = _mapper.Map<GetUserProfileShortViewModel>(users);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserViewModel>> GetUser(
            int id,
            CancellationToken cancellationToken)
        {
            var query = new GetUserQuery { Id = id };

            var user = await _mediator.Send(query, cancellationToken);

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

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost("login")]
        public async Task<ActionResult<UserTokenViewModel>> LoginUser(
            [FromBody] LoginUserRequestViewModel request,
            CancellationToken cancellationToken)
        {
            var command = new LoginUserCommand { Email = request.Email, Password = request.Password };

            var jwtToken = await _mediator.Send(command, cancellationToken);

            var response = new UserTokenViewModel
            {
                JwtToken = jwtToken,
            };

            return Ok(response);
        }

        [HttpGet("{email}/unique")]
        public async Task<ActionResult<bool>> CheckEmailIsUnique(
            string email,
            CancellationToken cancellationToken)
        {
            var query = new CheckUniqueEmailQuery { Email = email };

            var response = await _mediator.Send(query, cancellationToken);

            return Ok(response);
        }

        [Authorize]
        [ProducesResponseType(typeof(GetUserDetailsViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(GetUserDetailsViewModel), StatusCodes.Status500InternalServerError)]
        [HttpGet("details")]
        public async Task<ActionResult<GetUserDetailsViewModel>> GetUserDetails( CancellationToken cancellationToken)
        {
            var httpContext = _httpContextAccessor.HttpContext;
            var id = httpContext.User
                .Claims
                .FirstOrDefault(x => x.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?
                .Value;

            if (id is null)
            {

                return StatusCode(500, "An internal server error occurred.");
            }


            var query = new GetUserDetailsQuery
            {
                Id = Int32.Parse(id)
            };

            var user = await _mediator.Send(query, cancellationToken);
            var response = _mapper.Map<GetUserDetailsViewModel>(user);
            return Ok(response);
        }
    }
}
