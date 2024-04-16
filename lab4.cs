using System;

namespace StudentNamespace
{
    class Student
    {
        public string FullName;
        public int GroupNumber;
        private int age;

        public Student(string fullName, int groupNumber, int age)
        {
            FullName = fullName;
            GroupNumber = groupNumber;
            this.age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Студент: {FullName}, Группа: {GroupNumber}, Возраст: {age}");
        }
    }
}

namespace ReaderNamespace
{
    class Reader
    {
        private string fullName;
        public int LibraryCardNumber;
        public string Faculty;
        private DateTime dateOfBirth;
        public string PhoneNumber;

        public Reader(string fullName, int libraryCardNumber, string faculty, DateTime dateOfBirth, string phoneNumber)
        {
            this.fullName = fullName;
            LibraryCardNumber = libraryCardNumber;
            Faculty = faculty;
            this.dateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Читатель: {fullName}, Номер читательского билета: {LibraryCardNumber}, Факультет: {Faculty}, Дата рождения: {dateOfBirth.ToShortDateString()}, Телефон: {PhoneNumber}");
        }

        public void TakeBook(int numberOfBooks)
        {
            Console.WriteLine($"{fullName} взял {numberOfBooks} книги.");
        }

        public void TakeBook(params string[] bookTitles)
        {
            Console.Write($"{fullName} взял книги: ");
            foreach (var bookTitle in bookTitles)
            {
                Console.Write($"{bookTitle}, ");
            }
            Console.WriteLine();
        }

        public void ReturnBook(int numberOfBooks)
        {
            Console.WriteLine($"{fullName} вернул {numberOfBooks} книги.");
        }

        public void ReturnBook(params string[] bookTitles)
        {
            Console.Write($"{fullName} вернул книги: ");
            foreach (var bookTitle in bookTitles)
            {
                Console.Write($"{bookTitle}, ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentNamespace.Student[] students = new StudentNamespace.Student[3];
        students[0] = new StudentNamespace.Student("Иванов И.И.", 101, 20);
        students[1] = new StudentNamespace.Student("Петров П.П.", 102, 21);
        students[2] = new StudentNamespace.Student("Сидоров С.С.", 103, 22);

        ReaderNamespace.Reader[] readers = new ReaderNamespace.Reader[3];
        readers[0] = new ReaderNamespace.Reader("Иванов И.И.", 1001, "Факультет1", new DateTime(1995, 5, 10), "123-456-789");
        readers[1] = new ReaderNamespace.Reader("Петров П.П.", 1002, "Факультет2", new DateTime(1996, 6, 15), "987-654-321");
        readers[2] = new ReaderNamespace.Reader("Сидоров С.С.", 1003, "Факультет3", new DateTime(1997, 7, 20), "555-123-456");

        Console.WriteLine("Информация о студентах:");
        foreach (var student in students)
        {
            student.PrintInfo();
        }

        Console.WriteLine("\nИнформация о читателях:");
        foreach (var reader in readers)
        {
            reader.PrintInfo();
        }

        readers[0].TakeBook(3);
        readers[1].TakeBook("Приключения", "Словарь", "Энциклопедия");
        readers[2].ReturnBook("Приключения", "Словарь", "Энциклопедия");
        readers[0].ReturnBook(2);
    }
}
