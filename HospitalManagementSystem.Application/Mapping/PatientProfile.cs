using AutoMapper;
using HospitalManagementSystem.Application.Dto.Patient;
using HospitalManagementSystem.Domain.Model;

namespace HospitalManagementSystem.Application.Mapping
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<Patient, PatientResponseDto>();
            CreateMap<CreatePatientDto, Patient>();
            CreateMap<UpdatePatientDto, Patient>();
        }
    }
}
