using FluentValidation;
using HospitalManagementSystem.Application.Dto.Billing;
using HospitalManagementSystem.Application.Dto.BillingDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Application.Validators
{
    public class CreateBillingDtosValidators : AbstractValidator<CreateBillingDto>
    {
        public CreateBillingDtosValidators()
        {
            RuleFor(x => x.Amount)
                .GreaterThan(0).WithMessage("Amount must be greater than 0");
            RuleFor(x => x.PaymentStatus)
                .NotEmpty().Must(status => status == "Paid" || status == "Pending");
        }
    }
}
