
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Contracts.Interface;
using TaskManager.Application.Features.Command.Tasks.UpdateCommand;
using TaskManager.Application.Models;
using TaskManager.Domain.Model;

namespace Catalog.Application.Features.Command.Tasks.UpdateCommand
{
    public class UpdateTasksCommandHandlers : IRequestHandler<UpdateTasksCommand, ResponseServices<TaskM>>
    {

        private readonly ITasksService _TasksRepository;
        private readonly ILogger<UpdateTasksCommandHandlers> _logger;
        public UpdateTasksCommandHandlers(ITasksService TasksRepository, ILogger<UpdateTasksCommandHandlers> logger)
        {
            _TasksRepository = TasksRepository;
            _logger = logger;
        }
        public async Task<ResponseServices<TaskM>> Handle(UpdateTasksCommand request, CancellationToken cancellationToken)
        {
            var result = await _TasksRepository.UpdateTasksAsync(request);
            return result;
        }
    }
}
