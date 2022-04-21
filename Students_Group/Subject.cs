using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Group
{
    /// <summary>
    /// Предмет
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"> Наименование предмета</param>
        public Subject(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Наименование
        /// </summary>
        public string? Name { get; set; }
    }
}
