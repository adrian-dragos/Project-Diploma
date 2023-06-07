using Application.DTOs.Student;
using MediatR;

namespace Application.Features.Queries.Payment
{
    public sealed class GetStudentListPaymentQuery : IRequest<IEnumerable<StudentShortProfileDto>>
    {
    }
}
