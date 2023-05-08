﻿using Application.Features.Commands;
using Application.Features.Commands.User;
using Application.Features.Queries;
using Application.Features.Queries.User;
using AutoMapper;
using Azure.Core;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading;
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

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost("login")]
        public async Task<ActionResult> LoginUser(
            [FromBody] LoginUserRequestViewModel request,
            CancellationToken cancellationToken)
        {
            var command = new LoginUserCommand { Email = request.Email, Password = request.Password };

            var jwtToken = await _mediator.Send(command, cancellationToken);


            var responeBody = JsonConvert.SerializeObject(new
            {
                token = jwtToken,
            });

            var response = new OkObjectResult(responeBody);

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
    }
}
