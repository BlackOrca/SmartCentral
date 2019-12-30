using FluentValidation;
using SmartCentral.Contracts.V1.Requests;

namespace SmartCentral.Validators
{
    public class CreateTagRequestValidator : AbstractValidator<CreateTagRequest>
    {
        public CreateTagRequestValidator()
        {
            RuleFor(x => x.TagName)
                .NotEmpty()
                .Matches("^[a-zA-Z0-9 ]*$");
        }
    }
}