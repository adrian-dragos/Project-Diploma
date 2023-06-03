using Application.Features.Queries.Payment;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.ViewModels.Payment;

namespace WebApi.Controllers
{
    [Route("api/payments")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public PaymentController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet("{studentId}")]

        public async Task<ActionResult<IEnumerable<GetStudentPaymentViewModel>>> GetStudentPayments(
            int studentId,
            CancellationToken cancellationToken)
        {
            var query = new GetStudentPaymentListQuery
            {
                StudentId = studentId
            };
            var payments = await _mediator.Send(query, cancellationToken);
            var response = _mapper.Map<List<GetStudentPaymentViewModel>>(payments);
            return Ok(response);
        }
    }
}
