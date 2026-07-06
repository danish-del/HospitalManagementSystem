using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Domain.Model
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string? Name { get; set; }
        public string? Specialization { get; set; }
        public string? Contact { get; set; }
        public int ExperienceYears { get; set; }
       public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
   }
}
