namespace Docter_Scheduling.Models;

public class Doctor
{
    public int ID { get; set; }
    public required string Name { get; set; } 
    public required string Specialization { get; set; } 
    public Dictionary<int, DateTime> SlotMap { get; set; } = new();
}
