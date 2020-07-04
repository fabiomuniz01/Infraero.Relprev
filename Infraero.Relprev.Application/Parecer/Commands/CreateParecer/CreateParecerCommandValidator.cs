using FluentValidation;
using Infraero.Relprev.Application.Parecer.Commands.CreateParecer;

namespace Infraero.Relprev.Application.Local.Commands.CreateLocal
{
    public class CreateParecerCommandValidator : AbstractValidator<CreateParecerCommand>
    {
        public CreateParecerCommandValidator()
        {
            
        }
    }
}
