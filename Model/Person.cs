
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
                _ = DefinitionLanguage(value);
                _name = ChangeRegister(value);

                if (_name != null)
                {
                    CheckToLanguage();
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
                _ = DefinitionLanguage(value);
                _surname = ChangeRegister(value);

                if (_surname != null)
                {
                    CheckToLanguage();
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
                _age = value > MinAge && value < MaxAge
                    ? value
                    : throw new IndexOutOfRangeException("Возраст человека" +
                    $" должен находится в диапазоне от {MinAge} до" +
                    $" {MaxAge} лет");
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
        /// <param name="str">Строка.</param>
        /// <returns>Язык передаваемой строки.</returns>
        private static Languages DefinitionLanguage(string str)
        {
            var ruLanguage = new Regex
                (@"^[A-z]+(-)?[A-z]*$");
            var engLanguage = new Regex
                (@"^[А-я]+(-)?[А-я]*$");

            if (string.IsNullOrEmpty(str) == false)
            {
                if (engLanguage.IsMatch(str))
                {
                    return Languages.Eng;
                }
                else if (ruLanguage.IsMatch(str))
                {
                    return Languages.Ru;
                }
                else
                {
                    throw new ArgumentException("Некоректный ввод. " +
                        "Пожалуйста, используйте только" +
                        " символы одного языка.");
                }
            }
            return Languages.Unknown;
        }

        /// <summary>
        /// Проверка имени и фамилии на одинаковый язык
        /// </summary>
        /// <exception cref="FormatException"></exception>
        private void CheckToLanguage()
        {
            if (!string.IsNullOrEmpty(Name)
                && !string.IsNullOrEmpty(Surname))
            {
                var nameLanguage = DefinitionLanguage(Name);
                var surnameLanguage = DefinitionLanguage(Surname);

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
        /// Get the information about a person.
        /// </summary>
        /// <returns></returns>
        public abstract string GetInfoAdult();

        /// <summary>
        /// Check person's age.
        /// </summary>
        /// <param name="age">Person's age.</param>
        protected abstract void CheckAge(int age);
    }
}
