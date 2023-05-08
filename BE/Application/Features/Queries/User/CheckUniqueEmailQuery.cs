using MediatR;

namespace Application.Features.Queries.User
{
    public class CheckUniqueEmailQuery : IRequest<bool>
    {
        public string Email { get; set; }
    }
}
