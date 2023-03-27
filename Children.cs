using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    /// <summary>
    /// Класс ребенка
    /// </summary>
    class Children
    {/// <summary>
     /// Пол
     /// </summary>
        private string _gender;
        /// <summary>
        /// Имя
        /// </summary>
        private string _name;
        /// <summary>
        /// Свойство для получения имени ребенка
        /// </summary>
        public string Name { get { return _name; } }
        /// <summary>
        /// Свойство для получения пола ребенка
        /// </summary>
        public string Gender { get { return _gender; } }
        /// <summary>
        /// Конструктор 
        /// </summary>
        /// <param name="name">Имя</param
        /// <param name="gender">Пол</param>
        public Children(string name, string gender)
        {
            _name = name;
            _gender = gender;
        }
      
    }

}
