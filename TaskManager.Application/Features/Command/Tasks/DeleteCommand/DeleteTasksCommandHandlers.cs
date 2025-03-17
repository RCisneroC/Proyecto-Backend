
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Contracts.Interface;
using TaskManager.Application.Features.Command.Tasks.DeleteCommand;
using TaskManager.Application.Models;
using TaskManager.Domain.Model;

namespace TaskManager.Application.Features.Command.Tasks.DeleteCommand
{
    public class DeleteTasksCommandHandlers : IRequestHandler<DeleteTasksCommand, ResponseServices<TaskM>>
    {

        private readonly ITasksService _TasksRepository;
        private readonly ILogger<DeleteTasksCommandHandlers> _logger;
        public DeleteTasksCommandHandlers(ITasksService TasksRepository, ILogger<DeleteTasksCommandHandlers> logger)
        {
            _TasksRepository = TasksRepository;
            _logger = logger;
        }
        public async Task<ResponseServices<TaskM>> Handle(DeleteTasksCommand request, CancellationToken cancellationToken)
        {
            var result = await _TasksRepository.DeleteTasksAsync(request);
            return result;
        }
    }
}