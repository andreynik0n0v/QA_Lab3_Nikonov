using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    /// <summary>
    /// ![Image](../images/1.jpg)
    /// </summary>
    class Boy : Children
    {
        /// <summary>
        /// Конструктор 
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name= "gender">Пол</param>
        public Boy(string name, string gender) : base(name, gender) { }
        /// <summary>
        /// Выводит в консоль поздравления о рождении ребенка
        /// </summary>
        public void POL()
        {
            Console.WriteLine("congratulations, you have a baby boy");
        }
    }
}
