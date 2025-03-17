
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Models;
using TaskManager.Domain.Model;

namespace TaskManager.Application.Features.Queries.Tasks.GetTasksFilter
{
    public class GetTasksQuery : IRequest<ResponseServices<TaskM>>
    {

    }
}
