using FluentValidation;
using ToDoApiGraphQl.BusinessRules.Requests;

namespace ToDoApiGraphQl.BusinessRules.Validators
{
    public interface ITaskValidator : IValidator<UpsertTaskRequest>
    {

    }
}
