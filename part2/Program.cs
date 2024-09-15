using System;
using System.Security.Cryptography.X509Certificates;
namespace CsharpProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car obj1 = new Car("toyota", "2,5L", 230);
            Car obj2 = new Car("toyota", "2,5L", 230);
            Console.WriteLine(obj1.Equals(obj2));




        }


    }

public class Car
    {
        public string Name { get; set; }
        public string Engine {  get; set; }
        public int MaxSpeed { get; set; }

        public Car(string name,string Engine,int maxspeed) { 
        this.Name = name;   
            this.Engine = Engine;
            this.MaxSpeed = maxspeed;
        
        }

        public override string ToString()
        {
            return Name;
        }





        public  bool Equals(Car other)
        {
                if (other == null) return false;
                return Name == other.Name && Engine == other.Engine && MaxSpeed == other.MaxSpeed;
        }

        public interface IEquatable<T>
        {
              bool Equals(T other);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Engine.GetHashCode() + this.MaxSpeed.GetHashCode();
        }


    }
    public class CarsCatalog
    {
        Car[] cars;

        public CarsCatalog(params Car[] cars)
        {
            cars = new Car[cars.Length];
        }




        public string this[int index]
        {
            get
            {
                return "Name of car:" + this.cars[index].Name + "Engine" + this.cars[index].Engine;
            }
        }


    }

}

