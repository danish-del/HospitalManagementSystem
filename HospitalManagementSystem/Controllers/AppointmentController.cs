using HospitalManagementSystem.Application.Dto.Appointment;
using HospitalManagementSystem.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HospitalManagementSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appoint;
        public AppointmentController(IAppointmentService Appoint)
        {
            this._appoint = Appoint;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var Appointment = await _appoint.GetAllAppointmentsAsync();
            return Ok(Appointment);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetAllByIdAsync(int id)
        {
            var Appointment = await _appoint.GetAppointmentByIdAsync(id);
            return Ok(Appointment); 
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateAppointmentDto dto)
        {
            await _appoint.AddAsync(dto);
            return Ok(dto);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAsync(int id,UpdateAppointment dto)
        {
            await _appoint.UpdateAsync(id,dto);
            return Ok("Updated Sucessfully!");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _appoint.DeleteAsync(id);
            return Ok("Deleted Successfully!");
        }
    }
}
