using CarAPI.Entities.Dtos.Color;
using FluentValidation;

namespace CarAPI.Validators.Colors
{
    public class CreateColorDtoValidators:AbstractValidator<CreateColorDto>
    {
        public CreateColorDtoValidators()
        {
            RuleFor(p => p.Name)
          .NotEmpty().WithMessage("Description field must not be empty!")
          .NotNull().WithMessage("Description field must not be null!")
          .MaximumLength(100)
          .MinimumLength(3);
        }
       
    }
}
