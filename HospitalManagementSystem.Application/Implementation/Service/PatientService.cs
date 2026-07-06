using AutoMapper;
using HospitalManagementSystem.Application.Dto.Patient;
using HospitalManagementSystem.Application.Interfaces.Repositories;
using HospitalManagementSystem.Application.Interfaces.Services;
using HospitalManagementSystem.Domain.Model;

namespace HospitalManagementSystem.Infrastructure.Service
{
    public class PatientService : IPatientService
    {
        private readonly IGenericRepository<Patient> _patientRepo;
        private readonly IMapper _mapper;
        public PatientService(IGenericRepository<Patient> patientRepo,
            IMapper Mapper)
        {
            _patientRepo = patientRepo;
            _mapper = Mapper;
        }
        public async Task<IEnumerable<PatientResponseDto>> GetAllPatientAsync()
        {
            var patient = await _patientRepo.GetAllAsync();
            return _mapper.Map<IEnumerable<PatientResponseDto>>(patient);
        }

        public async Task<PatientResponseDto?> GetAllPatientByIdAsync(int id)
        {
            var patient = await _patientRepo.GetAllByIdAsync(id);
            return _mapper.Map<PatientResponseDto>(patient);
        }
        public async Task AddAsync(CreatePatientDto dto)
        {
            var patient = _mapper.Map<Patient>(dto);
            await _patientRepo.AddAsync(patient);
        }
        public async Task UpdateAsync(int id, UpdatePatientDto dto)
        {
            var patient = await _patientRepo.GetAllByIdAsync(id);
            if (patient == null)
                throw new Exception("Patient not Found!");

            _mapper.Map(dto, patient);
            await _patientRepo.UpdateAsync(patient);
        }
        public async Task DeleteAsync(int id)
        {
            await _patientRepo.DeleteAsync(id);
        }
    }
}
