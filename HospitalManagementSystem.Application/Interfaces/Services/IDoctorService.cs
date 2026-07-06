using HospitalManagementSystem.Application.Dto.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Application.Interfaces.Services
{
    public interface IDoctorService
    {
        Task<IEnumerable<DoctorResponse>> GetAllAsync();
        Task<DoctorResponse> GetAsyncById(int id);
        Task AddAsync(CreateDoctorDto dto);
        Task UpdateAsync(int id ,UpdateDoctorDto dto);
        Task DeleteAsync(int id);
    }
}
