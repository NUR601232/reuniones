using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Restaurant.Inventory.Application.UseCases.Reunion.Command.CrearReunion;
using Restaurant.Inventory.Application.UseCases.Reunion.Command.InvitarUsuario;
using Restaurant.Inventory.Application.UseCases.Reunion.Command.ResponderInvitacion;
namespace Restaurant.Inventory.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class ReunionController : Controller
    {
        private readonly IMediator _mediator;
        public ReunionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        
        [HttpPost]
        public async Task<IActionResult> CreateReunion([FromBody] CrearReunionCommand command)
        {
            var itemId = await _mediator.Send(command);


            return Ok(itemId);
        }

        

        [Route("invitar")]
        [HttpPost]
        public async Task<IActionResult> InvitarUsuario([FromBody] InvitarUsuarioCommand command)
        {
            var itemId = await _mediator.Send(command);

            return Ok(itemId);
        }

        [Route("responder")]
        [HttpPost]
        public async Task<IActionResult> ResponderInvitacion([FromBody] ResponderInvitacionCommand command)
        {
            var itemId = await _mediator.Send(command);

            return Ok(itemId);
        }


    }
}

