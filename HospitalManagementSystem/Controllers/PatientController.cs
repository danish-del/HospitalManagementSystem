using HospitalManagementSystem.Application.Dto.Patient;
using HospitalManagementSystem.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;
        public PatientController(IPatientService PatientService)
        {
            _patientService = PatientService;
        }
        //[HttpGet]
        //public async Task<IActionResult> GetPatients(int page = 1)
        //{
        //    int pageSize = 10;

        //    var result = await _patientService.GetPatientsPagedAsync(page, pageSize);

        //    return Ok(result);
        //}
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var patients = await _patientService.GetAllPatientAsync();
            return Ok(patients);
        }
        [HttpGet("Id")]
        public async Task<IActionResult> GetById(int id)
        {
            var patient = await _patientService.GetAllPatientByIdAsync(id);
            return Ok(patient);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreatePatientDto dto)
        {
            await _patientService.AddAsync(dto);
            return Ok(dto);
        }
        [HttpPut("id")]
        public async Task<IActionResult> UpdateAsync(int id,UpdatePatientDto dto)
        {
            await _patientService.UpdateAsync(id, dto);
            return Ok("Patient Added Successfully");
        }
        [HttpDelete("id")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _patientService.DeleteAsync(id);
            return Ok("Deleted Successfully");
        }
    }
}
