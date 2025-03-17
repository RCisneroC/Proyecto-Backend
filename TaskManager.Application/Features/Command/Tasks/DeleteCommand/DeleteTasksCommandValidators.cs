
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Features.Command.Tasks.DeleteCommand;

namespace TaskManager.Application.Features.Command.Tasks.DeleteCommand
{
    public class DeleteTasksCommandValidators : AbstractValidator<DeleteTasksCommand>
    {
        public DeleteTasksCommandValidators()
        {
                    RuleFor(x => x.Id)
        .NotEmpty()
        .WithMessage("El id es obligatorio.")
        .GreaterThan(0)
        .WithMessage("El ID debe ser mayor a 0.");
        }
    }
}
