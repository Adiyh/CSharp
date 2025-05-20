using System;
public abstract class Payment
{
    public abstract void Pay(double amount);
    public void Recipt()
    {
        Console.WriteLine("Recipt is generated");
    }

}
public class Runner
{
    public void Run()
    {
        double amount = 0.0;
        Payment payment = null;
        try
        {
            Console.WriteLine("Select the type of payment");
            Console.WriteLine("1.Credit Card");
            Console.WriteLine("2.UPI");
            Console.WriteLine("3.Cash");
            int choice = int.Parse(Console.ReadLine());
            if (choice <= 3 && choice >= 1)
            {
                Console.WriteLine("Enter the amount");
                amount = double.Parse(Console.ReadLine());



                switch (choice)
                {
                    case 1:
                        payment = new Credit();

                        break;
                    case 2:
                        payment = new Upi();
                        break;
                    case 3:
                        payment = new Cash();
                        break;
                    default:
                       
                        break;
                }
                payment.Pay(amount);
                payment.Recipt();
            }
            else
            {
                Console.WriteLine("Enter the correct value between 1 to 3");
            }
        }

        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
           
        }
        finally
        {
            Console.WriteLine("End of the Program");
        }
    }
    public class Upi:Payment   
    {
        public override void Pay(double amount)
        {
            Console.WriteLine("Payment donr via UPI");
        }
        
    }
    public class Credit : Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine("Payment done via Credit card");
        }
    }
    public class Cash : Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine("Payment done via cash");
        }
    }
}
