
namespace Model
{
    /// <summary>
    /// Класс описывающий ребенка
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Отец ребенка.
        /// </summary>
        private Adult _father;

        /// <summary>
        /// Мать ребенка.
        /// </summary>
        private Adult _mother;

        /// <summary>
        /// Школа ребенка.
        /// </summary>
        private string _school;

        /// <summary>
        /// Maximum age of a child.
        /// </summary>
        private const int MaxAgeChild = 16;

        /// <summary>
        /// Ввод информации о отце ребенка
        /// </summary>
        public Adult Father
        {
            get => _father;
            set
            {
                CheckParentGender(value, Gender.Female);
                _father = value;
            }
        }

        /// <summary>
        /// Ввод информации о матери ребенка
        /// </summary>
        public Adult Mother
        {
            get => _mother;
            set
            {
                CheckParentGender(value, Gender.Male);
                _mother = value;
            }
        }

        /// <summary>
        /// Ввод информации о школе ребенка.
        /// </summary>
        public string School
        {
            get => _school;
            set
            {
                _school = value;
            }
        }

        /// <summary>
        /// Конструктор класса Child.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="father">Отец ребенка.</param>
        /// <param name="mother">Мать ребенка</param>
        /// <param name="school">Школа ребенка.</param>
        public Child(string name, string surname, int age,
            Gender gender, Adult father, Adult mother,
            string school) : base(name, surname, age, gender)
        {
            Father = father;
            Mother = mother;
            School = school;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Child() : this("Unknown", "Unknown", 11,
            Gender.Male, null, null, null)
        { }

        /// <summary>
        /// Проверка пола родителей ребенка
        /// </summary>
        /// <param name="parent">Один из родителей ребенка.</param>
        /// <param name="gender">Необходимый пол родителя.</param>
        /// <exception cref="ArgumentException">Недопустимый пол
        /// для данного родителя.</exception>
        private static void CheckParentGender
            (Adult parent, Gender gender)
        {
            if (parent != null && parent.Gender == gender)
            {
                throw new ArgumentException
                    ("Parent gender must be another");
            }
        }

        /// <summary>
        /// Конвертация полей класса Chuld в строковый формат.
        /// </summary>
        /// <returns>Информация о ребенке.</returns>
        public override string GetInfo()
        {
            var fatherStatus = "Информации об отце нет";
            var motherStatus = "Информации о матери нет";

            if (Father != null)
            {
                fatherStatus = Father.GetNameSurname();
            }
            if (Mother != null)
            {
                motherStatus = Mother.GetNameSurname();
            }

            var schoolStatus = "Не обучается";
            if (!string.IsNullOrEmpty(School))
            {
                schoolStatus = $"Учиться в ({School})";
            }

            return $"{PrintPerson()};\n" +
                $"Отец: {fatherStatus};\n" +
                $"Мать: {motherStatus};\n" +
                $"Школа: {schoolStatus}\n";
        }

        /// <summary>
        /// Метод генерирующий случайного ребенка.
        /// </summary>
        /// <returns>Экземпляр класса Adult.</returns>
        public static Child GetRandomPerson
            (Gender randomGender = Gender.Unknown)
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
                "Shade", "Maximoff", "Romanov", "Walker", "Danvers"
            };

            string[] schools =
            {
                "Energy school", "IT school",
                "school №3",
                "GeekBrains"
            };

            var random = new Random();

            if (randomGender == Gender.Unknown)
            {
                var tmpNumber = random.Next(1, 3);
                randomGender = tmpNumber == 1
                    ? Gender.Male
                    : Gender.Female;
            }

            string randomName = randomGender == Gender.Male
                ? maleNames[random.Next(maleNames.Length)]
                : femaleNames[random.Next(femaleNames.Length)];

            var randomSurname = surnames[random.Next(surnames.Length)];

            var randomAge = random.Next(MinAge, MaxAgeChild);

            Adult randomFather = GetRandomParent(1);

            Adult randomMother = GetRandomParent(2);


            var schoolRandom = random.Next(1, 3);
            string? randomSchool = schoolRandom == 1
                ? schools[random.Next(schools.Length)]
            : null;

            return new Child(randomName, randomSurname, randomAge,
                randomGender, randomFather, randomMother, randomSchool);
        }


        /// <summary>
        /// Генерация случайного родителя
        /// </summary>
        /// <param name="a">Параметр случайного родителя.</param>
        /// <returns>Объект класса Adult.</returns>
        /// <exception cref="ArgumentException">
        /// Ожидается ввод цифры 1 или 2.</exception>
        public static Adult GetRandomParent(int a)
        {
            var random = new Random();
            var parentStatus = random.Next(1, 3);
            if (parentStatus == 1)
            {
                return null;
            }
            else
            {
                switch (a)
                {
                    case 1:
                        return Adult.GetRandomPerson(Gender.Male);
                    case 2:
                        return Adult.GetRandomPerson(Gender.Female);
                    default:
                        throw new ArgumentException
                            ("Необходимо ввести число 1 или 2");
                }
            }

        }

        /// <summary>
        /// Проверка возраста ребенка.
        /// </summary>
        /// <param name="age">Возраст ребенка.</param>
        /// <exception cref="IndexOutOfRangeException">Возраст не входит
        /// в допустимый диапазон.</exception>
        protected override void CheckAge(int age)
        {
            if (age is < MinAge or > MaxAgeChild)
            {
                throw new IndexOutOfRangeException($"Возраст ребенка" +
                    $" должен находится в диапазоне " +
                    $"[{MinAge}...{MaxAgeChild}].");
            }
        }
    }
}
