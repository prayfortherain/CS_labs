using System;

delegate void AccountHandler(string message);
class FirstClass
{
    public event AccountHandler Event;

    private string name;

    public FirstClass(string name)
    {
        this.name = name;
    }

    public void GenerateEvent()
    {
        Event.Invoke(name);
    }
}

class SecondClass
{
    private string name;

    public SecondClass(string name)
    {
        this.name = name;
    }

    public void HandleEvent(string eventName)
    {
        Console.WriteLine($"Ивент {eventName} вызван через {name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var first1 = new FirstClass("Первый");
        var second = new SecondClass("Второй");

        first1.Event += second.HandleEvent;

        first1.GenerateEvent();
    }
}
