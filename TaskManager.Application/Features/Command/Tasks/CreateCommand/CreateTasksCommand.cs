
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Models;
using TaskManager.Domain.Model;

namespace TaskManager.Application.Features.Command.Tasks.CreateCommand
{
    public class CreateTasksCommand : IRequest<ResponseServices<TaskM>>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }

    }
}
