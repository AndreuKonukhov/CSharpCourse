
using System.Globalization;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Класс описывающий человека.
    /// </summary>
    public class Person
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
        private const int MinAge = 0;

        /// <summary>
        /// Максимальный возраст человека.
        /// </summary>
        private const int MaxAge = 120;

        /// <summary>
        /// Ввод имени человека.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
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
            get
            {
                return _surname;
            }
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
            get
            {
                return _age;
            }
            set
            {
                if (value > MinAge && value < MaxAge)
                {
                    _age = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Возраст человека" +
                    $" должен находится в диапазоне от {MinAge} до" +
                    $" {MaxAge} лет");
                }
            }
        }

        /// <summary>
        /// Ввод пола человека.
        /// </summary>
        public Gender Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Имя человека.</param>
        /// <param name="surname">Фамилия человека.</param>
        /// <param name="age">Возраст человека.</param>
        /// <param name="gender">Пол человека.</param>
        public Person(string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Person()
        {
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
        /// Метод для генерации человека со случайными  именем, фамилией,
        /// возрастом и полом. 
        /// </summary>
        /// <returns>Объект Person cо случайными значениями атрибутов имя,
        /// фамилия, возраст и пол.</returns>
        public static Person GetRandomAvenger()
        {
            string[] maleNames =
            {
                "Tony", "Thor", "Bruce", "Steven", "Clinton"
            };

            string[] femaleNames =
            {
                "Wanda", "Natasha", "Patricia", "Jane", "Jen",
            };

            string[] surnames =
            {
                "Stark", "Odinson", "Banner", "Rogers", "Barton",
                "Shade", "Maximoff", "Romanova", "Walker", "Danvers"
            };

            var randPerson = new Random();


            //Генерация случайной личности.
            Gender randomGender = randPerson.Next(0, 2) == 0
                ? Gender.Male
                : Gender.Female;

            string randomName = randomGender == Gender.Male
                ? maleNames[randPerson.Next(maleNames.Length)]
                : femaleNames[randPerson.Next(femaleNames.Length)];

            var randomSurname = surnames[randPerson.Next(surnames.Length)];

            var randomAge = randPerson.Next(MinAge, MaxAge);

            return new Person(randomName, randomSurname, randomAge, randomGender);
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
    }
}
