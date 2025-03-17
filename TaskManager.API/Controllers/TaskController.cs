using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using TaskManager.Application.Features.Command.Tasks.CreateCommand;
using TaskManager.Application.Features.Command.Tasks.DeleteCommand;
using TaskManager.Application.Features.Command.Tasks.UpdateCommand;
using TaskManager.Application.Features.Queries.Tasks.GetTasksFilter;
using TaskManager.Application.Models;
using TaskManager.Domain.Model;
using TaskManager.Infrastructure;

namespace TaskManager.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly TaskManagerDbContext _context;

       
        public TaskController(IMediator mediator, TaskManagerDbContext context)
        {
            _mediator = mediator;
            _context= context;
        }


        [HttpDelete("DeleteTask")]
        public async Task<ActionResult<ResponseServices<TaskM>>> DeleteTask([FromQuery] DeleteTasksCommand command)
        {
            return (ActionResult<ResponseServices<TaskM>>)await _mediator.Send(command);

        }

        [HttpPost("CreateTask")]

        public async Task<ActionResult<ResponseServices<TaskM>>> CreateTask([FromBody] CreateTasksCommand command)
        {

        
            return (ActionResult<ResponseServices<TaskM>>)await _mediator.Send(command);

        }




        [HttpPut("UpdateTask")]
        public async Task<ActionResult<ResponseServices<TaskM>>> UpdateTask([FromBody] UpdateTasksCommand command)
        {
            return (ActionResult<ResponseServices<TaskM>>)await _mediator.Send(command);

        }

        [HttpGet("GetTasks")]
        public async Task<ActionResult<ResponseServices<TaskM>>> GetTask([FromQuery] GetTasksQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);


        }

     

    }
}