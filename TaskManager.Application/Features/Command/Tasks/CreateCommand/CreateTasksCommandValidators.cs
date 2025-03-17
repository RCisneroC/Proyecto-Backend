

using FluentValidation;
using TaskManager.Application.Features.Command.Tasks.CreateCommand;

namespace TaskManager.Application.Features.Command.WorkSituation.CreateCommand
{
    public class CreateTasksCommandValidators : AbstractValidator<CreateTasksCommand>
    {
        public CreateTasksCommandValidators()
        {
           

            RuleFor(task => task.Title)
               .NotEmpty().WithMessage("El título es obligatorio.")
               .MaximumLength(100).WithMessage("El título no puede exceder los 100 caracteres.");


            RuleFor(task => task.Description)
                .MaximumLength(500).WithMessage("La descripción no puede exceder los 500 caracteres.");
        }
    }
}