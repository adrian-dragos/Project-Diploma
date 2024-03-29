﻿using Domain.Enums;
using MediatR;

namespace Application.Features.Commands.Student
{
    public sealed class UpdateStudentProfileCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public CarGear CarGear { get; set; }
        public DateTime Birthday { get; set; }
    }
}
