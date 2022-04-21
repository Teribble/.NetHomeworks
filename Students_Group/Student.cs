using System;

namespace Students_Group
{
    /// <summary>
    /// Студент
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Максимальное количество оценок по предмету
        /// </summary>
        private const int MaxGradesInTheSubject = 5;

        /// <summary>
        /// Максимальный балл
        /// </summary>
        private const int MaxGrade = 5;

        /// <summary>
        /// Минимальный балл
        /// </summary>
        private const int MinGrade = 2;

        /// <summary>
        /// Конструктор с параметроми
        /// </summary>
        /// <param name="name">Имя студента</param>
        /// <param name="subjects">Список предметов для студента</param>
        public Student(string name)
        {
            Name = name;
        }

        public void AddSubject(List<Subject> subjects)
        {
            Subjects = subjects;

            Grades = new int[subjects.Count][];

            if(Subjects != null)
            {
                for (int subject = 0; subject < Subjects.Count; subject++)
                {
                    Grades[subject] = new int[MaxGradesInTheSubject];
                }
            }
            
            GenerateGrades();
        }

        /// <summary>
        /// Имя студента
        /// </summary>
        public string? Name { get; set; }
        
        /// <summary>
        /// Массив оценок, первая мерность это предмет, вторая мерность оценки по предмету
        /// </summary>
        public int[][]? Grades { get; set; }

        /// <summary>
        /// Список предметов студента
        /// </summary>
        public List<Subject>? Subjects { get; set; }

        /// <summary>
        /// Функция, которая заполняет массив оценок,рандомным числами от MinGrade = 2 до MaxGrade = 5
        /// </summary>
        private void GenerateGrades()
        {
            if (Subjects != null && Grades != null)
            {
                Random random = new Random();

                for (int subject = 0; subject < Subjects.Count; subject++)
                {
                    for (int grade = 0; grade < Grades[subject].Length; grade++)
                    {
                        Grades[subject][grade] = random.Next(MinGrade, MaxGrade + 1);
                    }
                }
            }
        }

        /// <summary>
        /// Средняя оценка студента
        /// </summary>
        /// <returns>значение(float) средней оценки студента по всем предметам </returns>
        public float GetAverageGrade()
        {
            float averageGrade = 0;

            if(Subjects != null)
            {
                int countGrades = Subjects.Count * MaxGradesInTheSubject;

                for (int subject = 0; subject < Subjects.Count; subject++)
                {
                    if(Grades != null)
                    {
                        for (int grade = 0; grade < Grades[subject].Length; grade++)
                        {
                            averageGrade += Grades[subject][grade];
                        }
                    }
                }
                
                return averageGrade / countGrades;
            }

            return averageGrade;
        }

        /// <summary>
        /// Средняя оценка по предмету
        /// </summary>
        /// <param name="indexSubject">Индекс предмета в списке</param>
        /// <returns>среднее значение(float) оценки по предмету</returns>
        public float GetSubjectAverageGrade(int indexSubject)
        {
            float averageGrade = 0;

            if(Subjects != null)
            {
                if(Grades != null)
                {
                    for (int grade = 0; grade < Grades[indexSubject].Length; grade++)
                    {
                        averageGrade += Grades[indexSubject][grade];
                    }

                    return averageGrade / MaxGradesInTheSubject;
                }
            }

            return averageGrade;
        }

        /// <summary>
        /// Все оценки по предмету
        /// </summary>
        /// <param name="indexSubject">Индекс предмета в списке</param>
        /// <returns>сроку со всеми оценками по предмету</returns>
        public string GetSubjectAllGrade(int indexSubject)
        {
            string buffer = "";

            if(Subjects != null)
            {
                if(Grades != null)
                {
                    for (int grade = 0; grade < Grades[indexSubject].Length; grade++)
                    {
                        buffer += Grades[indexSubject][grade] + " ";
                    }

                    return buffer;
                }
            }

            return buffer;
        }

        public string GetMinMaxGrade(int indexSubject)
        {
            string buffer = "";

            int max = MinGrade;

            int min = MaxGrade;

            if (Subjects != null)
            {
                if (Grades != null)
                {
                    for (int grade = 0; grade < Grades[indexSubject].Length; grade++)
                    {
                        if (Grades[indexSubject][grade] > max)
                            max = Grades[indexSubject][grade];
                        else if (Grades[indexSubject][grade] < min)
                            min = Grades[indexSubject][grade];
                    }

                    return buffer = "Min: " + min.ToString() + " " + "Max: " + max.ToString();
                }
            }

            return buffer;
        }
    }
}
