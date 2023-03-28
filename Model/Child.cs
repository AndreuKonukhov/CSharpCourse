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
    }
}
