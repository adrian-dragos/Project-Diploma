﻿using Application.Features.Commands.Payment;
using Application.Features.Queries.Payment;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApi.ViewModels.Payment;
using WebApi.ViewModels.Student;

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

        [HttpPost("list")]

        public async Task<ActionResult<IEnumerable<GetStudentPaymentViewModel>>> GetStudentPayments(
            [FromBody] GetStudentPaymentFilterViewModel filter,
            CancellationToken cancellationToken)
        {
            var query = _mapper.Map<GetStudentPaymentListQuery>(filter);
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


        [HttpGet("student/list/short")]

        public async Task<ActionResult<IEnumerable<StudentShortProfileViewModel>>> GetStudentListPayment (
            CancellationToken cancellationToken)
        {
            var query = new GetStudentListPaymentQuery();

            var studentList = await _mediator.Send(query, cancellationToken);
            var response = _mapper.Map<IEnumerable<StudentShortProfileViewModel>>(studentList);
            return Ok(response);
        }


        [HttpPatch("pay")]

        public async Task<ActionResult> Pay(
            [FromBody] PayLessonsViewModel payLessonViewModel,
            CancellationToken cancellationToken)
        {
            var query = _mapper.Map<PayLessonsCommand>(payLessonViewModel);
            await _mediator.Send(query, cancellationToken);

            return NoContent();
        }

    }
}
