using System;

namespace DayTimeEnum
{
    class Program
    {
        enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum TimeOfDay
        {
            Morning,
            Day,
            Evening,
            Night
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите день недели (1-7):");
            int dayIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("Введите время (0-23):");
            int hour = Convert.ToInt32(Console.ReadLine());

            if (Enum.IsDefined(typeof(DayOfWeek), dayIndex) && hour >= 0 && hour <= 23)
            {
                DayOfWeek day = (DayOfWeek)dayIndex;
                TimeOfDay timeOfDay;

                if (hour >= 7 && hour <= 12)
                    timeOfDay = TimeOfDay.Morning;
                else if (hour >= 13 && hour <= 18)
                    timeOfDay = TimeOfDay.Day;
                else if (hour >= 19 && hour <= 23)
                    timeOfDay = TimeOfDay.Evening;
                else
                    timeOfDay = TimeOfDay.Night;

                Console.WriteLine($"Сейчас {GetDayOfWeek(day)}, {GetTimeOfDayString(timeOfDay)}");
                Console.WriteLine($"Сейчас {day}, {timeOfDay}");

            }
            else
            {
                Console.WriteLine("Введены неверные данные.");
            }
        }

        static string GetTimeOfDayString(TimeOfDay timeOfDay)
        {
            switch (timeOfDay)
            {
                case TimeOfDay.Morning:
                    return "утро";
                case TimeOfDay.Day:
                    return "день";
                case TimeOfDay.Evening:
                    return "вечер";
                case TimeOfDay.Night:
                    return "ночь";
                default:
                    return "";
            }
        }
        static string GetDayOfWeek(DayOfWeek dayofweek)
        {
            switch (dayofweek)
            {
                case DayOfWeek.Monday:
                    return "понедельник";
                case DayOfWeek.Tuesday:
                    return "вторник";
                case DayOfWeek.Wednesday:
                    return " еее среда чюваки";
                case DayOfWeek.Thursday:
                    return "четверг";
                case DayOfWeek.Friday:
                    return "пятница работяги";
                case DayOfWeek.Saturday:
                    return "суббота";
                case DayOfWeek.Sunday:
                    return "воскресенье";
                default:
                    return "";
            }
        }
    }
}