using CarAPI.Entities.Dtos.Brand;
using CarAPI.Validators.Colors;
using FluentValidation;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CarAPI.Validators.Brands
{
    public class CreateBrandDtoValidators:AbstractValidator<CreateBrandDto>
    {
        public CreateBrandDtoValidators()
        {
            
                RuleFor(p => p.Name)
              .NotEmpty().WithMessage("Description field must not be empty!")
              .NotNull().WithMessage("Description field must not be null!")
              .MaximumLength(100)
              .MinimumLength(3);
            
        }
    }
}
