
using System.Globalization;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Класс описывающий человека.
    /// </summary>
    public abstract class PersonBase
    {
        /// <summary>
        /// Имя человека.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия человека.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возраст человека.
        /// </summary>
        private int _age;

        /// <summary>
        /// Пол человека.
        /// </summary>
        private Gender _gender;

        /// <summary>
        /// Минимальный возраст человека.
        /// </summary>
        protected const int MinAge = 0;

        /// <summary>
        /// Максимальный возраст человека.
        /// </summary>
        protected const int MaxAge = 140;

        /// <summary>
        /// Ввод имени человека.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                //TODO: (выполнено)
                CheckUnknownLanguage(value);
                var tmpName = ChangeRegister(value);

                if (tmpName != null)
                {
                    CheckToLanguage();
                    _name = tmpName;
                }
                else
                {
                    throw new NullReferenceException
                        ("Имя не должно быть пустым");
                }
            }
        }

        /// <summary>
        /// Ввод фамили человека.
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                //TODO: (выполнено)
                CheckUnknownLanguage(value);
                var tmpSurname = ChangeRegister(value);
                if (tmpSurname != null)
                {
                    CheckToLanguage();
                    _surname = tmpSurname;
                }
            }
        }

        /// <summary>
        /// Ввод возраста человека.
        /// </summary>
        public int Age
        {
            get => _age;
            set
            {
                CheckAge(value);
                _age = value;
            }
        }

        /// <summary>
        /// Ввод пола человека.
        /// </summary>
        public Gender Gender
        {
            get => _gender;
            set => _gender = value;
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Имя человека.</param>
        /// <param name="surname">Фамилия человека.</param>
        /// <param name="age">Возраст человека.</param>
        /// <param name="gender">Пол человека.</param>
        public PersonBase(string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Метод, который конвертирует значение полей класса
        /// в строковый формат.
        /// </summary>
        /// <returns>Строка, содержащая информацию о человеке.</returns>
        public string PrintPerson()
        {
            return $"{Name} {Surname}; Возраст - {Age}; Пол - {Gender}";
        }


        /// <summary>
        /// Метод, проверяющий строку на язык.
        /// </summary>
        /// <param name="tmpsStr">Строка.</param>
        /// <returns>Язык передаваемой строки.</returns>
        private static Languages GetLanguage(string tmpsStr)
        {
            var ruLanguage = new Regex
                (@"^[A-z]+(-)?[A-z]*$");
            var engLanguage = new Regex
                (@"^[А-я]+(-)?[А-я]*$");

            if (!string.IsNullOrEmpty(tmpsStr))
            {
                if (engLanguage.IsMatch(tmpsStr))
                {
                    return Languages.Eng;
                }
                if (ruLanguage.IsMatch(tmpsStr))
                {
                    return Languages.Ru;
                }
            }
            return Languages.Unknown;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tmpStr"></param>
        /// <exception cref="ArgumentException"></exception>
        private void CheckUnknownLanguage(string tmpStr)
        {
            if (GetLanguage(tmpStr) == Languages.Unknown)
            {
                throw new ArgumentException("Некоректный ввод. Пожалуйста," +
                                " используйте только символы одного языка.");
            }
        }

        /// <summary>
        /// Проверка имени и фамилии на одинаковый язык
        /// </summary>
        /// <exception cref="FormatException">Имя и фамилия
        /// должны быть на одинаковом языке</exception>
        private void CheckToLanguage()
        {
            if (!string.IsNullOrEmpty(Name)
                && !string.IsNullOrEmpty(Surname))
            {
                var nameLanguage = GetLanguage(Name);
                var surnameLanguage = GetLanguage(Surname);

                if (nameLanguage != surnameLanguage)
                {
                    throw new FormatException("Имя и фамилия должны" +
                        " быть на одинаковом языке");
                }
            }
        }

        /// <summary>
        /// Метод для преобразования регистра:
        /// Первая буква - заглавная;
        /// Остальные - строчные.
        /// </summary>
        /// <param name="str">Строка (имя или фамилия).</param>
        /// <returns>Строка с преобразованным регистром.</returns>
        private static string ChangeRegister(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.
                ToTitleCase(str.ToLower());
        }

        /// <summary>
        /// Метод преобразует значения полей имени и фамилии
        /// в строковый формат.
        /// </summary>
        /// <returns>Фамилия и имя человека.</returns>
        public string GetNameSurname()
        {
            return $"{Name} {Surname}";
        }


        /// <summary>
        /// Метод, формирует информацию о человеке.
        /// </summary>
        public abstract string GetInfo();

        /// <summary>
        /// Проверка возраста человека.
        /// </summary>
        /// <param name="age">Возраст человека.</param>
        protected abstract void CheckAge(int age);
    }
}
