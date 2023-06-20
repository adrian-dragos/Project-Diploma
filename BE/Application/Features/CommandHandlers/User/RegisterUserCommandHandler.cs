using Application.DTOs.User;
using Application.Features.Commands.User;
using Application.Features.Services.Interfaces;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Application.Features.CommandHandlers
{
    internal sealed class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, RegisterUserDto>
    {
        private readonly IRepository<Identity> _userReposiotry;
        private readonly IRepository<Student> _studentReposiotry;
        private readonly IPasswordService _passwordService;
        private readonly IMapper _mapper;

        public RegisterUserCommandHandler(IRepository<Identity> userReposiotry, IRepository<Student> studentReposiotry, IPasswordService passwordService, IMapper mapper)
        {
            _userReposiotry = userReposiotry;
            _studentReposiotry = studentReposiotry;
            _passwordService = passwordService;
            _mapper = mapper;
        }

        public async Task<RegisterUserDto> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            await ValidateEmail(request.Email);
            ValidatePassword(request.Password);

            var password = _passwordService.EncryptPassword(request.Password);
            var user = new Identity { Email = request.Email, Password = password, RoleId = 3, CreatedBy = request.Email};

            user = await _userReposiotry
                .AddAsync(user);

            await _studentReposiotry.AddAsync(new Student
            {
                CreatedBy = request.Email,
                IdentityId = user.Id,
                GearType = CarGear.Manual
            });

            return _mapper.Map<RegisterUserDto>(user);
        }

        private async Task ValidateEmail(string email)
        {
            var emailAlreadyRegistred = await _userReposiotry
                .Read()
                .AnyAsync(u => u.Email == email);

            if (emailAlreadyRegistred)
            {
                throw new BadRequestException("Email already in use!");
            }
        }

        private void ValidatePassword(string password)
        {
            if (password.Length <  8)
            {
                throw new BadRequestException("Password is too short!");
            }

            bool containsDigits = Regex.IsMatch(password, @"\d");
            if (!containsDigits)
            {
                throw new BadRequestException("Password should contain at least one digit!");
            }

            bool containsCapitalLetter = Regex.IsMatch(password, @"[A-Z]");
            if (!containsCapitalLetter)
            {
                throw new BadRequestException("Password should contain at least one capital letter!");
            }

            bool containsSmallCaseLetter = Regex.IsMatch(password, @"[a-z]");
            if (!containsSmallCaseLetter)
            {
                throw new BadRequestException("Password should contain at least one small case letter!");
            }
        }
    }
}
