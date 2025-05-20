
//public abstract class Animal
//{
//    public virtual void Sound()
//    {
//        Console.WriteLine("Animal Make Sound ");
//    }
//    public abstract void Walk();

//    public class Dog : Animal
//    {
//        public override void Sound()
//        {
//            Console.WriteLine("Adarsh barks");
//        }
//        public override void Walk()
//        {
//            throw new NotImplementedException();
//        }
//    }
//    public class Adarsh
//        {
//        public void Run()
//        {
//            Animal animal = new Dog();
//            animal.Sound();
//        }
//    }

//}

public class Father
{
    public void FatherDetail()
    {
        int father_age = 12;
        Console.WriteLine(father_age);
        string father_name = "Hanumanthegowda";

    }
}
public class Mother:Father
{
    public void MotherDetails()
    {
        
        
        int mother_age = 36;
        Console.WriteLine(mother_age);
        string mother_name = "Mani";
    }
}
public class Son:Father
{
    public void SonDetails()
    {    
        Mother mother = new Mother();
        mother.MotherDetails();
        
        Father father = new Father();
        father.FatherDetail();
    }
}


























