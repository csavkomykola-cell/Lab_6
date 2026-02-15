using System;

namespace Lab6
{
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
    class Car : Vehicle
    {
        public Car(string brand, int speed) : base(brand, speed) { }

        public override void Move()
        {
            Console.WriteLine($"Автомобіль {brand} їде по дорозі зі швидкістю {speed} км/год.");
        }
    }
    class Bicycle : Vehicle
    {
        public Bicycle(string brand, int speed) : base(brand, speed) { }

        public override void Move()
        {
            Console.WriteLine($"Велосипед {brand} рухається по велодоріжці зі швидкістю {speed} км/год.");
        }
    }
    class Airplane : Vehicle
    {
        public Airplane(string brand, int speed) : base(brand, speed) { }

        public override void Move()
        {
            Console.WriteLine($"Літак {brand} летить у небі зі швидкістю {speed} км/год.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", 120);
            Bicycle bicycle = new Bicycle("Trek", 25);
            Airplane airplane = new Airplane("Boeing", 850);
            car.Move();
            bicycle.Move();
            airplane.Move();
        }
    }
}
