using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Group
{
    /// <summary>
    /// Группа
    /// </summary>
    public class Group
    {
        /// <summary>
        /// Максимальное кол-во символов в имени
        /// </summary>
        private const int MaxCharInTheName = 50;

        /// <summary>
        /// Максимальное кол-во символов в предмете
        /// </summary>
        private const int MaxCharInTheSub = 20;

        /// <summary>
        /// Наименование группы
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Список студентов
        /// </summary>
        public List<Student>? Students { get; set; }

        /// <summary>
        /// Список предметов
        /// </summary>
        public List<Subject>? Subjects { get; set; }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">Имя студента</param>
        /// <param name="students">Список студентов</param>
        /// <param name="subjects">Список предметов</param>
        public Group(string name, List<Student> students, List<Subject> subjects)
        {
            Name = name;

            Students = students;

            InitializeSubject(subjects);
        }

        /// <summary>
        /// Добавить предметы студентам
        /// </summary>
        /// <param name="subjects">Список предметов</param>
        private void InitializeSubject(List<Subject> subjects)
        {
            Subjects = subjects;

            if(Students != null)
            {
                for (int student = 0; student < Students.Count; student++)
                {
                    Students[student].AddSubject(subjects);
                }
            }
        }

        public void PrintTableStudents()
        {
            Console.Write("Имя студента".PadRight(MaxCharInTheName));

            if(Subjects != null)
            {
                for (int subject = 0; subject < Subjects.Count; subject++)
                {
                    Console.Write(Subjects[subject].Name.PadRight(MaxCharInTheSub));
                }

                Console.WriteLine();

                for (int student = 0; student < Students.Count; student++)
                {
                    Console.Write(Students[student].Name.PadRight(MaxCharInTheName));

                    for (int subject = 0; subject < Subjects.Count; subject++)
                    {
                        Console.Write(Students[student].GetSubjectAllGrade(subject).PadRight(MaxCharInTheSub));
                    }

                    Console.WriteLine();
                }
            }
        }

        public void PrintAverageGrades()
        {
            for (int student = 0; student < Students.Count; student++)
            {
                Console.WriteLine(Students[student].Name + " - средняя оценка: " + Students[student].GetAverageGrade());
            }
        }

        public void PrintAverageGradesSubject()
        {
            Console.Write("Имя студента".PadRight(MaxCharInTheName));

            if (Subjects != null)
            {
                for (int subject = 0; subject < Subjects.Count; subject++)
                {
                    Console.Write(Subjects[subject].Name.PadRight(MaxCharInTheSub));
                }

                Console.WriteLine();

                for (int student = 0; student < Students.Count; student++)
                {
                    Console.Write(Students[student].Name.PadRight(MaxCharInTheName));

                    for (int subject = 0; subject < Subjects.Count; subject++)
                    {
                        Console.Write(Students[student].GetSubjectAverageGrade(subject).ToString().PadRight(MaxCharInTheSub));
                    }

                    Console.WriteLine();
                }
            }
        }

        public void PrintAverageGradeGroup()
        {
            int averageGrade = 0;

            int countGrade = 0;

            for (int student = 0; student < Students.Count; student++)
            {
                for (int subject = 0; subject < Students[student].Grades.Length; subject++)
                {
                    for (int grade = 0; grade < Students[student].Grades[subject].Length; grade++)
                    {
                        countGrade++;
                        
                        averageGrade += Students[student].Grades[subject][grade];
                    }
                }
            }

            Console.WriteLine("Средний балл группы: " + averageGrade / countGrade);
        }

        public void PrintMaxMin()
        {
            Console.Write("Имя студента".PadRight(MaxCharInTheName));

            if (Subjects != null)
            {
                for (int subject = 0; subject < Subjects.Count; subject++)
                {
                    Console.Write(Subjects[subject].Name.PadRight(MaxCharInTheSub));
                }

                Console.WriteLine();

                for (int student = 0; student < Students.Count; student++)
                {
                    Console.Write(Students[student].Name.PadRight(MaxCharInTheName));

                    for (int subject = 0; subject < Subjects.Count; subject++)
                    {
                        Console.Write(Students[student].GetMinMaxGrade(subject).PadRight(MaxCharInTheSub));
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
