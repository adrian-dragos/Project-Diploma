using Application.DTOs.Instructor;
using Domain.Enums;
using MediatR;

namespace Application.Features.Queries.Instructor
{
    public sealed class GetInstructorListQuery : IRequest<IEnumerable<InstructorProfileDto>>
    { 
        public CarGear GearType { get; set; }
    }
}
