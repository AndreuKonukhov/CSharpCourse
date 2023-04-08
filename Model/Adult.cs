
namespace Model
{
    /// <summary>
    /// Класс описывающий взрослого человека.
    /// </summary>
    public class Adult : PersonBase
    {
        /// <summary>
        /// Серия и номер паспорта.
        /// </summary>
        private string _passportInfo;

        /// <summary>
        /// Партнер.
        /// </summary>
        private Adult _spouse;

        /// <summary>
        /// Место работы человека.
        /// </summary>
        private string _placeWork;

        //TODO: rename (выполнено)
        /// <summary>
        /// Минимальный возраст взрослого человека.
        /// </summary>
        private const int MinAge = 18;

        /// <summary>
        /// Ввод паспортных данных.
        /// </summary>
        public string PassportInfo
        {
            get => _passportInfo;
            set => _passportInfo = value;
        }

        /// <summary>
        /// Ввод места работы человека.
        /// </summary>
        public string PlaceWork
        {
            get => _placeWork;
            set => _placeWork = value;
        }

        /// <summary>
        /// Ввод семейного статуса человека.
        /// </summary>
        public Adult Spouse
        {
            get => _spouse;
            set => _spouse = value;

        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Имя человека.</param>
        /// <param name="surname">Фамилия человека.</param>
        /// <param name="age">Возраст человека.</param>
        /// <param name="gender">Пол человека.</param>
        /// <param name="passportInfo">Информация о паспорте.</param>
        /// <param name="placeWork">Место работы.</param>
        /// <param name="familyStatus">Семейное положение.</param>
        public Adult(string name, string surname, int age,
            Gender gender, string passportInfo, Adult familyStatus,
            string placeWork) : base(name, surname, age, gender)
        {
            PassportInfo = passportInfo;
            PlaceWork = placeWork;
            Spouse = familyStatus;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Adult() : this("Unknown", "Unknown", 19,
            Gender.Male, "2247 876589", null, null)
        { }

        /// <summary>
        /// Преобразование значений полей класса в строковый формат.
        /// </summary>
        /// <returns>Информация о взрослом человеке.</returns>
        public override string GetInfo()
        {
            string familyStatusInfo = "Холост";
            string workInfo = "Не имеет работы";

            if (Gender.Equals(Gender.Male) && Spouse != null)
            {
                familyStatusInfo = $"Женат на " +
                    $"{Spouse.GetNameSurname()}";
            }

            if (Gender.Equals(Gender.Female))
            {
                familyStatusInfo = Spouse == null
                    ? $"Не замужем"
                    : $"Замужем за " +
                    $"{Spouse.GetNameSurname()}";
            }

            if (!string.IsNullOrEmpty(PlaceWork))
            {
                workInfo = PlaceWork;
            }

            return $"{PrintPerson()};\n" +
                $"Серия и номер паспорта: {PassportInfo};\n" +
                $"Семейное положение: {familyStatusInfo};\n" +
                $"Место работы: {workInfo}\n ";
        }

        /// <summary>
        /// Метод генерирующий случайного взрослого человека.
        /// </summary>
        /// <returns>Экземпляр класса Adult.</returns>
        public static Adult GetRandomPerson
            (Gender gender = Gender.Unknown)
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

            string[] workPlaces =
            {
                "TPU", "TUSUR",
                "Tower of Stark",
                "Microsoft"
            };

            var random = new Random();

            if (gender is Gender.Unknown)
            {
                gender = random.Next(1, 100) > 50
                    ? Gender.Female
                    : Gender.Female;
            }


            string randomName = gender == Gender.Male
                ? maleNames[random.Next(maleNames.Length)]
                : femaleNames[random.Next(femaleNames.Length)];

            var randomSurname = surnames[random.Next(surnames.Length)];

            var randomAge = random.Next(MinAge, MaxAge);

            string randomSeriesPassport = "";
            for (int i = 0; i < 4; i++)
            {
                randomSeriesPassport += random.Next(1, 10).ToString();
            }
            string randomNumberPassport = "";
            for (int i = 0; i < 6; i++)
            {
                randomNumberPassport += random.Next(1, 10).ToString();
            }

            var randomPassport = $"{randomSeriesPassport} " +
                                 $"{randomNumberPassport}";

            Adult randomHuman = null;
            var statusFamily = random.Next(1, 3);
            if (statusFamily == 1)
            {
                // Можно вызвать тот же метод GetRandomPerson
                randomHuman = new Adult();

                randomHuman.Gender = gender == Gender.Female
                    ? Gender.Male
                    : Gender.Female;

                randomHuman.Name = gender == Gender.Female
                    ? maleNames[random.Next(maleNames.Length)]
                    : femaleNames[random.Next(femaleNames.Length)];

                randomHuman.Surname = surnames[random.Next(surnames.Length)];
            }

            var randonWorkPlace = random.Next(1, 3);
            string? randomWorkPlace = randonWorkPlace == 1
                ? workPlaces[random.Next(workPlaces.Length)]
                : null;

            return new Adult(randomName, randomSurname, randomAge, gender,
                randomPassport, randomHuman, randomWorkPlace);
        }

        /// <summary>
        /// Метод проверяет допустимость возраста.
        /// </summary>
        /// <param name="age">Возраст взрослого человека.</param>
        /// <exception cref="IndexOutOfRangeException">Возраст должен
        /// находится в определнных пределах.</exception>
        protected override void CheckAge(int age)
        {
            if (age is < MinAge or > MaxAge)
            {
                throw new IndexOutOfRangeException($"Возраст должен" +
                    $" быть в диапазоне ({MinAge}...{MaxAge}).");
            }
        }

        /// <summary>
        /// Метод назначает ранг мстителю
        /// </summary>
        /// <returns>Информация о ранге мстителя.</returns>
        public string GetRank()
        {
            var rnd = new Random();

            string[] ranks =
            {
                "SS", "S+", "A+", "A", "B", "F"
            };

            var chosenRank = ranks[rnd.Next(ranks.Length)];

            return $"Ранг мстителя - {chosenRank}";
        }

    }
}
