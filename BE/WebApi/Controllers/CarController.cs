using Application.Features.Queries.Cars;
using AutoMapper;
using Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.ViewModels.Car;

namespace WebApi.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public sealed class CarController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CarController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        [HttpPost("models")]
        public async Task<ActionResult<IEnumerable<CarModelViewModel>>> GetCarModels(
            [FromBody] CarGear carGear,
            CancellationToken cancellationToken)
        {
            var query = new GetCarModelListQuery { CarGear = carGear};

            var carModels = await _mediator.Send(query, cancellationToken);

            var response = _mapper.Map<IEnumerable<CarModelViewModel>>(carModels);

            return Ok(response);
        }

    }
}
