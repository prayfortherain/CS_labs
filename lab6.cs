using System;

public abstract class Transport
{
    public abstract double Speed { get; }
    public abstract double LoadCapacity { get; }
    public abstract double Range { get; }

    public abstract string GetDescription();
}

public abstract class Automobile : Transport
{
    public override string GetDescription()
    {
        return $"Автомобиль грузоподъемностью в {LoadCapacity} может проехать {Range}";
    }
}

public abstract class Airplane : Transport
{
    public override string GetDescription()
    {
        return $"Самолет грузоподъемностью в {LoadCapacity} может пролететь {Range}";
    }
}

public abstract class Ship : Transport
{
    public override string GetDescription()
    {
        return $"Корабль грузоподъемностью в {LoadCapacity} может пройти {Range}";
    }
}

public class Truck : Automobile
{
    public override double Speed => 80; 
    public override double LoadCapacity => 5000; 
    public override double Range => 800; 
}

public class PassengerPlane : Airplane
{
    public override double Speed => 900; 
    public override double LoadCapacity => 200; 
    public override double Range => 10000; 
}

public class CargoShip : Ship
{
    public override double Speed => 30; 
    public override double LoadCapacity => 10000; 
    public override double Range => 5000;
}

class Program
{
    static void Main(string[] args)
    {
        Truck truck = new Truck();
        PassengerPlane plane = new PassengerPlane();
        CargoShip ship = new CargoShip();

        Console.WriteLine(truck.GetDescription());
        Console.WriteLine(plane.GetDescription());
        Console.WriteLine(ship.GetDescription());
    }
}
