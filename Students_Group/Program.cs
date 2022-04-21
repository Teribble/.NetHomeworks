using System;

/// <summary>
//  Написать программу «Группа студентов».
//      Программа получает следующие данные:
//           ▷▷список студентов группы,
//           ▷▷список предметов для группы,
//      Программа выводит следующие данные:
//           ▷▷таблицу оценок студентов по предметам, +
//           ▷▷средние оценки студентов, + 
//           ▷▷средние оценки по предметам, + 
//           ▷▷средний балл группы, +
//           ▷▷максимальные и минимальные оценки по предметам с указанием студентов. +
//      Разработать и использовать в программе классы: «Группа», «Студент», «Предмет».
//          Атрибуты группы: название, список студентов, список предметов.
//          Атрибуты студента: имя, список оценок
//          Атрибуты предмета: название
/// </summary>


namespace Students_Group
{
    class Program
    {
        static void Main()
        {
            var sub = new List<Subject>();
            sub.Add(new Subject("Математика"));
            sub.Add(new Subject("Геометрия"));
            sub.Add(new Subject("Обществознание"));
            sub.Add(new Subject("Русский"));
            sub.Add(new Subject("Литература"));

            var st = new List<Student>();
            st.Add(new Student("Геннадий Александрович"));
            st.Add(new Student("Павел Анатольевич"));
            st.Add(new Student("Максим Абдурахимович"));
            st.Add(new Student("Александр Михалович"));
            st.Add(new Student("Елена Владимировна"));

            var group = new Group("Bs-12", st, sub);
            Console.WriteLine("\n----Таблицу оценок студентов по предметам----\n");
            group.PrintTableStudents();
            Console.WriteLine("\n----Средние оценки студентов----\n");
            group.PrintAverageGrades();
            Console.WriteLine("\n----Средние оценки по предметам----\n");
            group.PrintAverageGradesSubject();
            Console.WriteLine("\n----Средний балл группы----\n");
            group.PrintAverageGradeGroup();
            Console.WriteLine("\n----Максимальные и минимальные оценки по предметам с указанием студентов----\n");
            group.PrintMaxMin();

        }
    }
}