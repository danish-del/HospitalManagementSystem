using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Application.Dto.BillingDto
{
    public class BillingDto
    {
        public int PatientId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }= DateTime.Now;
    }
}
