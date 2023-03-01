using Model;

namespace Model
{
    /// <summary>
    /// Класс Program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Класс Main
        /// </summary>
        private static void Main()
        {
            //Добавление первых трёх мстителей в список Avengers
            var listAvengers = new PersonList();
            var stark = new Person("Tony", "Stark", 38, Gender.Male);
            var halk = new Person("Bruce", "Banner", 46, Gender.Male);
            var natasha = new Person("Natasha", "Romanova", 39, Gender.Female);
            listAvengers.AddPerson(stark);
            listAvengers.AddPerson(halk);
            listAvengers.AddPerson(natasha);

            //Добавление вторых трёх мстителей в список Bvengers
            var listBvengers = new PersonList();
            var cap = new Person("Steven", "Rogers", 112, Gender.Male);
            var thor = new Person("Thor", "Odinson", 39, Gender.Male);
            var wanda = new Person("Wanda", "Maximoff", 25, Gender.Female);
            listBvengers.AddPerson(cap);
            listBvengers.AddPerson(thor);
            listBvengers.AddPerson(wanda);

            // Вывод информации о списке людей
            _ = Console.ReadKey();
            Console.WriteLine("Список членов группы Avengers:");
            PrintList(listAvengers);
            Console.WriteLine("\nСписок членов группы Bvengers:");
            PrintList(listBvengers);

            // Добавление нового мстителя в список Avengers
            _ = Console.ReadKey();
            var sokol = new Person("Clinton", "Barton", 47, Gender.Male);
            listAvengers.AddPerson(sokol);
            Console.WriteLine("\n\t-=В Avengers успешно добавлен" +
                $" новый мститель {sokol.Name} {sokol.Surname}=-\n");

            // Копирование второго мстителя из Avengers в конец
            // списка Bvengers
            _ = Console.ReadKey();
            Person copyPerson = listAvengers.FindPersonByIndex(1);
            listBvengers.AddPerson(copyPerson);
            Console.WriteLine($"\n\t-=Второй мститель" +
                $" {copyPerson.Name} {copyPerson.Surname} успешно" +
                $" копирован из списка Avengers в конец списка Bvengers=-\n");

            // Вывод информации о списке людей
            Console.WriteLine("Список членов группы Avengers:");
            PrintList(listAvengers);
            Console.WriteLine("\nСписок членов группы Bvengers:");
            PrintList(listBvengers);

            // Удаление второго мстителя из списка Avengers
            _ = Console.ReadKey();
            listAvengers.DeletePersonByIndex(1);
            Console.WriteLine("\n\t-=Второй мститель из списка Avengers " +
                              "успешно удален=-\n");

            // Вывод информации о списке людей
            Console.WriteLine("Список членов группы Avengers:");
            PrintList(listAvengers);
            Console.WriteLine("\nСписок членов группы Bvengers:");
            PrintList(listBvengers);

            // Очистка списка Bvengers
            _ = Console.ReadKey();
            listBvengers.ClearList();
            Console.WriteLine("\n\t-=Список Bvengers успешно очищен=-\n");

            // Вывод информации о списке людей
            Console.WriteLine("\nСписок членов группы Bvengers:");
            PrintList(listBvengers);

            //Чтение персоны с клавиатуры
            Console.WriteLine("\n\t-=Проверка ввода человека" +
                              " с клавиатуры=-\n");
            try
            {
                Person inputPerson = InputPersonByConsole();
                Console.WriteLine("\nВы ввели следующего человека:\n" +
                                  $"{inputPerson.PrintPerson()}\n");
            }
            catch (Exception exception)
            {
                if (exception.GetType()
                        == typeof(IndexOutOfRangeException)
                        || exception.GetType() == typeof(FormatException)
                        || exception.GetType() == typeof(ArgumentException))
                {
                    Console.WriteLine
                    ($"Ошибка! {exception.Message}.");
                }
                else
                {
                    throw exception;
                }
            }

            var randomPerson = Person.GetRandomAvenger();
            Console.WriteLine(randomPerson.PrintPerson());
        }

        /// <summary>
        /// Вывод на консоль информации о каждом человеке
        /// в списке людей.
        /// </summary>
        /// <param name="listOfPersons">Список людей</param>
        /// <exception cref="NullReferenceException">
        /// Список людей не должен принимать значение Null</exception>
        private static void PrintList(PersonList listOfPersons)
        {
            if (listOfPersons == null)
            {
                throw new NullReferenceException
                    ("Значение списка людей - Null.");
            }

            if (listOfPersons.CountPersons != 0)
            {
                for (int i = 0; i < listOfPersons.CountPersons; i++)
                {
                    var person = listOfPersons.FindPersonByIndex(i);
                    Console.WriteLine(person.PrintPerson());
                }
            }
            else
            {
                Console.WriteLine("Список людей пуст :(");
            }
        }

        /// <summary>
        /// Метод, который позволяет вводить информацию с помощью консоли.
        /// </summary>
        /// <returns>Экземпляр класса Person.</returns>
        public static Person InputPersonByConsole()
        {
            var person = new Person();

            var actionList = new List<(Action, string)>
            {
                (
                new Action(() =>
                {
                    Console.Write($"Введите имя человека: ");
                    person.Name = Console.ReadLine();
                }), "name"),

                (new Action(() =>
                {
                    Console.Write($"Введите фамилию человека: ");
                    person.Surname = Console.ReadLine();
                }), "surname"),

                (new Action(() =>
                {
                    Console.Write($"Введите возраст человека: ");
                    _ = int.TryParse(Console.ReadLine(), out int tmpAge);
                    person.Age = tmpAge;
                }), "age"),

                (new Action(() =>
                {
                    Console.Write ("Введите пол человека (1 - Мужчина or" +
                                   " 2 - Женщина): ");
                    _ = int.TryParse(Console.ReadLine(), out int tmpGender);
                    if (tmpGender < 1 || tmpGender > 2)
                    {
                        throw new IndexOutOfRangeException
                           ("Необходимо ввести цифру в диапазоне от 1 до 2");
                    }

                    var realGender = tmpGender == 1
                        ? Gender.Male
                        : Gender.Female;
                    person.Gender = realGender;
                }), "gender")
            };

            foreach (var action in actionList)
            {
                ActionHandler(action.Item1);
            }

            return person;
        }

        /// <summary>
        /// Метод, обрабатывающий исключения
        /// </summary>
        /// <param name="action"></param>
        /// <param name="propertyName"></param>
        private static void ActionHandler(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    break;
                }
                catch (Exception exception)
                {
                    if (exception.GetType()
                        == typeof(IndexOutOfRangeException)
                        || exception.GetType() == typeof(FormatException)
                        || exception.GetType() == typeof(ArgumentException))
                    {
                        Console.WriteLine($"\nОшибка!!! {exception.Message}" +
                            $" Повторите ввод заного.\n");
                    }
                    else
                    {
                        throw exception;
                    }
                }
            }
        }
    }
}