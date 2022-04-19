namespace Group_of_students
{
    /// <summary>
    /// Предмет
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Предмет
        /// </summary>
        /// <param name="nameSubject">Наименование предмета</param>
        public Subject(string nameSubject)
        {
            _name = nameSubject;
        }

        /// <summary>
        /// Имя предмета
        /// </summary>
        private string _name;

        /// <summary>
        /// Наименование предмета
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        

    }
}
