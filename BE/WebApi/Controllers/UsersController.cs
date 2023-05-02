using Application.DTOs.Login;
using Application.Features.Commands;
using Application.Features.Queries;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.ViewModels;
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

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<List<UserViewModel>>> GetUsers()
        {
            var query = new GetUserListQuery();

            var users = await _mediator.Send(query);

            var result = _mapper.Map<IEnumerable<UserViewModel>>(users);

            return Ok(result);
        }


        // TODO: register endpoint
        //[HttpPost]
        //public async Task<ActionResult> RegisterUser(
        //    [FromBody] RegisterRequestViewModel request,
        //    CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        [HttpPost("login")]
        public async Task<ActionResult<string>> LoginUser(
            [FromBody] LoginRequestViewModel request,
            CancellationToken cancellationToken)
        {
            var command = new LoginCommand { Email = request.Email, Password = request.Password };

            var jwtToken = await _mediator.Send(command, cancellationToken);

            return Ok(jwtToken);
        }
    }
}
