using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public abstract class Person
    {
        public string _name;
        public int _age;
        public char _gender;
        public abstract void DisplayDetails();
        public Person()
        {
            _name = "Adarsh";
            _age = 22;
            _gender = 'M';
        }
    }
    public class Employee : Person
    {
        public int employeeId;
        public string department;
        public double salary;
        public Employee()
        {
            employeeId = 12;
            department = "CSE";
            salary = 23345.4;

        }
        //public Employee(int employeeId, string department, double salary)
        //{
        //    this.employeeId = employeeId;
        //    this.department = department;
        //    this.salary = salary;

        //}
        public override void DisplayDetails()
        {
            Console.WriteLine();
            Console.WriteLine("THE Details ARE");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Name is "+_name);
            Console.WriteLine("Age is  "+_age);
            Console.WriteLine("Gender is  "+_gender);
            Console.WriteLine("Employee ID  "+employeeId);
            Console.WriteLine("Department is "+department);
            Console.WriteLine("Salary is "+salary);
            Console.WriteLine("bonus is " + salary*12);
        }
        public virtual void CalculateBonus()
        {
            int percent = 12;
            double bonus = salary * percent;
            Console.WriteLine(bonus);
        }
        public void CalculateBonus(int percent)
        {
            double bonus = salary * percent;
            Console.WriteLine(bonus);
        }

    }
    public class Manager : Employee
    {
        public int _teamSize = 5;
        public string role = "Developer";

        static Manager()
        {
            string companyName = "Datalyser";
        }
        public override void CalculateBonus()
        {
            int percent = 12;
            double bonus = salary * percent;
            Console.WriteLine(bonus);
        }

    }
    public class Runner
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Select the Role");
                Console.WriteLine("1.Employee   2.Manager");
                int choice = int.Parse(Console.ReadLine());
                if (choice >= 1 && choice <= 2)
                {
                    Person person = null;

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the details of employee");
                            person = new Employee();
                            Console.WriteLine("Enter the age");
                            person._age = int.Parse(Console.ReadLine());
                            try
                            {
                                Console.WriteLine("Enter the Gender");
                                person._gender = char.Parse(Console.ReadLine());
                             
                                Console.WriteLine("Enter the name");
                                person._name = Console.ReadLine();
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                throw;
                            }

                            break;
                        case 2:
                            Console.WriteLine("Enter the details of Manager");
                            person = new Manager();

                            try
                            {
                                Console.WriteLine("Enter the age");
                                person._age = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter the Gender");
                                person._gender = char.Parse(Console.ReadLine());
                                Console.WriteLine("Enter the name");
                                person._name = Console.ReadLine();
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                throw;
                            }


                            break;
                        case 3:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                    person.DisplayDetails();

                }
                else{
                    Console.WriteLine("Enter the value between 1 and 2");
                }
            }

            catch (FormatException ex)
            {

                Console.WriteLine(ex.Message);
            }

            }
        }
    }
