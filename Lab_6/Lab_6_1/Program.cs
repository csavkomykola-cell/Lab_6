using System;
namespace Lab6
{
    interface Refuelable
    {
        void Refill();
    }
    abstract class Vehicle
    {
        protected string brand;
        protected int speed;
        public Vehicle(string brand, int speed)
        {
            this.brand = brand;
            this.speed = speed;
        }
        public abstract void Move();
    }
    class Car : Vehicle, Refuelable
    {
        public Car(string brand, int speed) : base(brand, speed) { }
        public override void Move()
        {
            Console.WriteLine($"Car {brand} drives at {speed} km/h");
        }
        public void Refill()
        {
            Console.WriteLine($"Car {brand} is refueling");
        }
    }
    class Bicycle : Vehicle
    {
        public Bicycle(string brand, int speed) : base(brand, speed) { }
        public override void Move()
        {
            Console.WriteLine($"Bicycle {brand} rides at {speed} km/h");
        }
    }
    class Airplane : Vehicle, Refuelable
    {
        public Airplane(string brand, int speed) : base(brand, speed) { }
        public override void Move()
        {
            Console.WriteLine($"Airplane {brand} flies at {speed} km/h");
        }
        public void Refill()
        {
            Console.WriteLine($"Airplane {brand} is refueling");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] list = new Vehicle[]
            {
                new Car("Ferrari", 150),
                new Bicycle("Ukraine", 30),
                new Airplane("Boeing", 900)
            };
            foreach (Vehicle v in list)
            {
                v.Move();
                if (v is Refuelable r)
                {
                    r.Refill();
                }
            }
        }
    }
}