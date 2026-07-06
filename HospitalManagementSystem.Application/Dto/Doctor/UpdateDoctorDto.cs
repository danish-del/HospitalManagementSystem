using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Application.Dto.Doctor
{
    public class UpdateDoctorDto
    {
        public string? Name { get; set; }
        public string? Specialization { get; set; }
        public string? Contact { get; set; }
        public int ExperienceYears { get; set; }
    }
}
