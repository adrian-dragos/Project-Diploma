using Application.Features.Queries.Payment;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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

        [HttpGet("{studentId}/list")]

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


        [HttpGet("{studentId}/sum")]

        public async Task<ActionResult<decimal>> GetSumToPay(
            int studentId,
            CancellationToken cancellationToken)
        {
            var query = new GetSumToPayQuery
            {
                StudentId = studentId
            };
            var sum = await _mediator.Send(query, cancellationToken);
            var response = JsonConvert.SerializeObject(sum, new JsonSerializerSettings
            {
                FloatFormatHandling = FloatFormatHandling.DefaultValue 
            });

            return Ok(response);
        }
    }
}
