using System;

class Program
{
    delegate string GetNextDayDelegate();

    static void Main(string[] args)
    {
        string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        int currentIndex = -2;

        GetNextDayDelegate getNextDay = () =>
        {
            currentIndex += 1;
            int nextIndex = (currentIndex + 1) % 7;
            return daysOfWeek[nextIndex];
        };

        for (int i = 0; i < 14; i++)
        {
            Console.WriteLine(getNextDay());
        }
    }
}
