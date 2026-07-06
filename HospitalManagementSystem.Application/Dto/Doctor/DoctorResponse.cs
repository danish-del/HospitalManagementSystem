using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Application.Dto.Doctor
{
    public class DoctorResponse
    {
        public int DoctorId { get; set; }
        public string? Name { get; set; }
        public string? Specialization { get; set; }
        public string? Contact { get; set; }
        public int ExperienceYears { get; set; }
    }
}
