namespace HospitalManagementSystem.Domain.Model
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
        public string? Contact { get; set; }
        public string? MedicalHistory { get; set; }
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public  ICollection<Billing> Billings { get; set; } = new List<Billing>();
    }
}
