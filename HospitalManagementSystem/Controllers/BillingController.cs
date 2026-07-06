using HospitalManagementSystem.Application.Dto.Billing;
using HospitalManagementSystem.Application.Dto.BillingDto;
using HospitalManagementSystem.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillingController : ControllerBase
    {
        private readonly IBillingService _billingService;   
        public BillingController(IBillingService BillingService)
        {
            this._billingService = BillingService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var bill = await _billingService.GetAllAsync();
            return Ok(bill);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetAsyncById(int id)
        {
            var bill = await _billingService.GetAsyncById(id);
            return Ok(bill);
        }
        [HttpPost]
        public async Task<IActionResult> Create(BillingDto dto)
        {
            await _billingService.AddAsync(dto);
            return Ok(dto); 
        }
        [HttpPut("id")]
        public async Task<IActionResult> UpdateAsync(int id,UpdateBillingDto dto)
        {
            await _billingService.UpdateAsync(id, dto);
            return Ok("Updated Successfully!");
        }
        [HttpDelete("id")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _billingService.DeleteAsync(id);
            return Ok("Deleted Successfully!");
        }
    }
}
