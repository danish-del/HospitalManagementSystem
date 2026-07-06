using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Application.Dto.Billing
{
    public class CreateBillingDto
    {
        public int BillId { get; set; }
        public int PatientId { get; set; }
        public decimal Amount { get; set; }
        public string? PaymentStatus { get; set; }
        public DateTime Date { get; set; }
    }
}
