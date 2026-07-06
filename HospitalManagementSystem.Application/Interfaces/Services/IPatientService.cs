using HospitalManagementSystem.Application.Dto.Patient;

namespace HospitalManagementSystem.Application.Interfaces.Services
{
    public interface IPatientService
    {
        Task<IEnumerable<PatientResponseDto>> GetAllPatientAsync();
        Task<PatientResponseDto?> GetAllPatientByIdAsync(int id);
        Task AddAsync(CreatePatientDto dto);
        Task UpdateAsync(int id,UpdatePatientDto dto);
        Task DeleteAsync(int id);   
    }
}
