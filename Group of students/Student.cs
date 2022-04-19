namespace Group_of_students
{
    public class Student
    {
        /// <summary>
        /// Максимальное количество оценок у студента
        /// </summary>
        private const int MaxCountGrades = 3;

        /// <summary>
        /// Максимальный балл студента
        /// </summary>
        private const int MaxGrade = 5;

        /// <summary>
        /// Минимальный балл студента
        /// </summary>
        private const int MinGrade = 2;

        /// <summary>
        /// Студент
        /// </summary>
        /// <param name="fullName">Полное имя студента</param>
        /// <param name="subjects">Список предметов для студента</param>
        public Student(string fullName, List<Subject> subjects)
        {
            _fullName = fullName;

            _subjects = subjects;

            InitializeGrades();
        }

        /// <summary>
        /// Полное имя студента
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Список предметов у студента
        /// </summary>
        private List<Subject> _subjects;

        /// <summary>
        /// Свойство полного имени студента
        /// </summary>
        public string FullName { get => _fullName; set => _fullName = value; }

        /// <summary>
        /// Думерный массив оценок, 1 разряд массива это кол-во предметов, второй разряд кол-во оценок в предмете
        /// </summary>
        private int[][]? _grades;

        /// <summary>
        /// Инициализировать оценки
        /// </summary>
        /// <param name="subjects">Список предметов</param>
        private void InitializeGrades()
        {
            _grades = new int[_subjects.Count][];

            SetRandomGrades();
        }

        /// <summary>
        /// Метод, который задает рандомные оценки студента
        /// </summary>
        private void SetRandomGrades()
        {
            if (_grades != null)
            {
                Random randomizer = new Random();

                for (int i = 0; i < _grades.Length; i++)
                {
                    _grades[i] = new int[MaxCountGrades];

                    for (int j = 0; j < _grades[i].Length; j++)
                    {
                        _grades[i][j] = randomizer.Next(MinGrade, MaxGrade+1);
                    }
                }
            }
        }

        /// <summary>
        /// Вернуть все оценки студента
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Возращает строку, в которой содержаться все оценки определенного студента</returns>
        public string GetAllGradeStudent(int index)
        {
            string buffer = "";

            if (_grades != null)
            {
                for (int i = 0; i < _grades[index].Length; i++)
                {
                    buffer += _grades[index][i].ToString() + " ";
                }
            }

            return buffer;
        }

        /// <summary>
        /// Средний балл студента по всем предметам
        /// </summary>
        /// <returns>Возращает средний балл студента</returns>
        public int GetAverageGradesForAllSubject()
        {
            int averageGrade = 0;

            if(_grades != null)
            {
                for (int i = 0; i < _grades.Length; i++)
                {
                    for (int j = 0; j < _grades[i].Length; j++)
                    {
                        averageGrade += _grades[i][j];
                    }
                }

                return averageGrade / (MaxCountGrades * _grades.Length);
            }

            return averageGrade;
        }

        /// <summary>
        /// Возращает средний балл студента по определенному предмету
        /// </summary>
        /// <param name="index">Индекс предмета, из спика предметов</param>
        /// <returns></returns>
        public int GetAverageGradeForSubject(int indexSubject)
        {
            int averageGrade = 0;

            if (_grades != null)
            {
                for (int i = 0; i < _grades[indexSubject].Length; i++)
                {
                    averageGrade += _grades[indexSubject][i];
                }

                return averageGrade / MaxCountGrades;
            }

            return averageGrade;
        }

    }
}
