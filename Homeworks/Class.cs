using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    public class City 
    {
        public string name { get; set; }
        public string age  { get; set; }
        public int population { get; set; }
        public List<string> educationalInsitutions { get; set; }
        public List<string> hospitals { get; set; }
        public List<string> parks { get; set; }
        public List<string> shoppingMalls { get; set; }

        public string police { get; set; }
        public string transport { get; set; }
    }
    public class Municipality
    {
        public string mayor { get; set; }
        public string location { get; set; }

        public void improveCity()
        {
            Console.WriteLine("");
        }
        public void organizeEvents()
        {
            Console.WriteLine("");
        }
    }

    public class Citizen
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string occupation { get; set; }

        public void vote()
        {
            Console.WriteLine("");
        }
        public void payTaxes()
        {
            Console.WriteLine("");
        }
    }
    public interface IWorking
    {
        public string position { get; set; }
        public int salary { get; set; }
        public int lunchHours { get; set; }
        public List<string> skills { get; set; }

        void work();
        void remoteWork();
        void getSalary();
        void requestVacation();

    }
    public interface IStudying
    {
        public List<string> lessons { get; set; }
        public string institution { get; set; }
        public int fee { get; set; }
        public List<int> grades { get; set; }
        public double gpa { get; set; }

        void attendClasses();
        void getGrade();
        void payFee();
        void joinStudentCouncil();
    }
    public interface IMoving
    {

    }
    
    public class Student : Citizen, IStudying
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public List<string> lessons { get; set; }
        public string institution { get; set; }
        public int fee { get; set; }
        public List<int> grades { get; set; }
        public double gpa { get; set; }


        public void attendClasses()
        {
            Console.WriteLine("");
        }

        public void getGrade()
        {
            Console.WriteLine("");
        }

        public void joinStudentCouncil()
        {
            Console.WriteLine("");
        }

        public void payFee()
        {
            Console.WriteLine("");
        }
    }
    public class Employee : Citizen, IWorking
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string position { get; set; }
        public int salary { get; set; }
        public int lunchHours { get;  set; }
        public List<string> skills { get; set; }

        public void getSalary()
        {
            Console.WriteLine("");
        }

        public void remoteWork()
        {
            Console.WriteLine("");
        }

        public void requestVacation()
        {
            Console.WriteLine("");
        }

        public void work()
        {
            Console.WriteLine("");
        }
       
    }
    public interface IDriveable
    {
        void drive();
        void stop();
        void park();
        void increaseSpeed();
        void decreaseSpeed();
    }
    public class Bus : IDriveable
    {
        public List<string> stops { get; set; }
        public int number { get; set; }
        public int passengerCapacity { get; set; }
        public string route { get; set; }

        public void decreaseSpeed()
        {
            Console.WriteLine("");

        }

        public void drive()
        {
            Console.WriteLine("");
        }

        public void increaseSpeed()
        {
            Console.WriteLine("");
        }

        public void park()
        {
            Console.WriteLine("");
        }

        public void stop()
        {
            Console.WriteLine("");
        }
    }
    public class Taxi : IDriveable
    {
        public string driver { get; set; }
        public int carNumber { get; set; }
        public string company { get; set; }
        public string location { get; set; }
        public string driverInfo { get; set; }

        public void decreaseSpeed()
        {
            Console.WriteLine("");

        }
        public void drive()
        {
            Console.WriteLine("");
        }
        public void increaseSpeed()
        {
            Console.WriteLine("");
        }
        public void park()
        {
            Console.WriteLine("");
        }

        public void stop()
        {
            Console.WriteLine("");
        }

    }
}
