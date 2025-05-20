class Program
{
    enum Status
    {
        Pending,
        Approved,
        Rejected
    }

    static void Main()
    {
        Status currentStatus = Status.Rejected;
        Console.WriteLine(currentStatus);         // Output: Approved
        Console.WriteLine((int)currentStatus);    // Output: 1
    }
}
