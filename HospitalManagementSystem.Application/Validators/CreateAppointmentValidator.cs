using FluentValidation;
using HospitalManagementSystem.Application.Dto.Appointment;

namespace HospitalManagementSystem.Application.Validators
{
    public class CreateAppointmentValidator : AbstractValidator<CreateAppointmentDto>
    {
        public CreateAppointmentValidator()
        {
            RuleFor(x => x.PatientId).GreaterThan(0)
                .WithMessage("PatientId must be greater than 0");
            RuleFor(x => x.DoctorId).GreaterThan(0)
                .WithMessage("DoctorId must be greater than 0");
        }
    }
}
