using System;

class Animal
{
    public string food;
    public string location;

    public Animal(string food, string location)
    {
        this.food = food;
        this.location = location;
    }

    public virtual void Sleep()
    {
        Console.WriteLine("Животное спит");
    }

    public virtual void MakeNoise(){
        Console.WriteLine("Животное шумит");
    }

    public virtual void Eat(){
        Console.WriteLine("Животное кушает");
    }
}


class Dog : Animal
{
    public string breed;

    public Dog(string food, string location, string breed) : base(food, location)
    {
        this.breed = breed;
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Собака гавкает");
    }

    public override void Eat()
    {
        Console.WriteLine($"Собака ест {food}");
    }
}

class Cat : Animal
{
    public int livesLeft;

    public Cat(string food, string location, int livesLeft) : base(food, location)
    {
        this.livesLeft = livesLeft;
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Кошка мяукает");
    }

    public override void Eat()
    {
        Console.WriteLine($"Кошка ест {food}");
    }
}

class Horse : Animal
{
    public string color;

    public Horse(string food, string location, string color) : base(food, location)
    {
        this.color = color;
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Лошадь ржет");
    }

    public override void Eat()
    {
        Console.WriteLine($"Лошадь ест {food}");
    }
}

delegate void AnimalAction();

class Veterinarian
{
    public void TreatAnimal(Animal animal, AnimalAction action)
    {
        Console.WriteLine($"Пришедшее на прием животное. Еда: {animal.food}, Местоположение: {animal.location}");
        action.Invoke();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("премиум ультра корм для собак", "лежанка", "корги");
        Cat cat = new Cat("киткит", "коробка от мультиварки", 2);
        Horse horse = new Horse("сено", "стойло", "белый");

        Veterinarian vet = new Veterinarian();

        AnimalAction dogAction = dog.MakeNoise;
        AnimalAction catAction = cat.MakeNoise;
        AnimalAction horseAction = horse.MakeNoise;

        vet.TreatAnimal(dog, dogAction);
        vet.TreatAnimal(cat, catAction);
        vet.TreatAnimal(horse, horseAction);
    }
}