using System;

namespace ITMO.CourseCS.FormsApp.Ex03._4
{
    class Person
    {
        private string name;
        private string surname;
        private DateTime birthday;
        private string email;
        private string favBook;

        public Person()
        {

        }

        public Person(string name, string surname, DateTime birthday, string email, string favBook)
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
            this.email = email;
            this.favBook = favBook;
        }

        public override string ToString()
        {
            return "\nФамилия: " + surname + "\nИмя: " + name + "\nДата рождения: " + birthday.ToString("d") + "\ne-mail: " + email + "\nЛюбимая книга: " + favBook;
        }





    }
}