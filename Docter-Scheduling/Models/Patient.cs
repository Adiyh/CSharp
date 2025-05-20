namespace Docter_Scheduling.Models;

public class Patient
{
    public int ID { get; set; }
    public required string Name { get; set; }
    public int Age { get; set; }
    public required string Phone { get; set; }
}
