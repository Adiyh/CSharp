using Docter_Scheduling.Models;
using Docter_Scheduling.Data; // Added namespace for ApplicationDbContext
using Microsoft.EntityFrameworkCore;
namespace Docter_Scheduling.Services
{
    public class AppointmentService
    {
        private readonly ApplicationDbContext _context;

        public AppointmentService(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task BookAppointmentAsync(int doctorId, int patientId, int slotId)
        {
            var doctor = await _context.Doctors.FindAsync(doctorId);
            if (doctor == null || !doctor.SlotMap.ContainsKey(slotId))
            {
                throw new Exception("Invalid Doctor ID or Slot ID.");
            }

            DateTime slotTime = doctor.SlotMap[slotId];
            string appointmentCode = $"APT-D{doctorId}P{patientId}-{Guid.NewGuid()}";

            var appointment = new Appointment
            {
                DoctorID = doctorId,
                PatientID = patientId,
                Slot = slotTime,
                AppointmentCode = appointmentCode
            };

            _context.Appointments.Add(appointment);
            doctor.SlotMap.Remove(slotId);
            await _context.SaveChangesAsync();
        }

        public async Task CancelAppointmentAsync(string appointmentCode)
        {
            var appointment = await _context.Appointments.FirstOrDefaultAsync(a => a.AppointmentCode == appointmentCode);
            if (appointment == null)
            {
                throw new Exception("No appointment found with this code.");
            }

            var doctor = await _context.Doctors.FindAsync(appointment.DoctorID);
            if (doctor != null)
            {
                int newSlotId = doctor.SlotMap.Count + 1;
                doctor.SlotMap[newSlotId] = appointment.Slot;
            }

            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();
        }
    }
}