using FluentValidation;
using FluentValidation.Results;
using ToDoApiGraphQl.BusinessRules.Requests;

namespace ToDoApiGraphQl.BusinessRules.Validators
{
    public class TaskValidator : AbstractValidator<UpsertTaskRequest>, ITaskValidator
    {
        public TaskValidator()
        {
            RuleFor(t => t.Title)
                .NotEmpty()
                .NotNull()
                .MinimumLength(1)
                .MaximumLength(100)
                .WithName("Título");

            RuleFor(t => t.Description)
                .MaximumLength(280)
                .WithName("Descrição");
        }
    }
}
