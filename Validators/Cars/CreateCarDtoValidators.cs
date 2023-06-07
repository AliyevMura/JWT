using CarAPI.Entities.Dtos.Car;
using FluentValidation;

namespace CarAPI.Validators.Cars
{
    public class CreateCarDtoValidators: AbstractValidator<CreateCarDto>
    {
        public CreateCarDtoValidators()
        {
            RuleFor(p => p.Description)
           .NotEmpty().WithMessage("Description field must not be empty!")
           .NotNull().WithMessage("Description field must not be null!")
           .MaximumLength(100)
           .MinimumLength(3)
      
           .Must(MustBeStartWithA).WithMessage("Product name must be start 'A'");
            RuleFor(p => p.DailyPrice).NotNull().GreaterThanOrEqualTo(100).LessThanOrEqualTo(10000);
                RuleFor(p => p.ModelYear).NotNull().GreaterThanOrEqualTo(2000).LessThanOrEqualTo(2023); 

        }
        public bool MustBeStartWithA(string name)
        {
            return name.StartsWith('A');
        
        }
    }
}
