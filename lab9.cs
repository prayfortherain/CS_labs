using System;
using System.Collections.Generic;

class Programm 
{
    public static void Main()
    {
        Car car1 = new Car("BMW");
        Car car2 = new Car("Suzuki");
        Car car3 = new Car("Audi");

        Garage garage = new Garage();
        garage.AddCar(car1);
        garage.AddCar(car2);
        garage.AddCar(car3);

        Washer washer = new Washer();
        
        Garage.CarWashDelegate carWashDelegate = washer.Wash;
        garage.WashAllCars(carWashDelegate);
    }
    public class Car
    {
        public string Model { get; set; }

        public Car(string model)
        {
            Model = model;
        }
    }
    public class Garage
    {
        private List<Car> cars;

        public Garage()
        {
            cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public delegate void CarWashDelegate(Car car);

        public void WashAllCars(CarWashDelegate carWashDelegate)
        {
            foreach (Car car in cars)
            {
                carWashDelegate(car);
            }
        }
    }
    public class Washer
    {
        public void Wash(Car car)
        {
            Console.WriteLine($"Моется {car.Model}");
        }
    }

}
