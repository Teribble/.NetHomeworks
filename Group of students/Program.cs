using System;

namespace Group_of_students
{
    class Program
    {
        static void Main(string[] args)
        {
            var subjects = new List<Subject>()
            {
                new Subject("Математика"),
                new Subject("Русский"),
                new Subject("Английский"),
                new Subject("Программирование")
            };

            var students = new List<Student>()
            {
                new Student("Михалков Геннадий", subjects),
                new Student("Арамов Толик", subjects),
                new Student("Вялый Михаил", subjects),
                new Student("Пахов Евгений", subjects),
                new Student("Махова Светлана", subjects),
                new Student("Павленко Кузяй", subjects),
                new Student("Пупкин Виталий", subjects),
                new Student("Boo Foo", subjects),
                new Student("Носов Кузяй", subjects),
                new Student("Пашков Абдурахим", subjects)
            };

            var b147 = new Group("B-147", students, subjects);

            b147.PrintTableStudents();
            b147.PrintAverageGrades();
            b147.PrintAverageGradesForAllSubject();

            Console.ReadLine();
            Console.Clear();

            b147.AddSubject(new Subject("Литература"));
            b147.PrintTableStudents();
            b147.PrintAverageGrades();
            b147.PrintAverageGradesForAllSubject();

            Console.ReadLine();
            Console.Clear();

            b147.AddStudents(new Student("Власов Валерий", subjects));
            b147.PrintTableStudents();
            b147.PrintAverageGrades();
            b147.PrintAverageGradesForAllSubject();

        }
    }
}