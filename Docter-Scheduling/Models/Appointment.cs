namespace Docter_Scheduling.Models;

public class Appointment
{
    public int ID { get; set; }
    public int DoctorID { get; set; }
    public int PatientID { get; set; }
    public DateTime Slot { get; set; }
    public string AppointmentCode { get; set; }
}
