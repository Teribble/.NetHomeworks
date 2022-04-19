namespace Group_of_students
{
    /// <summary>
    /// Группа
    /// Максимальное количество студентов - 31
    /// Максимальное количество предметов - 11
    /// </summary>
    public class Group
    {
        /// <summary>
        /// Максимальный размер имени студента
        /// </summary>
        private const int MaxSizeFullName = 25;

        /// <summary>
        /// Максимальный размер имени предмета
        /// </summary>
        private const int MaxSizeSubName = 18; 
        
        /// <summary>
        /// Максимальное количество предметов в группе
        /// </summary>
        private const int MaxCountSubject = 11; 

        /// <summary>
        /// Максимальное кол-во студентов в группе
        /// </summary>
        private const int MaxCountStudent = 31; 


        /// <summary>
        /// Группа
        /// </summary>
        /// <param name="nameGroup">Наименование групыы</param>
        /// <param name="students">Список студентов</param>
        /// <param name="subjects">Список предметов</param>
        public Group(string nameGroup, List<Student> students, List<Subject> subjects)
        {
            _groupName = nameGroup;
            _students = students;
            _subjects = subjects;
        }
        /// <summary>
        /// Имя группы
        /// </summary>
        private string _groupName;

        /// <summary>
        /// Список студентов
        /// </summary>
        private List<Student> _students;

        /// <summary>
        /// Список предметов
        /// </summary>
        private List<Subject> _subjects;

        /// <summary>
        /// Наименование группы
        /// </summary>
        public string GroupName { get => _groupName; set => _groupName = value; }

        /// <summary>
        /// Добавить нового студента
        /// </summary>
        /// <param name="student">Новый студент</param>
        public void AddStudents(Student student)
        {
            if (_students.Count < MaxCountStudent && student != null)
                _students.Add(student);
        }

        /// <summary>
        /// Добавить новый предмет
        /// </summary>
        /// <param name="subject">Новый Предмет</param>
        public void AddSubject(Subject subject)
        {
            if (_subjects.Count < MaxCountSubject && subject != null)
            {
                _subjects.Add(subject);
                Reload();
            }
        }

        /// <summary>
        /// Добавляет новый предмет у всей группы
        /// </summary>
        private void Reload()
        {
            var newListStudents = new List<Student>();

            for (int i = 0; i < _students.Count; i++)
                newListStudents.Add(new Student(_students[i].FullName, _subjects));

            _students = newListStudents;
        }

        /// <summary>
        /// Таблица оценок студентов по предметам
        /// </summary>
        public void PrintTableStudents() // 1
        {
            PrintLine('*');

            Console.Write("|" + ("Полное имя студента" + "|").PadLeft(MaxSizeFullName));

            foreach (var subject in _subjects)
                Console.Write((subject.Name + "|").PadLeft(MaxSizeSubName));

            Console.WriteLine();

            PrintLine('*');

            for (int i = 0; i < _students.Count; i++)
                PrintStudent(i);

            PrintLine('*');
        }

        /// <summary>
        /// Печатает в консоль строку, в которой содержится полное имя студента, а так же все оценки по предметам
        /// </summary>
        /// <param name="index">Индекст конкретного студента в списке</param>
        private void PrintStudent(int index)
        {
            Console.Write("|" + (_students[index].FullName + "|").PadLeft(MaxSizeFullName));

            for (int i = 0; i < _subjects.Count; i++)
                Console.Write((_students[index].GetAllGradeStudent(i) + "|").PadLeft(MaxSizeSubName));

            Console.WriteLine();
        }

        /// <summary>
        /// Вспомогающий метод для правльной работы метода PrintLine()
        /// Печатает в консоль линию, которая по длине равна максимальной длине имени
        /// </summary>
        /// <param name="ch">Символ начала и конца линии </param>
        private void PrintLineName(char ch)
        {
            Console.Write(ch);

            for (int i = 0; i < MaxSizeFullName-1; i++)
                Console.Write("-");

            Console.Write(ch);
        }

        /// <summary>
        /// Вспомогающий метод для правльной работы метода PrintLine()
        /// Печатает в консоль линию, которая по длине равна максимальной длине предмета
        /// </summary>
        /// <param name="ch">Символ начала и конца линии</param>
        private void PrintLineSubject(char ch)
        {
            for (int i = 0; i < MaxSizeSubName - 1; i++)
                Console.Write("-");

            Console.Write(ch);
        }

        /// <summary>
        /// Печатает в консоль строку разделитель для корректного отображения таблицы в консоле
        /// </summary>
        /// <param name="ch">Символ, разделяющий элементы таблицы</param>
        private void PrintLine(char ch)
        {
            PrintLineName(ch);

            for (int i = 0; i < _subjects.Count; i++)
                PrintLineSubject(ch);

            Console.WriteLine();
        }

        /// <summary>
        /// Выводит список студентов с их средней оценкой по всем предметам
        /// </summary>
        public void PrintAverageGrades()
        {
            for (int i = 0; i < _students.Count; i++)
            {
                Console.WriteLine(_students[i].FullName.ToString().PadRight(MaxSizeFullName) + " - Средняя оценка по всем предметам: " + _students[i].GetAverageGradesForAllSubject());
            }
        }

        /// <summary>
        /// Выводит таблицу со средним баллом по предметам
        /// </summary>
        public void PrintAverageGradesForAllSubject()
        {
            PrintLine('*');

            Console.Write("|" + ("Полное имя студента" + "|").PadLeft(MaxSizeFullName));

            foreach (var subject in _subjects)
                Console.Write((subject.Name + "|").PadLeft(MaxSizeSubName));

            Console.WriteLine();

            PrintLine('*');

            for (int i = 0; i < _students.Count; i++)
            {
                Console.Write("|" + (_students[i].FullName + "|").PadLeft(MaxSizeFullName));

                for (int j = 0; j < _subjects.Count; j++)
                {
                    Console.Write((_students[i].GetAverageGradeForSubject(j) + "|").PadLeft(MaxSizeSubName));
                }

                Console.WriteLine();
            }

            PrintLine('*');
        }
    }
}
