using AutoMapper;
using HospitalManagementSystem.Application.Dto.Doctor;
using HospitalManagementSystem.Application.Interfaces.Repositories;
using HospitalManagementSystem.Application.Interfaces.Services;
using HospitalManagementSystem.Domain.Model;

namespace HospitalManagementSystem.Infrastructure.Service
{
    public class DoctorService : IDoctorService
    {
        private readonly IGenericRepository<Doctor> _doctorService;
        private readonly IMapper _mapper;
        public DoctorService(IGenericRepository<Doctor> DoctorService, IMapper mapper)
        {
            this._doctorService = DoctorService;
            this._mapper = mapper;
        }
        public async Task<IEnumerable<DoctorResponse>> GetAllAsync()
        {
            var doctor = await _doctorService.GetAllAsync();
            return _mapper.Map<IEnumerable<DoctorResponse>>(doctor); 
        }
        public async Task<DoctorResponse> GetAsyncById(int id)
        {
            var doctor = await _doctorService.GetAllByIdAsync(id);
            return _mapper.Map<DoctorResponse>(doctor);
        }
        public async Task AddAsync(CreateDoctorDto dto)
        {
            var doctor = _mapper.Map<Doctor>(dto);
            await _doctorService.AddAsync(doctor);
        }
        public async Task UpdateAsync(int id,UpdateDoctorDto dto)
        {
            var doctor = await _doctorService.GetAllByIdAsync(id);
            if (doctor == null)
                throw new Exception("Doctor Not Found!");

            _mapper.Map(dto, doctor);
            await _doctorService.UpdateAsync(doctor);   
        }
        public async Task DeleteAsync(int id)
        {
            await _doctorService.DeleteAsync(id);   
        }
    }
}
