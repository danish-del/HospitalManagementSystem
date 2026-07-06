using AutoMapper;
using HospitalManagementSystem.Application.Dto.Appointment;
using HospitalManagementSystem.Domain.Model;

namespace HospitalManagementSystem.Application.Mapping
{
    public class AppointmentProfile : Profile
    {
        public AppointmentProfile()
        {
            CreateMap<Appointment, AppointmentResponse>();
            CreateMap<CreateAppointmentDto, Appointment>();
            CreateMap<UpdateAppointment, Appointment>();
        }
    }
}
