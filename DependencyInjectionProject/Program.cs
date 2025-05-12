using DependencyInjectionProject;

internal class Program{
    public static void Main(string[] args)
    {
       IMessageSender emailsender =new EmailSender();
        IMessageSender smssender = new SmsSender();
        MessageService service = new MessageService(emailsender);
        MessageService service2 = new MessageService(smssender);
        service.SendMessage("Adarsh Email Bantu");
        service2.SendMessage("Adarsh SMS Bantu");


        Console.ReadKey();
    }

}