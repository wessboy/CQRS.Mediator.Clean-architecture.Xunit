using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Application.Commands;
using ToDoApp.Application.Queries;

namespace ToDoApp.API.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class ToDoItemController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ToDoItemController(IMediator mediator)
        {
             _mediator = mediator;
        }

    [HttpGet]
     public async Task<IActionResult> Get()
    {
        return Ok(await _mediator.Send(new ToDoItemQuery()));
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateToDoItermCommand command)
    {
        await _mediator.Send(command);
        return Created();

    }

    //end
    }

