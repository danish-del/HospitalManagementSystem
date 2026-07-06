using HospitalManagementSystem.Application.Dto.Billing;
using HospitalManagementSystem.Application.Dto.BillingDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Application.Interfaces.Services
{
    public interface IBillingService
    {
        Task<IEnumerable<CreateBillingDto>> GetAllAsync();
        Task<CreateBillingDto> GetAsyncById(int id);
        Task AddAsync(BillingDto dto);
        Task UpdateAsync(int id,UpdateBillingDto dto);
        Task DeleteAsync(int id);
    }
}
