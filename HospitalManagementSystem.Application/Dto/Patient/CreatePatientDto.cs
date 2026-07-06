using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Application.Dto.Patient
{
    public class CreatePatientDto
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
        public string? Contact { get; set; }
        public string? MedicalHistory { get; set; }
    }
}
