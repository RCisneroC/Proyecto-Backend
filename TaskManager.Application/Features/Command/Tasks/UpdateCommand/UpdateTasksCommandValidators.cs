
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Features.Command.Tasks.UpdateCommand;

namespace Catalog.Application.Features.Command.WorkSituation.UpdateCommand
{
    public class UpdateTasksCommandValidators : AbstractValidator<UpdateTasksCommand>
    {
        public UpdateTasksCommandValidators()
        {

            RuleFor(task => task.Id)
           .GreaterThan(0).WithMessage("El ID debe ser mayor que 0.");

            RuleFor(task => task.Title)
               .NotEmpty().WithMessage("El título es obligatorio.")
               .MaximumLength(100).WithMessage("El título no puede exceder los 100 caracteres.");


            RuleFor(task => task.Description)
                .MaximumLength(500).WithMessage("La descripción no puede exceder los 500 caracteres.");
        }
    }
}
