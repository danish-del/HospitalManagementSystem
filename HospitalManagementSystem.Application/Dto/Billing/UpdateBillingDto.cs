using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Application.Dto.Billing
{
    public class UpdateBillingDto
    {
        public decimal Amount { get; set; }
        public string? PaymentStatus { get; set; }
    }
}
