
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Contracts.Interface;
using TaskManager.Application.Models;
using TaskManager.Domain.Model;

namespace TaskManager.Application.Features.Command.Tasks.CreateCommand
{
    public class CreateTasksCommandHandlers : IRequestHandler<CreateTasksCommand, ResponseServices<TaskM>>
    {

        private readonly ITasksService _TasksRepository;
        private readonly ILogger<CreateTasksCommandHandlers> _logger;
        public CreateTasksCommandHandlers(ITasksService TasksRepository, ILogger<CreateTasksCommandHandlers> logger)
        {
            _TasksRepository = TasksRepository;
            _logger = logger;
        }
        public async Task<ResponseServices<TaskM>> Handle(CreateTasksCommand request, CancellationToken cancellationToken)
        {


            var result = await _TasksRepository.CreateTasksAsync(request);
            return  result;
        }
    }
}