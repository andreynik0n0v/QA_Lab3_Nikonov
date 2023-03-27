using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    /// <summary>
    /// Класс человека
    /// Простое описание человека который вот вот станет родителем
    /// </summary>
    class Person
    {
        /// <summary>
        /// Имя
        /// </summary>
        protected string _name;
        /// <summary>
        /// Фамилия
        /// </summary>
        protected string _surname;
        /// <summary>
        /// Дата рождения
        /// </summary>
        protected DateTime _birthdate;
        /// <summary>
        /// Дети
        /// </summary>
        protected List<Children> _childs;
        /// <summary>
        /// Конструктор 
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="birthdate">Дата рождения</param>
        /// <param name="childs">Список детей</param>
        public Person(string name, string surname, DateTime birthdate, List<Children> childs)
        {
            _name = name;
            _surname = surname;
            _birthdate = birthdate;
            _childs = childs;
        }
        /// <summary>
        /// Отображает в консоли информацию о человеке и его детях
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"Name:{_name} {_surname}  Age:{GetAge()}");
            Console.WriteLine("Childs:");
            foreach (Children children in _childs)
            {
                Console.WriteLine($"{children.Gender} {children.Name}");
            }
        }
        /// <summary>
        /// Рассчитывает возраст
        /// </summary>
        /// \f$Возраст = Дата Рождения - Текущая Дата   \f$
        /// <returns>Возвращает возраст</returns>
        public int GetAge()
        {
            return DateTime.Now.Subtract(_birthdate).Days / 365;
        }
    }
}
