using AutoMapper;
using HospitalManagementSystem.Application.Dto.Billing;
using HospitalManagementSystem.Application.Dto.BillingDto;
using HospitalManagementSystem.Application.Interfaces.Repositories;
using HospitalManagementSystem.Application.Interfaces.Services;
using HospitalManagementSystem.Domain.Model;

namespace HospitalManagementSystem.Application.Implementation.Service
{
    public class BillingService : IBillingService
    {
        private readonly IGenericRepository<Billing> _repoBilling;
        private readonly IMapper _mapper;
        public BillingService(IGenericRepository<Billing> RepoBilling,
            IMapper Mapper)
        {
            this._repoBilling = RepoBilling;
            this._mapper = Mapper;
        }
        public async Task<IEnumerable<CreateBillingDto>> GetAllAsync()
        {
            var bill = await _repoBilling.GetAllAsync();
            return _mapper.Map<IEnumerable<CreateBillingDto>>(bill);
        }
        public async Task<CreateBillingDto> GetAsyncById(int id)
        {
            var Bill = await _repoBilling.GetAllByIdAsync(id);
            return _mapper.Map<CreateBillingDto>(Bill);
        }
        public async Task AddAsync(BillingDto dto)
        {
            var Bill = _mapper.Map<Billing>(dto);
            Bill.Date = DateTime.Now;
            await _repoBilling.AddAsync(Bill);
        }
        public async Task UpdateAsync(int id,UpdateBillingDto dto)
        {
            var Bill = await _repoBilling.GetAllByIdAsync(id);
            if (Bill == null)
                throw new Exception("Billing Record Not Found!");
            _mapper.Map(dto, Bill);
            await _repoBilling.UpdateAsync(Bill);
        }
        public async Task DeleteAsync(int id)
        {
            await _repoBilling.DeleteAsync(id);
        }
    }
}
