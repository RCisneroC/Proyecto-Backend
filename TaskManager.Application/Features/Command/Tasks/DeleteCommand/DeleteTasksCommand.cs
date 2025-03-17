
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Models;
using TaskManager.Domain.Model;

namespace TaskManager.Application.Features.Command.Tasks.DeleteCommand
{
    public class DeleteTasksCommand : IRequest<ResponseServices<TaskM>>
    {
        public int Id { get; set; } = 0;
    }
}
