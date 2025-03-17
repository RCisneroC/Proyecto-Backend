
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Models;
using TaskManager.Domain.Model;

namespace TaskManager.Application.Features.Command.Tasks.UpdateCommand
{
    public class UpdateTasksCommand : IRequest<ResponseServices<TaskM>>
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
    }
}