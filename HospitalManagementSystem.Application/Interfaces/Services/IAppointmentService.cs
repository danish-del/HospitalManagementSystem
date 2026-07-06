using HospitalManagementSystem.Application.Dto.Appointment;
using HospitalManagementSystem.Domain.Model;

namespace HospitalManagementSystem.Application.Interfaces.Services
{
    public interface IAppointmentService
    {
        Task<IEnumerable<AppointmentResponse>> GetAllAppointmentsAsync();
        Task<AppointmentResponse?> GetAppointmentByIdAsync(int id);
        Task AddAsync(CreateAppointmentDto dto);
        Task UpdateAsync(int id, UpdateAppointment dto);
        Task DeleteAsync(int id);
    }
}