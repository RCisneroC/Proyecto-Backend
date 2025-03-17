
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

namespace TaskManager.Application.Features.Queries.Tasks.GetTasksFilter
{
    public class GetTasksQueryHandler : IRequestHandler<GetTasksQuery, ResponseServices<TaskM>>
    {

        private readonly ITasksService _TasksRepository;
        private readonly ILogger<GetTasksQueryHandler> _logger;
        public GetTasksQueryHandler(ITasksService TasksRepository)
        {
            _TasksRepository = TasksRepository;
        }

        public async Task<ResponseServices<TaskM>> Handle(GetTasksQuery request, CancellationToken cancellationToken)
        {
            var data = await _TasksRepository.GetTasksAsync(request);
                   return data;
        }

  

    }
}

