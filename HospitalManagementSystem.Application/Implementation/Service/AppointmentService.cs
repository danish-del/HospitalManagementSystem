using AutoMapper;
using HospitalManagementSystem.Application.Dto.Appointment;
using HospitalManagementSystem.Application.Interfaces.Repositories;
using HospitalManagementSystem.Application.Interfaces.Services;
using HospitalManagementSystem.Domain.Model;


public class AppointmentService : IAppointmentService
{
    private readonly IGenericRepository<Appointment> appointmentRepo;
    private readonly IMapper _mapper;
    public AppointmentService(IGenericRepository<Appointment> AppointmentRepo,
        IMapper Mapper)
    {
        this.appointmentRepo = AppointmentRepo;
        this._mapper = Mapper;
    }
    public async Task<IEnumerable<AppointmentResponse>> GetAllAppointmentsAsync()
    {
        var appointment = await appointmentRepo.GetAllAsync();
        return _mapper.Map<IEnumerable<AppointmentResponse>>(appointment);
    }
    public async Task<AppointmentResponse?> GetAppointmentByIdAsync(int id)
    {
        var appoint = await appointmentRepo.GetAllByIdAsync(id);
        return _mapper.Map<AppointmentResponse>(appoint);
    }
    public async Task AddAsync(CreateAppointmentDto dto)
    {
        var appoint = _mapper.Map<Appointment>(dto);
        await appointmentRepo.AddAsync(appoint);
    }
    public async Task UpdateAsync(int id, UpdateAppointment dto)
    {
        var appoint = await appointmentRepo.GetAllByIdAsync(id);
        if (appoint == null)
            throw new Exception("Appointment not Found!");
        _mapper.Map(dto,appoint);
        await appointmentRepo.UpdateAsync(appoint); 
    }
    public async Task DeleteAsync(int id)
    {
        await appointmentRepo.DeleteAsync(id);
    }
}






