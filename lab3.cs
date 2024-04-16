using System;

struct Student
{
    public string Name;
    public int GroupNumber;
    public int[] Grades;

    public double AverageGrade()
    {
        double sum = 0;
        foreach (int grade in Grades)
        {
            sum += grade;
        }
        return sum / Grades.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[7];

        students[0] = new Student { Name = "Анашкина А.П.", GroupNumber = 2117, Grades = new int[] { 2, 5, 5, 5, 5 } };
        students[1] = new Student { Name = "Марков М.А.", GroupNumber = 2117, Grades = new int[] { 3, 4, 5, 4, 5 } };
        students[2] = new Student { Name = "Купцова Н.М.", GroupNumber = 2117, Grades = new int[] { 4, 5, 5, 5, 5 } };
        students[3] = new Student { Name = "Шевионкова М.П.", GroupNumber = 2117, Grades = new int[] { 5, 5, 5, 5, 5 } };
        students[4] = new Student { Name = "Алдаев Д.С.", GroupNumber = 2214, Grades = new int[] { 3, 4, 4, 4, 2 } };
        students[5] = students[3] with { Name = "Подосинникова П.Р.", GroupNumber = 331};
        students[6] = new Student { Name = "Суров В.Р.", GroupNumber = 2117, Grades = new int[] { 0, 0, 5, 0, 0 } };

        Array.Sort(students, (s1, s2) => s1.AverageGrade().CompareTo(s2.AverageGrade()));

        Console.WriteLine("Студенты, упорядоченные по среднему баллу:");
        foreach (var student in students)
        {
            Console.WriteLine($"ФИО: {student.Name}, Группа: {student.GroupNumber}, Средний балл: {student.AverageGrade()}");
        }
    }
}