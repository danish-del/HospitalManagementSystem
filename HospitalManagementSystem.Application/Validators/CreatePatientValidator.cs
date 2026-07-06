using FluentValidation;
using HospitalManagementSystem.Application.Dto.Patient;

namespace HospitalManagementSystem.Application.Validators
{
    public class CreatePatientValidator : AbstractValidator<CreatePatientDto>
    {
        public CreatePatientValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Address).NotEmpty();

            RuleFor(x => x.Gender).NotEmpty()
                .Must(x => x != null &&
                (x.ToLower()== "male" || x.ToLower() == "female" || x.ToLower() == "other"));
            RuleFor(x => x.Age)
                .GreaterThan(0).
                LessThan(120);
        }

    }
}
