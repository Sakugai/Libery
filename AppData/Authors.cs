using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libery.AppData
{
    class Authors
    {
        public Authors(string name, DateTime birthDate, DateTime deathDate, int age, string birthPlace, bool isAlive, List<Books> books)
        {
            Name = name;
            BirthDate = birthDate;
            DeathDate = deathDate;
            Age = age;
            BirthPlace = birthPlace;
            IsAlive = isAlive;
            this.books = books;
        }

        public List<Books> books;//Список книг

        public string Name { get; set; }//ФИО
        public DateTime BirthDate { get; set; }//Дата рождения
        public DateTime DeathDate { get; set; }//Дата смерти
        public int Age { get; set; }//Возраст
        public string BirthPlace { get; set; } //Место рождения       
        public bool IsAlive { get; set; } = true;//Жив ли автор?(по-умолчанию да)

        //Получение текущего возраста или в каком возрасте он откис
        public int GetAge()
        {
            TimeSpan age;

            if (!IsAlive)
            {
                age = DeathDate - BirthDate;
                return Age = age.Days/365;

            }
            else
            {
                age=DateTime.Now-BirthDate;
                return age.Days / 365;
            }
        }
    }
}
