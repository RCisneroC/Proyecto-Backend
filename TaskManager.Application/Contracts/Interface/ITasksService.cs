using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Features.Command.Tasks.CreateCommand;
using TaskManager.Application.Features.Command.Tasks.DeleteCommand;
using TaskManager.Application.Features.Command.Tasks.UpdateCommand;
using TaskManager.Application.Features.Queries.Tasks.GetTasksFilter;
using TaskManager.Application.Models;
using TaskManager.Domain.Model;

namespace TaskManager.Application.Contracts.Interface
{
    public interface ITasksService
    {
        Task<ResponseServices<TaskM>> CreateTasksAsync(CreateTasksCommand request);
        Task<ResponseServices<TaskM>> DeleteTasksAsync(DeleteTasksCommand request);
        Task<ResponseServices<TaskM>> GetTasksAsync(GetTasksQuery request);

        //Task<ResponseServices<TaskM>> GetTasksByIdAsync(GetTasksByIdQuery request);


        Task<ResponseServices<TaskM>> UpdateTasksAsync(UpdateTasksCommand request);
    }
}
