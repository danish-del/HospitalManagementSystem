using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Domain.Model
{
    public class Billing
    {
        [Key]
        public int BillId { get; set; }
        public int PatientId { get; set; }
        public int Amount { get; set; }
        public string? PaymentStatus { get; set; }
        public DateTime Date { get; set; }= DateTime.Now;   
    }
}
