using HospitalManagementSystem.Application.Dto.Doctor;
using HospitalManagementSystem.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorservice;
        public DoctorController(IDoctorService DoctorService)
        {
            this._doctorservice = DoctorService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var doctors = await _doctorservice.GetAllAsync();
            return Ok(doctors); 
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetAsyncById(int id)
        {
            var doctor = await _doctorservice.GetAsyncById(id);
            return Ok(doctor);  
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateDoctorDto dto)
        {
            await _doctorservice.AddAsync(dto);
            return Ok(dto); 
        }
        [HttpPut("id")]
        public async Task<IActionResult> Update(int id,UpdateDoctorDto dto)
        {
            await _doctorservice.UpdateAsync(id,dto);
            return Ok("Updated Successfully!");
        }
        [HttpDelete("id")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _doctorservice.DeleteAsync(id);
            return Ok("Deleted Successfully!");
        }
    }
}
